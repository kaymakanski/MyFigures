namespace KursovProektWindowsForms
{
    partial class AdditionalDeleteChoicesForm
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
            this.greaterOrLesserComboBox = new System.Windows.Forms.ComboBox();
            this.figureComboBox = new System.Windows.Forms.ComboBox();
            this.desiredAreaTextBox = new System.Windows.Forms.TextBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greaterOrLesserComboBox
            // 
            this.greaterOrLesserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.greaterOrLesserComboBox.FormattingEnabled = true;
            this.greaterOrLesserComboBox.Items.AddRange(new object[] {
            "greater than",
            "lesser than"});
            this.greaterOrLesserComboBox.Location = new System.Drawing.Point(260, 38);
            this.greaterOrLesserComboBox.Name = "greaterOrLesserComboBox";
            this.greaterOrLesserComboBox.Size = new System.Drawing.Size(119, 24);
            this.greaterOrLesserComboBox.TabIndex = 1;
            // 
            // figureComboBox
            // 
            this.figureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figureComboBox.FormattingEnabled = true;
            this.figureComboBox.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Circle",
            "Triangle",
            "Figures"});
            this.figureComboBox.Location = new System.Drawing.Point(85, 38);
            this.figureComboBox.Name = "figureComboBox";
            this.figureComboBox.Size = new System.Drawing.Size(98, 24);
            this.figureComboBox.TabIndex = 5;
            this.figureComboBox.SelectedIndexChanged += new System.EventHandler(this.figureComboBox_SelectedIndexChanged);
            // 
            // desiredAreaTextBox
            // 
            this.desiredAreaTextBox.Location = new System.Drawing.Point(385, 39);
            this.desiredAreaTextBox.Name = "desiredAreaTextBox";
            this.desiredAreaTextBox.Size = new System.Drawing.Size(81, 22);
            this.desiredAreaTextBox.TabIndex = 6;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Green",
            "Purple",
            "Tan",
            "Brown",
            "Teal",
            "Coral"});
            this.colorComboBox.Location = new System.Drawing.Point(85, 105);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 24);
            this.colorComboBox.TabIndex = 8;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(269, 105);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 24);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delete all";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Delete all";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "with area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "figures";
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(472, 38);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(76, 24);
            this.deleteButton2.TabIndex = 16;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(240, 192);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(105, 33);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AdditionalDeleteChoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 282);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.desiredAreaTextBox);
            this.Controls.Add(this.figureComboBox);
            this.Controls.Add(this.greaterOrLesserComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdditionalDeleteChoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional delete choices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox greaterOrLesserComboBox;
        private System.Windows.Forms.ComboBox figureComboBox;
        private System.Windows.Forms.TextBox desiredAreaTextBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button okButton;
    }
}