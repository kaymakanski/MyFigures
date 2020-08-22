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
    public partial class CreateCircleForm : Form
    {
        public CreateCircleForm()
        {
            InitializeComponent();
        }

        private int diameter;
        private void button2_Click(object sender, EventArgs e)
        {
            bool isRadiusNumeric = int.TryParse(diameterInput.Text, out diameter);
            
            if (!isRadiusNumeric)
                MessageBox.Show("Please input a valid diameter!");

            FiguresBuilder circleBuilder = FiguresBuilder.createCircle(diameter);
            MainForm.figuresBuilder = circleBuilder;

            if(isRadiusNumeric)
                this.DialogResult = DialogResult.OK; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
