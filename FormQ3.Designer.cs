namespace lab5work
{
    partial class FormQ3
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
            this.BTNext3 = new System.Windows.Forms.Button();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBoxQ3 = new System.Windows.Forms.GroupBox();
            this.RBNA = new System.Windows.Forms.RadioButton();
            this.RBAlways = new System.Windows.Forms.RadioButton();
            this.RBMostTime = new System.Windows.Forms.RadioButton();
            this.RBSomeTime = new System.Windows.Forms.RadioButton();
            this.RBNever = new System.Windows.Forms.RadioButton();
            this.LBQ3 = new System.Windows.Forms.Label();
            this.groupBoxQ3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNext3
            // 
            this.BTNext3.Location = new System.Drawing.Point(201, 187);
            this.BTNext3.Name = "BTNext3";
            this.BTNext3.Size = new System.Drawing.Size(79, 29);
            this.BTNext3.TabIndex = 14;
            this.BTNext3.Text = "Next";
            this.BTNext3.UseVisualStyleBackColor = true;
            this.BTNext3.Click += new System.EventHandler(this.BTNext3_Click);
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.Location = new System.Drawing.Point(179, 75);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(79, 13);
            this.labelQ3.TabIndex = 13;
            this.labelQ3.Text = "Question 3 of 3";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(182, 104);
            this.progressBar3.Maximum = 3;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(114, 22);
            this.progressBar3.TabIndex = 12;
            this.progressBar3.Value = 3;
            // 
            // groupBoxQ3
            // 
            this.groupBoxQ3.Controls.Add(this.RBNA);
            this.groupBoxQ3.Controls.Add(this.RBAlways);
            this.groupBoxQ3.Controls.Add(this.RBMostTime);
            this.groupBoxQ3.Controls.Add(this.RBSomeTime);
            this.groupBoxQ3.Controls.Add(this.RBNever);
            this.groupBoxQ3.Location = new System.Drawing.Point(21, 65);
            this.groupBoxQ3.Name = "groupBoxQ3";
            this.groupBoxQ3.Size = new System.Drawing.Size(123, 175);
            this.groupBoxQ3.TabIndex = 11;
            this.groupBoxQ3.TabStop = false;
            this.groupBoxQ3.Text = "Answer";
            // 
            // RBNA
            // 
            this.RBNA.AutoSize = true;
            this.RBNA.Location = new System.Drawing.Point(7, 122);
            this.RBNA.Name = "RBNA";
            this.RBNA.Size = new System.Drawing.Size(94, 17);
            this.RBNA.TabIndex = 4;
            this.RBNA.TabStop = true;
            this.RBNA.Text = "Not Applicable";
            this.RBNA.UseVisualStyleBackColor = true;
            // 
            // RBAlways
            // 
            this.RBAlways.AutoSize = true;
            this.RBAlways.Location = new System.Drawing.Point(7, 99);
            this.RBAlways.Name = "RBAlways";
            this.RBAlways.Size = new System.Drawing.Size(58, 17);
            this.RBAlways.TabIndex = 3;
            this.RBAlways.TabStop = true;
            this.RBAlways.Text = "Always";
            this.RBAlways.UseVisualStyleBackColor = true;
            // 
            // RBMostTime
            // 
            this.RBMostTime.AutoSize = true;
            this.RBMostTime.Location = new System.Drawing.Point(7, 76);
            this.RBMostTime.Name = "RBMostTime";
            this.RBMostTime.Size = new System.Drawing.Size(100, 17);
            this.RBMostTime.TabIndex = 2;
            this.RBMostTime.TabStop = true;
            this.RBMostTime.Text = "Most of the time";
            this.RBMostTime.UseVisualStyleBackColor = true;
            // 
            // RBSomeTime
            // 
            this.RBSomeTime.AutoSize = true;
            this.RBSomeTime.Location = new System.Drawing.Point(7, 53);
            this.RBSomeTime.Name = "RBSomeTime";
            this.RBSomeTime.Size = new System.Drawing.Size(104, 17);
            this.RBSomeTime.TabIndex = 1;
            this.RBSomeTime.TabStop = true;
            this.RBSomeTime.Text = "Some of the time";
            this.RBSomeTime.UseVisualStyleBackColor = true;
            // 
            // RBNever
            // 
            this.RBNever.AutoSize = true;
            this.RBNever.Location = new System.Drawing.Point(7, 30);
            this.RBNever.Name = "RBNever";
            this.RBNever.Size = new System.Drawing.Size(54, 17);
            this.RBNever.TabIndex = 0;
            this.RBNever.TabStop = true;
            this.RBNever.Text = "Never";
            this.RBNever.UseVisualStyleBackColor = true;
            // 
            // LBQ3
            // 
            this.LBQ3.AutoSize = true;
            this.LBQ3.Location = new System.Drawing.Point(18, 28);
            this.LBQ3.Name = "LBQ3";
            this.LBQ3.Size = new System.Drawing.Size(297, 13);
            this.LBQ3.TabIndex = 10;
            this.LBQ3.Text = "Professor demonstrates a thorough knowledge of this subject:";
            // 
            // FormQ3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 304);
            this.Controls.Add(this.BTNext3);
            this.Controls.Add(this.labelQ3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.groupBoxQ3);
            this.Controls.Add(this.LBQ3);
            this.Name = "FormQ3";
            this.Text = "Q3";
            this.groupBoxQ3.ResumeLayout(false);
            this.groupBoxQ3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNext3;
        private System.Windows.Forms.Label labelQ3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.GroupBox groupBoxQ3;
        private System.Windows.Forms.RadioButton RBNA;
        private System.Windows.Forms.RadioButton RBAlways;
        private System.Windows.Forms.RadioButton RBMostTime;
        private System.Windows.Forms.RadioButton RBSomeTime;
        private System.Windows.Forms.RadioButton RBNever;
        private System.Windows.Forms.Label LBQ3;
    }
}