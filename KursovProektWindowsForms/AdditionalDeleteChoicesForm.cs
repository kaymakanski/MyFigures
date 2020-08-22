using FiguresLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KursovProektWindowsForms
{
    public partial class AdditionalDeleteChoicesForm : Form
    {
        private ColorsEnum chosenColorEnum;
        private FiguresEnum chosenFigure;
        private double desiredArea;

        public AdditionalDeleteChoicesForm()
        {
            InitializeComponent();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(colorComboBox.Text, out chosenColorEnum))
                return;
        }

        private void figureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Enum.TryParse(figureComboBox.Text, out chosenFigure))
                return;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            if (colorComboBox.SelectedItem == null)
                return;
            var chosenColor = Color.FromName(chosenColorEnum.ToString());
            if (MainForm._figures.Exists(x => x.Color.Equals(chosenColor)))
            {
                MainForm._figures.RemoveAll(x => x.Color.Equals(chosenColor));
                MainForm.calculateNewArea();
                MessageBox.Show($"{chosenColorEnum} figures have been removed!");
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if (figureComboBox.SelectedItem == null || greaterOrLesserComboBox == null)
                return;

            if (!double.TryParse(desiredAreaTextBox.Text, out desiredArea) || desiredArea < 0)
            {
                MessageBox.Show("Please input a valid area!");
                return;
            }

            if (figureComboBox.SelectedIndex == 4) // (All)
            {
                if (greaterOrLesserComboBox.SelectedIndex == 0) // (greater than)
                {
                    if (MainForm._figures.Exists(x => x.Area > desiredArea))
                    {
                        MainForm._figures.RemoveAll(x => x.Area > desiredArea);
                        MessageBox.Show($"All figures with area greater than {desiredArea} have been removed");
                    }
                }
                if (greaterOrLesserComboBox.SelectedIndex == 1) // (lesser than)
                {
                    if (MainForm._figures.Exists(x => x.Area < desiredArea))
                    {
                        MainForm._figures.RemoveAll(x => x.Area < desiredArea);
                        MessageBox.Show($"All figures with area lesser than {desiredArea} have been removed");
                    }
                }
            }
            else
            {
                if (greaterOrLesserComboBox.SelectedIndex == 0) // (greater than)
                {
                    if (MainForm._figures
                        .Exists(x => x.FigureType == chosenFigure && x.Area > desiredArea))
                    {
                        MainForm._figures
                       .RemoveAll(x => x.FigureType == chosenFigure && x.Area > desiredArea);
                        MessageBox.Show($"All {chosenFigure}s with area greater than {desiredArea} have been removed");
                    }
                }
                if (greaterOrLesserComboBox.SelectedIndex == 1) // (lesser than)
                {
                    if (MainForm._figures
                        .Exists(x => x.FigureType == chosenFigure && x.Area < desiredArea))
                    {
                        MainForm._figures
                       .RemoveAll(x => x.FigureType == chosenFigure && x.Area < desiredArea);
                        MessageBox.Show($"All {chosenFigure}s with area lesser than {desiredArea} have been removed");
                    }
                }
            }
            MainForm.calculateNewArea();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
    }
}
