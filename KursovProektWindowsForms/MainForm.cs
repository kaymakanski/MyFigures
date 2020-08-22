using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiguresLib;

namespace KursovProektWindowsForms
{
    public partial class MainForm : Form
    {
        public static List<Figures> _figures = new List<Figures>();

        public static Figures selectedFigure;
        public static FiguresBuilder figuresBuilder;

        private static readonly string myDocsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        private static readonly string filePath = Path.Combine(myDocsPath, "figures");

        public MainForm()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteFiguresForm deleteFigures = new DeleteFiguresForm();
            deleteFigures.ShowDialog();

            displayArea();
            Invalidate();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var binFormater = new BinaryFormatter();
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                binFormater.Serialize(fs, _figures);
                binFormater.Serialize(fs, AreaAccumulator.CircleArea);
                binFormater.Serialize(fs, AreaAccumulator.SquareArea);
                binFormater.Serialize(fs, AreaAccumulator.RectangleArea);
                binFormater.Serialize(fs, AreaAccumulator.TriangleArea);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
                return;

            var binFormater = new BinaryFormatter();
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                _figures = (List<Figures>)binFormater.Deserialize(fs);
                AreaAccumulator.CircleArea = (double)binFormater.Deserialize(fs);
                AreaAccumulator.SquareArea = (double)binFormater.Deserialize(fs);
                AreaAccumulator.RectangleArea = (double)binFormater.Deserialize(fs);
                AreaAccumulator.TriangleArea = (double)binFormater.Deserialize(fs);
            }
            displayArea();
            Invalidate();
        }
        private void statisticsButton_Click_1(object sender, EventArgs e)
        {
            StatisticForm statistic = new StatisticForm();
            statistic.ShowDialog();
        }

        private void createRectangle_Click(object sender, EventArgs e)
        {
            CreateRectangleForm createRectangleForm = new CreateRectangleForm();
            createRectangleForm.ShowDialog();
        }

        private void createSquare_Click(object sender, EventArgs e)
        {
            CreateSquareForm createSquareForm = new CreateSquareForm();
            createSquareForm.ShowDialog();
        }

        private void createCircle_Click(object sender, EventArgs e)
        {
            CreateCircleForm createCircle = new CreateCircleForm();
            createCircle.ShowDialog();
        }

        private void createTriangle_Click(object sender, EventArgs e)
        {
            CreateTriangleForm createTriangleForm = new CreateTriangleForm();
            createTriangleForm.ShowDialog();
        }

        private void randomFigure_Click(object sender, EventArgs e)
        {
            selectedFigure = new RandomFigure();

            using (var graphics = CreateGraphics())
            {
                selectedFigure.Paint(graphics);
            }
            _figures.Add(selectedFigure);
            AreaAccumulator.accumulateArea(selectedFigure.Area, selectedFigure.FigureType);
            displayArea();
        }

        private void choseColorButton_Click(object sender, EventArgs e)
        {
            ChoseColorForm choseColor = new ChoseColorForm();
            choseColor.ShowDialog();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (figuresBuilder == null)
                return;

            selectedFigure = figuresBuilder.build();
            selectedFigure.Location = e.Location;
            if (ChoseColorForm.chosenColor == default)
            {
                ChoseColorForm.getFigureBaseColor(selectedFigure.FigureType);
                selectedFigure.Color = ChoseColorForm.baseColor;
            }
            else
                selectedFigure.Color = ChoseColorForm.chosenColor;

            AreaAccumulator.accumulateArea(selectedFigure.Area, selectedFigure.FigureType);
            displayArea();

            _figures.Add(selectedFigure);
            Invalidate();
        }

        public void displayArea()
        {
            accumulatedSquaresArea.Text = $"Squares area: {AreaAccumulator.SquareArea}";

            accumulatedRectanglesArea.Text = $"Rectangles area: {AreaAccumulator.RectangleArea}";

            accumulatedCirclesArea.Text = $"Circles area: {AreaAccumulator.CircleArea:0.00}";

            accumulatedTrianglesArea.Text = $"Triangles area: {AreaAccumulator.TriangleArea}";
        }

        public static void calculateNewArea()
        {
            AreaAccumulator.CircleArea = _figures
                 .Where(x => x.FigureType.Equals(FiguresEnum.Circle))
                 .Select(s => s.Area)
                 .Sum();

            AreaAccumulator.RectangleArea = _figures
                .Where(x => x.FigureType == FiguresEnum.Rectangle)
                .Select(s => s.Area)
                .Sum();

            AreaAccumulator.SquareArea = _figures
                .Where(x => x.FigureType == FiguresEnum.Square)
                .Select(s => s.Area)
                .Sum();

            AreaAccumulator.TriangleArea = _figures
                .Where(x => x.FigureType == FiguresEnum.Triangle)
                .Select(s => s.Area)
                .Sum();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var figure in _figures)
                figure.Paint(e.Graphics);
        }
    }
}
