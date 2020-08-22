namespace KursovProektWindowsForms
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAscending = new System.Windows.Forms.CheckBox();
            this.statisticsTextBox = new System.Windows.Forms.TextBox();
            this.showStatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Items.AddRange(new object[] {
            "Area",
            "Color",
            "Figure"});
            this.orderByComboBox.Location = new System.Drawing.Point(92, 18);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(121, 24);
            this.orderByComboBox.TabIndex = 0;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order by";
            // 
            // checkBoxAscending
            // 
            this.checkBoxAscending.AutoSize = true;
            this.checkBoxAscending.Location = new System.Drawing.Point(229, 20);
            this.checkBoxAscending.Name = "checkBoxAscending";
            this.checkBoxAscending.Size = new System.Drawing.Size(96, 21);
            this.checkBoxAscending.TabIndex = 2;
            this.checkBoxAscending.Text = "Ascending";
            this.checkBoxAscending.UseVisualStyleBackColor = true;
            // 
            // statisticsTextBox
            // 
            this.statisticsTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statisticsTextBox.Location = new System.Drawing.Point(0, 77);
            this.statisticsTextBox.Multiline = true;
            this.statisticsTextBox.Name = "statisticsTextBox";
            this.statisticsTextBox.ReadOnly = true;
            this.statisticsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statisticsTextBox.Size = new System.Drawing.Size(620, 569);
            this.statisticsTextBox.TabIndex = 3;
            // 
            // showStatsButton
            // 
            this.showStatsButton.Location = new System.Drawing.Point(411, 9);
            this.showStatsButton.Name = "showStatsButton";
            this.showStatsButton.Size = new System.Drawing.Size(155, 43);
            this.showStatsButton.TabIndex = 5;
            this.showStatsButton.Text = "Show stats";
            this.showStatsButton.UseVisualStyleBackColor = true;
            this.showStatsButton.Click += new System.EventHandler(this.showStatsButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 646);
            this.Controls.Add(this.showStatsButton);
            this.Controls.Add(this.statisticsTextBox);
            this.Controls.Add(this.checkBoxAscending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderByComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAscending;
        private System.Windows.Forms.TextBox statisticsTextBox;
        private System.Windows.Forms.Button showStatsButton;
    }
}