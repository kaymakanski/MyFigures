using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiguresLib;

namespace KursovProektWindowsForms
{
    public partial class ChoseColorForm : Form
    {        
        public ChoseColorForm()
        {
            InitializeComponent();
        }

        public static Color chosenColor;
        public static Color baseColor;
        public static void getFigureBaseColor(FiguresEnum figuresEnum)
        {
            if (figuresEnum == FiguresEnum.Circle)
                baseColor = Circle.getBaseColor;
            if (figuresEnum == FiguresEnum.Square)
                baseColor = Square.getBaseColor;
            if (figuresEnum == FiguresEnum.Rectangle)
                baseColor = FiguresLib.Rectangle.getBaseColor;
            if (figuresEnum == FiguresEnum.Triangle)
                baseColor = Triangle.getBaseColor;
        }      
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (redButton.Checked)
                chosenColor = Color.Red;
            if (blueButton.Checked)
                chosenColor = Color.Blue;
            if (yellowButton.Checked)
                chosenColor = Color.Yellow;
            if (greenButton.Checked)
                chosenColor = Color.Green;
            if (purpleButton.Checked)
                chosenColor = Color.Purple;
            if (tanButton.Checked)
                chosenColor = Color.Tan;
            if (brownButton.Checked)
                chosenColor = Color.Brown;
            if (tealButton.Checked)
                chosenColor = Color.Teal;
            if (coralButton.Checked)
                chosenColor = Color.Coral;

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
