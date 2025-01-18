namespace Final
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHomework = new System.Windows.Forms.TextBox();
            this.tbProjects = new System.Windows.Forms.TextBox();
            this.tbExams = new System.Windows.Forms.TextBox();
            this.tbParticipation = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClear,
            this.toolStripClose});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenu.Text = "Menu";
            // 
            // toolStripClear
            // 
            this.toolStripClear.Name = "toolStripClear";
            this.toolStripClear.Size = new System.Drawing.Size(224, 26);
            this.toolStripClear.Text = "Clear";
            this.toolStripClear.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripClose
            // 
            this.toolStripClose.Name = "toolStripClose";
            this.toolStripClose.Size = new System.Drawing.Size(224, 26);
            this.toolStripClose.Text = "Close";
            this.toolStripClose.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tbHomework
            // 
            this.tbHomework.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbHomework.Location = new System.Drawing.Point(57, 100);
            this.tbHomework.Name = "tbHomework";
            this.tbHomework.Size = new System.Drawing.Size(173, 22);
            this.tbHomework.TabIndex = 1;
            this.tbHomework.Text = "Homework";
            this.tbHomework.Enter += new System.EventHandler(this.tbHomework_Enter);
            this.tbHomework.Leave += new System.EventHandler(this.tbHomework_Leave);
            // 
            // tbProjects
            // 
            this.tbProjects.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbProjects.Location = new System.Drawing.Point(57, 138);
            this.tbProjects.Name = "tbProjects";
            this.tbProjects.Size = new System.Drawing.Size(173, 22);
            this.tbProjects.TabIndex = 2;
            this.tbProjects.Text = "Program Projects";
            this.tbProjects.Enter += new System.EventHandler(this.tbProjects_Enter);
            this.tbProjects.Leave += new System.EventHandler(this.tbProjects_Leave);
            // 
            // tbExams
            // 
            this.tbExams.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbExams.Location = new System.Drawing.Point(57, 183);
            this.tbExams.Name = "tbExams";
            this.tbExams.Size = new System.Drawing.Size(173, 22);
            this.tbExams.TabIndex = 3;
            this.tbExams.Text = "Exams";
            this.tbExams.Enter += new System.EventHandler(this.tbExams_Enter);
            this.tbExams.Leave += new System.EventHandler(this.tbExams_Leave);
            // 
            // tbParticipation
            // 
            this.tbParticipation.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbParticipation.Location = new System.Drawing.Point(57, 230);
            this.tbParticipation.Name = "tbParticipation";
            this.tbParticipation.Size = new System.Drawing.Size(173, 22);
            this.tbParticipation.TabIndex = 4;
            this.tbParticipation.Text = "Class Participation";
            this.tbParticipation.Enter += new System.EventHandler(this.tbParticipation_Enter);
            this.tbParticipation.Leave += new System.EventHandler(this.tbParticipation_Leave);
            // 
            // tbFinal
            // 
            this.tbFinal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbFinal.Location = new System.Drawing.Point(57, 283);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(173, 22);
            this.tbFinal.TabIndex = 5;
            this.tbFinal.Text = "Final Exam";
            this.tbFinal.Enter += new System.EventHandler(this.tbFinal_Enter);
            this.tbFinal.Leave += new System.EventHandler(this.tbFinal_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(57, 338);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(173, 45);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(54, 428);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(44, 16);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 499);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.tbParticipation);
            this.Controls.Add(this.tbExams);
            this.Controls.Add(this.tbProjects);
            this.Controls.Add(this.tbHomework);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Total Grade";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripClose;
        private System.Windows.Forms.TextBox tbHomework;
        private System.Windows.Forms.TextBox tbProjects;
        private System.Windows.Forms.TextBox tbExams;
        private System.Windows.Forms.TextBox tbParticipation;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblGrade;
    }
}

