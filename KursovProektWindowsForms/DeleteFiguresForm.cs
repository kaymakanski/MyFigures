using System;
using System.Linq;
using System.Windows.Forms;
using FiguresLib;

namespace KursovProektWindowsForms
{
    public partial class DeleteFiguresForm : Form
    {

        public DeleteFiguresForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (circlesChecked.CheckState == CheckState.Checked)
            {
                MainForm._figures.RemoveAll(x => x.FigureType == FiguresEnum.Circle);
                AreaAccumulator.resetArea(FiguresEnum.Circle);
            }
            if (rectanglesChecked.CheckState == CheckState.Checked)
            {
                MainForm._figures.RemoveAll(x => x.FigureType == FiguresEnum.Rectangle);
                AreaAccumulator.resetArea(FiguresEnum.Rectangle);
            }
            if (squaresChecked.CheckState == CheckState.Checked)
            {
                MainForm._figures.RemoveAll(x => x.FigureType == FiguresEnum.Square);
                AreaAccumulator.resetArea(FiguresEnum.Square);
            }
            if (trianglesChecked.CheckState == CheckState.Checked)
            {
                MainForm._figures.RemoveAll(x => x.FigureType == FiguresEnum.Triangle);
                AreaAccumulator.resetArea(FiguresEnum.Triangle);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void additionalChoicesButton_Click(object sender, EventArgs e)
        {
            AdditionalDeleteChoicesForm formatFiguresForm = new AdditionalDeleteChoicesForm();
            formatFiguresForm.Show();
        }

        private void deleteAllFiguresbutton_Click(object sender, EventArgs e)
        {
            MainForm._figures.Clear();
            MainForm.calculateNewArea();

            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MainForm._figures.Count == 0)
                return;

            MainForm._figures
                .Remove(MainForm._figures
                    .ElementAt(MainForm._figures.Count - 1));

            this.DialogResult = DialogResult.OK;
        }
    }
}
