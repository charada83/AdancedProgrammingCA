namespace AdancedProgrammingCA
{
    partial class Register
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegForm = new System.Windows.Forms.Button();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.txtRegFirstname = new System.Windows.Forms.TextBox();
            this.txtRegSurname = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(51, 49);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(80, 20);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "Firstname";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(51, 94);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(48, 146);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnRegForm
            // 
            this.btnRegForm.Location = new System.Drawing.Point(101, 258);
            this.btnRegForm.Name = "btnRegForm";
            this.btnRegForm.Size = new System.Drawing.Size(142, 54);
            this.btnRegForm.TabIndex = 6;
            this.btnRegForm.Text = "Register";
            this.btnRegForm.UseVisualStyleBackColor = true;
            this.btnRegForm.Click += new System.EventHandler(this.btnRegForm_Click);
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Location = new System.Drawing.Point(134, 348);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(235, 20);
            this.lnkLogin.TabIndex = 7;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Already Registered? Login Here";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // txtRegFirstname
            // 
            this.txtRegFirstname.Location = new System.Drawing.Point(187, 46);
            this.txtRegFirstname.Name = "txtRegFirstname";
            this.txtRegFirstname.Size = new System.Drawing.Size(239, 26);
            this.txtRegFirstname.TabIndex = 8;
            // 
            // txtRegSurname
            // 
            this.txtRegSurname.Location = new System.Drawing.Point(187, 94);
            this.txtRegSurname.Name = "txtRegSurname";
            this.txtRegSurname.Size = new System.Drawing.Size(239, 26);
            this.txtRegSurname.TabIndex = 9;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(187, 143);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(239, 26);
            this.txtRegUsername.TabIndex = 10;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(187, 195);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(239, 26);
            this.txtRegPassword.TabIndex = 11;
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.Location = new System.Drawing.Point(284, 258);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(142, 54);
            this.btnCancelReg.TabIndex = 12;
            this.btnCancelReg.Text = "Cancel";
            this.btnCancelReg.UseVisualStyleBackColor = true;
            this.btnCancelReg.Click += new System.EventHandler(this.btnCancelReg_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 415);
            this.Controls.Add(this.btnCancelReg);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.txtRegSurname);
            this.Controls.Add(this.txtRegFirstname);
            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.btnRegForm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFname);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegForm;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.TextBox txtRegFirstname;
        private System.Windows.Forms.TextBox txtRegSurname;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Button btnCancelReg;
    }
}