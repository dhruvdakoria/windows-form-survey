namespace lab5work
{
    partial class FormQ1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LBQ1 = new System.Windows.Forms.Label();
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.RBPoor = new System.Windows.Forms.RadioButton();
            this.RBFair = new System.Windows.Forms.RadioButton();
            this.RBGood = new System.Windows.Forms.RadioButton();
            this.RBVGood = new System.Windows.Forms.RadioButton();
            this.RBExcellent = new System.Windows.Forms.RadioButton();
            this.RBNoOpinion = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.BTNext1 = new System.Windows.Forms.Button();
            this.groupBoxQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBQ1
            // 
            this.LBQ1.AutoSize = true;
            this.LBQ1.Location = new System.Drawing.Point(23, 27);
            this.LBQ1.Name = "LBQ1";
            this.LBQ1.Size = new System.Drawing.Size(235, 13);
            this.LBQ1.TabIndex = 0;
            this.LBQ1.Text = "Overall, I would rate the quality of this course as:";
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.Controls.Add(this.RBNoOpinion);
            this.groupBoxQ1.Controls.Add(this.RBExcellent);
            this.groupBoxQ1.Controls.Add(this.RBVGood);
            this.groupBoxQ1.Controls.Add(this.RBGood);
            this.groupBoxQ1.Controls.Add(this.RBFair);
            this.groupBoxQ1.Controls.Add(this.RBPoor);
            this.groupBoxQ1.Location = new System.Drawing.Point(26, 63);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Size = new System.Drawing.Size(123, 175);
            this.groupBoxQ1.TabIndex = 1;
            this.groupBoxQ1.TabStop = false;
            this.groupBoxQ1.Text = "Answer";
            // 
            // RBPoor
            // 
            this.RBPoor.AutoSize = true;
            this.RBPoor.Location = new System.Drawing.Point(7, 30);
            this.RBPoor.Name = "RBPoor";
            this.RBPoor.Size = new System.Drawing.Size(47, 17);
            this.RBPoor.TabIndex = 0;
            this.RBPoor.TabStop = true;
            this.RBPoor.Text = "Poor";
            this.RBPoor.UseVisualStyleBackColor = true;
            // 
            // RBFair
            // 
            this.RBFair.AutoSize = true;
            this.RBFair.Location = new System.Drawing.Point(7, 53);
            this.RBFair.Name = "RBFair";
            this.RBFair.Size = new System.Drawing.Size(42, 17);
            this.RBFair.TabIndex = 1;
            this.RBFair.TabStop = true;
            this.RBFair.Text = "Fair";
            this.RBFair.UseVisualStyleBackColor = true;
            // 
            // RBGood
            // 
            this.RBGood.AutoSize = true;
            this.RBGood.Location = new System.Drawing.Point(7, 76);
            this.RBGood.Name = "RBGood";
            this.RBGood.Size = new System.Drawing.Size(51, 17);
            this.RBGood.TabIndex = 2;
            this.RBGood.TabStop = true;
            this.RBGood.Text = "Good";
            this.RBGood.UseVisualStyleBackColor = true;
            // 
            // RBVGood
            // 
            this.RBVGood.AutoSize = true;
            this.RBVGood.Location = new System.Drawing.Point(7, 99);
            this.RBVGood.Name = "RBVGood";
            this.RBVGood.Size = new System.Drawing.Size(75, 17);
            this.RBVGood.TabIndex = 3;
            this.RBVGood.TabStop = true;
            this.RBVGood.Text = "Very Good";
            this.RBVGood.UseVisualStyleBackColor = true;
            // 
            // RBExcellent
            // 
            this.RBExcellent.AutoSize = true;
            this.RBExcellent.Location = new System.Drawing.Point(7, 122);
            this.RBExcellent.Name = "RBExcellent";
            this.RBExcellent.Size = new System.Drawing.Size(68, 17);
            this.RBExcellent.TabIndex = 4;
            this.RBExcellent.TabStop = true;
            this.RBExcellent.Text = "Excellent";
            this.RBExcellent.UseVisualStyleBackColor = true;
            // 
            // RBNoOpinion
            // 
            this.RBNoOpinion.AutoSize = true;
            this.RBNoOpinion.Location = new System.Drawing.Point(7, 145);
            this.RBNoOpinion.Name = "RBNoOpinion";
            this.RBNoOpinion.Size = new System.Drawing.Size(78, 17);
            this.RBNoOpinion.TabIndex = 5;
            this.RBNoOpinion.TabStop = true;
            this.RBNoOpinion.Text = "No Opinion";
            this.RBNoOpinion.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(187, 102);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(114, 22);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 1;
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.Location = new System.Drawing.Point(184, 73);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(79, 13);
            this.labelQ1.TabIndex = 3;
            this.labelQ1.Text = "Question 1 of 3";
            // 
            // BTNext1
            // 
            this.BTNext1.Location = new System.Drawing.Point(206, 185);
            this.BTNext1.Name = "BTNext1";
            this.BTNext1.Size = new System.Drawing.Size(79, 29);
            this.BTNext1.TabIndex = 4;
            this.BTNext1.Text = "Next";
            this.BTNext1.UseVisualStyleBackColor = true;
            this.BTNext1.Click += new System.EventHandler(this.BTNext1_Click);
            // 
            // FormQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 304);
            this.Controls.Add(this.BTNext1);
            this.Controls.Add(this.labelQ1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxQ1);
            this.Controls.Add(this.LBQ1);
            this.Name = "FormQ1";
            this.Text = "Q1";
            //this.Load += new System.EventHandler(this.FormQ1_Load);
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label LBQ1;
        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.Windows.Forms.RadioButton RBNoOpinion;
        private System.Windows.Forms.RadioButton RBExcellent;
        private System.Windows.Forms.RadioButton RBVGood;
        private System.Windows.Forms.RadioButton RBGood;
        private System.Windows.Forms.RadioButton RBFair;
        private System.Windows.Forms.RadioButton RBPoor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.Button BTNext1;
    }
}