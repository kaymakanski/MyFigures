using FiguresLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace KursovProektWindowsForms
{
    public partial class CreateRectangleForm : Form
    {
        public CreateRectangleForm()
        {
            InitializeComponent();
        }
        private int width, height;
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isWidthNumeric = int.TryParse(widthInput.Text, out width);
            bool isHeightNumeric = int.TryParse(heightInput.Text, out height);

            if(!isHeightNumeric || !isWidthNumeric)
            {
                MessageBox.Show("Please input valid parameters!");
            }
            
            FiguresBuilder rectangleBuilder = FiguresBuilder.createRectangle(width, height);
            MainForm.figuresBuilder = rectangleBuilder;

            if (isHeightNumeric && isWidthNumeric)
                this.DialogResult = DialogResult.OK;
        }
    }
}
