namespace KursovProektWindowsForms
{
    partial class DeleteFiguresForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.circlesChecked = new System.Windows.Forms.CheckBox();
            this.rectanglesChecked = new System.Windows.Forms.CheckBox();
            this.squaresChecked = new System.Windows.Forms.CheckBox();
            this.trianglesChecked = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.additionalChoicesButton = new System.Windows.Forms.Button();
            this.deleteAllFiguresbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // circlesChecked
            // 
            this.circlesChecked.AutoSize = true;
            this.circlesChecked.Location = new System.Drawing.Point(53, 72);
            this.circlesChecked.Name = "circlesChecked";
            this.circlesChecked.Size = new System.Drawing.Size(72, 21);
            this.circlesChecked.TabIndex = 2;
            this.circlesChecked.Text = "Circles";
            this.circlesChecked.UseVisualStyleBackColor = true;
            // 
            // rectanglesChecked
            // 
            this.rectanglesChecked.AutoSize = true;
            this.rectanglesChecked.Location = new System.Drawing.Point(53, 122);
            this.rectanglesChecked.Name = "rectanglesChecked";
            this.rectanglesChecked.Size = new System.Drawing.Size(101, 21);
            this.rectanglesChecked.TabIndex = 3;
            this.rectanglesChecked.Text = "Rectangles";
            this.rectanglesChecked.UseVisualStyleBackColor = true;
            // 
            // squaresChecked
            // 
            this.squaresChecked.AutoSize = true;
            this.squaresChecked.Location = new System.Drawing.Point(53, 172);
            this.squaresChecked.Name = "squaresChecked";
            this.squaresChecked.Size = new System.Drawing.Size(83, 21);
            this.squaresChecked.TabIndex = 4;
            this.squaresChecked.Text = "Squares";
            this.squaresChecked.UseVisualStyleBackColor = true;
            // 
            // trianglesChecked
            // 
            this.trianglesChecked.AutoSize = true;
            this.trianglesChecked.Location = new System.Drawing.Point(53, 222);
            this.trianglesChecked.Name = "trianglesChecked";
            this.trianglesChecked.Size = new System.Drawing.Size(89, 21);
            this.trianglesChecked.TabIndex = 5;
            this.trianglesChecked.Text = "Triangles";
            this.trianglesChecked.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chose the figures you want deleted.";
            // 
            // additionalChoicesButton
            // 
            this.additionalChoicesButton.Location = new System.Drawing.Point(53, 287);
            this.additionalChoicesButton.Name = "additionalChoicesButton";
            this.additionalChoicesButton.Size = new System.Drawing.Size(147, 33);
            this.additionalChoicesButton.TabIndex = 8;
            this.additionalChoicesButton.Text = "Additional choices";
            this.additionalChoicesButton.UseVisualStyleBackColor = true;
            this.additionalChoicesButton.Click += new System.EventHandler(this.additionalChoicesButton_Click);
            // 
            // deleteAllFiguresbutton
            // 
            this.deleteAllFiguresbutton.Location = new System.Drawing.Point(220, 338);
            this.deleteAllFiguresbutton.Name = "deleteAllFiguresbutton";
            this.deleteAllFiguresbutton.Size = new System.Drawing.Size(128, 34);
            this.deleteAllFiguresbutton.TabIndex = 9;
            this.deleteAllFiguresbutton.Text = "Delete all figures";
            this.deleteAllFiguresbutton.UseVisualStyleBackColor = true;
            this.deleteAllFiguresbutton.Click += new System.EventHandler(this.deleteAllFiguresbutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete last figure";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteFiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 516);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteAllFiguresbutton);
            this.Controls.Add(this.additionalChoicesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trianglesChecked);
            this.Controls.Add(this.squaresChecked);
            this.Controls.Add(this.rectanglesChecked);
            this.Controls.Add(this.circlesChecked);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteFiguresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Figures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox rectanglesChecked;
        public System.Windows.Forms.CheckBox squaresChecked;
        public System.Windows.Forms.CheckBox trianglesChecked;
        private System.Windows.Forms.CheckBox circlesChecked;
        private System.Windows.Forms.Button additionalChoicesButton;
        private System.Windows.Forms.Button deleteAllFiguresbutton;
        private System.Windows.Forms.Button button3;
    }
}