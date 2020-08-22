namespace KursovProektWindowsForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createCircle = new System.Windows.Forms.Button();
            this.createRectangle = new System.Windows.Forms.Button();
            this.createSquare = new System.Windows.Forms.Button();
            this.randomFigure = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createTriangle = new System.Windows.Forms.Button();
            this.choseColorButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.accumulatedCirclesArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.accumulatedRectanglesArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.accumulatedSquaresArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.accumulatedTrianglesArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCircle
            // 
            this.createCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCircle.Location = new System.Drawing.Point(12, 12);
            this.createCircle.Name = "createCircle";
            this.createCircle.Size = new System.Drawing.Size(140, 32);
            this.createCircle.TabIndex = 1;
            this.createCircle.Text = "Create Circle";
            this.createCircle.UseVisualStyleBackColor = true;
            this.createCircle.Click += new System.EventHandler(this.createCircle_Click);
            // 
            // createRectangle
            // 
            this.createRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createRectangle.Location = new System.Drawing.Point(157, 12);
            this.createRectangle.Name = "createRectangle";
            this.createRectangle.Size = new System.Drawing.Size(140, 32);
            this.createRectangle.TabIndex = 2;
            this.createRectangle.Text = "Create Rectangle";
            this.createRectangle.UseVisualStyleBackColor = true;
            this.createRectangle.Click += new System.EventHandler(this.createRectangle_Click);
            // 
            // createSquare
            // 
            this.createSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSquare.Location = new System.Drawing.Point(303, 12);
            this.createSquare.Name = "createSquare";
            this.createSquare.Size = new System.Drawing.Size(140, 32);
            this.createSquare.TabIndex = 3;
            this.createSquare.Text = "Create Square";
            this.createSquare.UseVisualStyleBackColor = true;
            this.createSquare.Click += new System.EventHandler(this.createSquare_Click);
            // 
            // randomFigure
            // 
            this.randomFigure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomFigure.BackgroundImage")));
            this.randomFigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randomFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomFigure.Dock = System.Windows.Forms.DockStyle.Right;
            this.randomFigure.Location = new System.Drawing.Point(1149, 18);
            this.randomFigure.Name = "randomFigure";
            this.randomFigure.Size = new System.Drawing.Size(81, 51);
            this.randomFigure.TabIndex = 5;
            this.randomFigure.UseVisualStyleBackColor = true;
            this.randomFigure.Click += new System.EventHandler(this.randomFigure_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(779, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 32);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete Figures";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.createTriangle);
            this.groupBox1.Controls.Add(this.choseColorButton);
            this.groupBox1.Controls.Add(this.createCircle);
            this.groupBox1.Controls.Add(this.randomFigure);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.createRectangle);
            this.groupBox1.Controls.Add(this.createSquare);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // createTriangle
            // 
            this.createTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTriangle.Location = new System.Drawing.Point(449, 12);
            this.createTriangle.Name = "createTriangle";
            this.createTriangle.Size = new System.Drawing.Size(140, 32);
            this.createTriangle.TabIndex = 9;
            this.createTriangle.Text = "Create Triangle";
            this.createTriangle.UseVisualStyleBackColor = true;
            this.createTriangle.Click += new System.EventHandler(this.createTriangle_Click);
            // 
            // choseColorButton
            // 
            this.choseColorButton.Location = new System.Drawing.Point(633, 12);
            this.choseColorButton.Name = "choseColorButton";
            this.choseColorButton.Size = new System.Drawing.Size(140, 32);
            this.choseColorButton.TabIndex = 8;
            this.choseColorButton.Text = "Chose Color";
            this.choseColorButton.UseVisualStyleBackColor = true;
            this.choseColorButton.Click += new System.EventHandler(this.choseColorButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accumulatedCirclesArea,
            this.accumulatedRectanglesArea,
            this.accumulatedSquaresArea,
            this.accumulatedTrianglesArea});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1233, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // accumulatedCirclesArea
            // 
            this.accumulatedCirclesArea.Name = "accumulatedCirclesArea";
            this.accumulatedCirclesArea.Size = new System.Drawing.Size(102, 20);
            this.accumulatedCirclesArea.Text = "Circles Area: 0";
            // 
            // accumulatedRectanglesArea
            // 
            this.accumulatedRectanglesArea.Name = "accumulatedRectanglesArea";
            this.accumulatedRectanglesArea.Size = new System.Drawing.Size(131, 20);
            this.accumulatedRectanglesArea.Text = "Rectangles Area: 0";
            // 
            // accumulatedSquaresArea
            // 
            this.accumulatedSquaresArea.Name = "accumulatedSquaresArea";
            this.accumulatedSquaresArea.Size = new System.Drawing.Size(111, 20);
            this.accumulatedSquaresArea.Text = "Squares Area: 0";
            // 
            // accumulatedTrianglesArea
            // 
            this.accumulatedTrianglesArea.Name = "accumulatedTrianglesArea";
            this.accumulatedTrianglesArea.Size = new System.Drawing.Size(112, 20);
            this.accumulatedTrianglesArea.Text = "Triangle Area: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.statisticsButton);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1137, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 495);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(9, 48);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(75, 53);
            this.statisticsButton.TabIndex = 2;
            this.statisticsButton.Text = "Statistic";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click_1);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoad.Location = new System.Drawing.Point(3, 426);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(90, 33);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(3, 459);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 33);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Figure Machine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createCircle;
        private System.Windows.Forms.Button createRectangle;
        private System.Windows.Forms.Button createSquare;
        private System.Windows.Forms.Button randomFigure;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button choseColorButton;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button createTriangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStripStatusLabel accumulatedSquaresArea;
        private System.Windows.Forms.ToolStripStatusLabel accumulatedTrianglesArea;
        private System.Windows.Forms.ToolStripStatusLabel accumulatedRectanglesArea;
        public System.Windows.Forms.ToolStripStatusLabel accumulatedCirclesArea;
        private System.Windows.Forms.Button statisticsButton;
    }
}

