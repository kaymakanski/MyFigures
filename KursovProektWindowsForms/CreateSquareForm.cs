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
    public partial class CreateSquareForm : Form
    {
        public CreateSquareForm()
        {
            InitializeComponent();
        }

        private int side;
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {            
            bool isSideNumeric = int.TryParse(sideInput.Text, out side);

            if (!isSideNumeric)
                MessageBox.Show("Please input a valid side!");
            

            FiguresBuilder squareBuilder = FiguresBuilder.createSquare(side);      
            
            MainForm.figuresBuilder = squareBuilder;      
            
            if(isSideNumeric)
                this.DialogResult = DialogResult.OK;
        }
    }
}
