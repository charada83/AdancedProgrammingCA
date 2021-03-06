﻿namespace AdancedProgrammingCA
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            this.lblAddFname = new System.Windows.Forms.Label();
            this.lblAddSname = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddPhone = new System.Windows.Forms.Label();
            this.lblAddAddress1 = new System.Windows.Forms.Label();
            this.lblAddAddress2 = new System.Windows.Forms.Label();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.lblAddCounty = new System.Windows.Forms.Label();
            this.txtAddFname = new System.Windows.Forms.TextBox();
            this.txtAddSname = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.txtAddAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.cboAddCounty = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.grpCourseDetails = new System.Windows.Forms.GroupBox();
            this.rdoPostgrad = new System.Windows.Forms.RadioButton();
            this.rdoUndergrad = new System.Windows.Forms.RadioButton();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboAddCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblValidFname = new System.Windows.Forms.Label();
            this.lblValidSname = new System.Windows.Forms.Label();
            this.lblValidEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpStudentDetails.SuspendLayout();
            this.grpCourseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddFname
            // 
            this.lblAddFname.AutoSize = true;
            this.lblAddFname.Location = new System.Drawing.Point(39, 29);
            this.lblAddFname.Name = "lblAddFname";
            this.lblAddFname.Size = new System.Drawing.Size(86, 20);
            this.lblAddFname.TabIndex = 1;
            this.lblAddFname.Text = "First Name";
            // 
            // lblAddSname
            // 
            this.lblAddSname.AutoSize = true;
            this.lblAddSname.Location = new System.Drawing.Point(52, 106);
            this.lblAddSname.Name = "lblAddSname";
            this.lblAddSname.Size = new System.Drawing.Size(74, 20);
            this.lblAddSname.TabIndex = 2;
            this.lblAddSname.Text = "Surname";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(53, 142);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAddEmail.TabIndex = 3;
            this.lblAddEmail.Text = "Email";
            // 
            // lblAddPhone
            // 
            this.lblAddPhone.AutoSize = true;
            this.lblAddPhone.Location = new System.Drawing.Point(53, 182);
            this.lblAddPhone.Name = "lblAddPhone";
            this.lblAddPhone.Size = new System.Drawing.Size(55, 20);
            this.lblAddPhone.TabIndex = 4;
            this.lblAddPhone.Text = "Phone";
            // 
            // lblAddAddress1
            // 
            this.lblAddAddress1.AutoSize = true;
            this.lblAddAddress1.Location = new System.Drawing.Point(52, 224);
            this.lblAddAddress1.Name = "lblAddAddress1";
            this.lblAddAddress1.Size = new System.Drawing.Size(115, 20);
            this.lblAddAddress1.TabIndex = 5;
            this.lblAddAddress1.Text = "Address Line 1";
            // 
            // lblAddAddress2
            // 
            this.lblAddAddress2.AutoSize = true;
            this.lblAddAddress2.Location = new System.Drawing.Point(52, 271);
            this.lblAddAddress2.Name = "lblAddAddress2";
            this.lblAddAddress2.Size = new System.Drawing.Size(115, 20);
            this.lblAddAddress2.TabIndex = 6;
            this.lblAddAddress2.Text = "Address Line 2";
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(52, 313);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(35, 20);
            this.lblAddCity.TabIndex = 7;
            this.lblAddCity.Text = "City";
            // 
            // lblAddCounty
            // 
            this.lblAddCounty.AutoSize = true;
            this.lblAddCounty.Location = new System.Drawing.Point(53, 350);
            this.lblAddCounty.Name = "lblAddCounty";
            this.lblAddCounty.Size = new System.Drawing.Size(59, 20);
            this.lblAddCounty.TabIndex = 8;
            this.lblAddCounty.Text = "County";
            // 
            // txtAddFname
            // 
            this.txtAddFname.Location = new System.Drawing.Point(178, 65);
            this.txtAddFname.Name = "txtAddFname";
            this.txtAddFname.Size = new System.Drawing.Size(286, 26);
            this.txtAddFname.TabIndex = 12;
            this.txtAddFname.TextChanged += new System.EventHandler(this.txtAddFname_TextChanged);
            // 
            // txtAddSname
            // 
            this.txtAddSname.Location = new System.Drawing.Point(178, 103);
            this.txtAddSname.Name = "txtAddSname";
            this.txtAddSname.Size = new System.Drawing.Size(286, 26);
            this.txtAddSname.TabIndex = 13;
            this.txtAddSname.TextChanged += new System.EventHandler(this.txtAddSname_TextChanged);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(178, 139);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(286, 26);
            this.txtAddEmail.TabIndex = 14;
            this.txtAddEmail.TextChanged += new System.EventHandler(this.txtAddEmail_TextChanged);
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(178, 179);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(286, 26);
            this.txtAddPhone.TabIndex = 15;
            // 
            // txtAddAddress1
            // 
            this.txtAddAddress1.Location = new System.Drawing.Point(178, 221);
            this.txtAddAddress1.Name = "txtAddAddress1";
            this.txtAddAddress1.Size = new System.Drawing.Size(286, 26);
            this.txtAddAddress1.TabIndex = 16;
            // 
            // txtAddAddress2
            // 
            this.txtAddAddress2.Location = new System.Drawing.Point(178, 268);
            this.txtAddAddress2.Name = "txtAddAddress2";
            this.txtAddAddress2.Size = new System.Drawing.Size(286, 26);
            this.txtAddAddress2.TabIndex = 17;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Location = new System.Drawing.Point(178, 310);
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(286, 26);
            this.txtAddCity.TabIndex = 18;
            // 
            // cboAddCounty
            // 
            this.cboAddCounty.FormattingEnabled = true;
            this.cboAddCounty.Location = new System.Drawing.Point(178, 347);
            this.cboAddCounty.Name = "cboAddCounty";
            this.cboAddCounty.Size = new System.Drawing.Size(286, 28);
            this.cboAddCounty.TabIndex = 19;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(314, 483);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(133, 54);
            this.btnAddStudent.TabIndex = 23;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(553, 483);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(133, 54);
            this.btnAddCancel.TabIndex = 24;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.lblAddFname);
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 47);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(464, 399);
            this.grpStudentDetails.TabIndex = 27;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Personal Details";
            // 
            // grpCourseDetails
            // 
            this.grpCourseDetails.Controls.Add(this.rdoPostgrad);
            this.grpCourseDetails.Controls.Add(this.rdoUndergrad);
            this.grpCourseDetails.Controls.Add(this.lblLevel);
            this.grpCourseDetails.Controls.Add(this.cboAddCourse);
            this.grpCourseDetails.Controls.Add(this.lblCourse);
            this.grpCourseDetails.Location = new System.Drawing.Point(672, 47);
            this.grpCourseDetails.Name = "grpCourseDetails";
            this.grpCourseDetails.Size = new System.Drawing.Size(321, 255);
            this.grpCourseDetails.TabIndex = 28;
            this.grpCourseDetails.TabStop = false;
            this.grpCourseDetails.Text = "Course Details";
            // 
            // rdoPostgrad
            // 
            this.rdoPostgrad.AutoSize = true;
            this.rdoPostgrad.Location = new System.Drawing.Point(123, 206);
            this.rdoPostgrad.Name = "rdoPostgrad";
            this.rdoPostgrad.Size = new System.Drawing.Size(130, 24);
            this.rdoPostgrad.TabIndex = 4;
            this.rdoPostgrad.TabStop = true;
            this.rdoPostgrad.Text = "Postgraduate";
            this.rdoPostgrad.UseVisualStyleBackColor = true;
            // 
            // rdoUndergrad
            // 
            this.rdoUndergrad.AutoSize = true;
            this.rdoUndergrad.Location = new System.Drawing.Point(123, 162);
            this.rdoUndergrad.Name = "rdoUndergrad";
            this.rdoUndergrad.Size = new System.Drawing.Size(142, 24);
            this.rdoUndergrad.TabIndex = 3;
            this.rdoUndergrad.TabStop = true;
            this.rdoUndergrad.Text = "Undergraduate";
            this.rdoUndergrad.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(30, 167);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Level";
            // 
            // cboAddCourse
            // 
            this.cboAddCourse.FormattingEnabled = true;
            this.cboAddCourse.Location = new System.Drawing.Point(123, 70);
            this.cboAddCourse.Name = "cboAddCourse";
            this.cboAddCourse.Size = new System.Drawing.Size(192, 28);
            this.cboAddCourse.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(26, 69);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(60, 20);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course";
            // 
            // lblValidFname
            // 
            this.lblValidFname.AutoSize = true;
            this.lblValidFname.ForeColor = System.Drawing.Color.Red;
            this.lblValidFname.Location = new System.Drawing.Point(483, 68);
            this.lblValidFname.Name = "lblValidFname";
            this.lblValidFname.Size = new System.Drawing.Size(80, 20);
            this.lblValidFname.TabIndex = 29;
            this.lblValidFname.Text = "*Required";
            // 
            // lblValidSname
            // 
            this.lblValidSname.AutoSize = true;
            this.lblValidSname.ForeColor = System.Drawing.Color.Red;
            this.lblValidSname.Location = new System.Drawing.Point(482, 106);
            this.lblValidSname.Name = "lblValidSname";
            this.lblValidSname.Size = new System.Drawing.Size(80, 20);
            this.lblValidSname.TabIndex = 30;
            this.lblValidSname.Text = "*Required";
            // 
            // lblValidEmail
            // 
            this.lblValidEmail.AutoSize = true;
            this.lblValidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblValidEmail.Location = new System.Drawing.Point(482, 142);
            this.lblValidEmail.Name = "lblValidEmail";
            this.lblValidEmail.Size = new System.Drawing.Size(80, 20);
            this.lblValidEmail.TabIndex = 31;
            this.lblValidEmail.Text = "*Required";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(483, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "*Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(483, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "*Required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(483, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "*Required";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 629);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValidEmail);
            this.Controls.Add(this.lblValidSname);
            this.Controls.Add(this.lblValidFname);
            this.Controls.Add(this.grpCourseDetails);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cboAddCounty);
            this.Controls.Add(this.txtAddCity);
            this.Controls.Add(this.txtAddAddress2);
            this.Controls.Add(this.txtAddAddress1);
            this.Controls.Add(this.txtAddPhone);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.txtAddSname);
            this.Controls.Add(this.txtAddFname);
            this.Controls.Add(this.lblAddCounty);
            this.Controls.Add(this.lblAddCity);
            this.Controls.Add(this.lblAddAddress2);
            this.Controls.Add(this.lblAddAddress1);
            this.Controls.Add(this.lblAddPhone);
            this.Controls.Add(this.lblAddEmail);
            this.Controls.Add(this.lblAddSname);
            this.Controls.Add(this.grpStudentDetails);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.Controls.SetChildIndex(this.grpStudentDetails, 0);
            this.Controls.SetChildIndex(this.lblAddSname, 0);
            this.Controls.SetChildIndex(this.lblAddEmail, 0);
            this.Controls.SetChildIndex(this.lblAddPhone, 0);
            this.Controls.SetChildIndex(this.lblAddAddress1, 0);
            this.Controls.SetChildIndex(this.lblAddAddress2, 0);
            this.Controls.SetChildIndex(this.lblAddCity, 0);
            this.Controls.SetChildIndex(this.lblAddCounty, 0);
            this.Controls.SetChildIndex(this.txtAddFname, 0);
            this.Controls.SetChildIndex(this.txtAddSname, 0);
            this.Controls.SetChildIndex(this.txtAddEmail, 0);
            this.Controls.SetChildIndex(this.txtAddPhone, 0);
            this.Controls.SetChildIndex(this.txtAddAddress1, 0);
            this.Controls.SetChildIndex(this.txtAddAddress2, 0);
            this.Controls.SetChildIndex(this.txtAddCity, 0);
            this.Controls.SetChildIndex(this.cboAddCounty, 0);
            this.Controls.SetChildIndex(this.btnAddStudent, 0);
            this.Controls.SetChildIndex(this.btnAddCancel, 0);
            this.Controls.SetChildIndex(this.grpCourseDetails, 0);
            this.Controls.SetChildIndex(this.lblValidFname, 0);
            this.Controls.SetChildIndex(this.lblValidSname, 0);
            this.Controls.SetChildIndex(this.lblValidEmail, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpCourseDetails.ResumeLayout(false);
            this.grpCourseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddFname;
        private System.Windows.Forms.Label lblAddSname;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddPhone;
        private System.Windows.Forms.Label lblAddAddress1;
        private System.Windows.Forms.Label lblAddAddress2;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Label lblAddCounty;
        private System.Windows.Forms.TextBox txtAddFname;
        private System.Windows.Forms.TextBox txtAddSname;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.TextBox txtAddAddress1;
        private System.Windows.Forms.TextBox txtAddAddress2;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.ComboBox cboAddCounty;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.GroupBox grpCourseDetails;
        private System.Windows.Forms.RadioButton rdoPostgrad;
        private System.Windows.Forms.RadioButton rdoUndergrad;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboAddCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblValidFname;
        private System.Windows.Forms.Label lblValidSname;
        private System.Windows.Forms.Label lblValidEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}