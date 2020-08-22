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
    public partial class CreateTriangleForm : Form
    {
        public CreateTriangleForm()
        {
            InitializeComponent();
        }

        private int sideAB, sideAC;

        private void button1_Click(object sender, EventArgs e)
        {
            bool isABnumeric = int.TryParse(sideABinput.Text, out sideAB);
            bool isACnumeric = int.TryParse(sideACinput.Text, out sideAC);

            if (!isABnumeric || !isACnumeric)
            {
                MessageBox.Show("Please input valid parameters!");
            }

            FiguresBuilder triangleBuilder = FiguresBuilder.createTriangle(sideAB, sideAC);
            MainForm.figuresBuilder = triangleBuilder;

            if(isABnumeric && isACnumeric)
                this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
