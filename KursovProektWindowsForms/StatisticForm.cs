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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void showStatsButton_Click(object sender, EventArgs e)
        {
            statisticsTextBox.Clear();
            List<Figures> orderedFigures = new List<Figures>();           
                            
            if (orderByComboBox.Text.Equals("Area"))
                    orderedFigures = MainForm._figures
                         .OrderBy(f => f.Area)
                         .ToList();
            if (orderByComboBox.Text.Equals("Color"))
                    orderedFigures = MainForm._figures
                        .OrderBy(f => f.Color.Name)
                        .ToList();
            if (orderByComboBox.Text.Equals("Figure"))
                    orderedFigures = MainForm._figures
                        .OrderBy(f => f.FigureType)
                        .ToList();
            
            if (!checkBoxAscending.Checked)
            {
                orderedFigures.Reverse();
            }

            statisticsTextBox.AppendText($"|  {"Figure",-15}\t |  {"Color",-10}\t |  {"Area"} {"",-40}\t |");

            foreach (var figure in orderedFigures)
            {
                statisticsTextBox.AppendText(Environment.NewLine);
                statisticsTextBox.AppendText(figure.ToString());
            }
        }
    }
}
