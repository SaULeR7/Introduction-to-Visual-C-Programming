namespace ProgramAssignment3
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
            this.LoginPnl = new System.Windows.Forms.Panel();
            this.balanceTb = new System.Windows.Forms.TextBox();
            this.lNameTb = new System.Windows.Forms.TextBox();
            this.fNameTb = new System.Windows.Forms.TextBox();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountPnl = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPnl.SuspendLayout();
            this.AccountPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPnl
            // 
            this.LoginPnl.Controls.Add(this.balanceTb);
            this.LoginPnl.Controls.Add(this.lNameTb);
            this.LoginPnl.Controls.Add(this.fNameTb);
            this.LoginPnl.Controls.Add(this.balanceLbl);
            this.LoginPnl.Controls.Add(this.lNameLbl);
            this.LoginPnl.Controls.Add(this.fNameLbl);
            this.LoginPnl.Controls.Add(this.loginBtn);
            this.LoginPnl.Controls.Add(this.label1);
            this.LoginPnl.Location = new System.Drawing.Point(13, 13);
            this.LoginPnl.Name = "LoginPnl";
            this.LoginPnl.Size = new System.Drawing.Size(381, 425);
            this.LoginPnl.TabIndex = 0;
            // 
            // balanceTb
            // 
            this.balanceTb.Location = new System.Drawing.Point(165, 163);
            this.balanceTb.Name = "balanceTb";
            this.balanceTb.Size = new System.Drawing.Size(148, 22);
            this.balanceTb.TabIndex = 7;
            this.balanceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTb_KeyPress);
            this.balanceTb.Leave += new System.EventHandler(this.balanceTb_Leave);
            // 
            // lNameTb
            // 
            this.lNameTb.Location = new System.Drawing.Point(165, 122);
            this.lNameTb.Name = "lNameTb";
            this.lNameTb.Size = new System.Drawing.Size(148, 22);
            this.lNameTb.TabIndex = 6;
            this.lNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lNameTb_KeyPress);
            this.lNameTb.Leave += new System.EventHandler(this.lNameTb_Leave);
            // 
            // fNameTb
            // 
            this.fNameTb.Location = new System.Drawing.Point(165, 73);
            this.fNameTb.Name = "fNameTb";
            this.fNameTb.Size = new System.Drawing.Size(148, 22);
            this.fNameTb.TabIndex = 8;
            this.fNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fNameTb_KeyPress);
            this.fNameTb.Leave += new System.EventHandler(this.fNameTb_Leave);
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(39, 163);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(57, 16);
            this.balanceLbl.TabIndex = 4;
            this.balanceLbl.Text = "Balance";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Location = new System.Drawing.Point(39, 119);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(72, 16);
            this.lNameLbl.TabIndex = 3;
            this.lNameLbl.Text = "Last Name";
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(36, 76);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(72, 16);
            this.fNameLbl.TabIndex = 2;
            this.fNameLbl.Text = "First Name";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(128, 275);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(110, 58);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "LogIn";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ivan\'s Bank";
            // 
            // AccountPnl
            // 
            this.AccountPnl.Controls.Add(this.label7);
            this.AccountPnl.Controls.Add(this.label6);
            this.AccountPnl.Controls.Add(this.label5);
            this.AccountPnl.Controls.Add(this.textBox2);
            this.AccountPnl.Controls.Add(this.textBox1);
            this.AccountPnl.Controls.Add(this.button1);
            this.AccountPnl.Controls.Add(this.comboBox1);
            this.AccountPnl.Controls.Add(this.label4);
            this.AccountPnl.Controls.Add(this.label3);
            this.AccountPnl.Controls.Add(this.label2);
            this.AccountPnl.Location = new System.Drawing.Point(12, 12);
            this.AccountPnl.Name = "AccountPnl";
            this.AccountPnl.Size = new System.Drawing.Size(382, 426);
            this.AccountPnl.TabIndex = 0;
            this.AccountPnl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(11, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(357, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.comboBox1.Location = new System.Drawing.Point(11, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Tag = "";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.LoginPnl);
            this.Controls.Add(this.AccountPnl);
            this.MaximumSize = new System.Drawing.Size(424, 497);
            this.MinimumSize = new System.Drawing.Size(424, 497);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginPnl.ResumeLayout(false);
            this.LoginPnl.PerformLayout();
            this.AccountPnl.ResumeLayout(false);
            this.AccountPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPnl;
        private System.Windows.Forms.Panel AccountPnl;
        private System.Windows.Forms.TextBox balanceTb;
        private System.Windows.Forms.TextBox lNameTb;
        private System.Windows.Forms.TextBox fNameTb;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

