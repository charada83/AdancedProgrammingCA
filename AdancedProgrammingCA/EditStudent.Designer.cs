namespace AdancedProgrammingCA
{
    partial class EditStudent
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
            this.grpCourseDetails = new System.Windows.Forms.GroupBox();
            this.rdoPostgrad = new System.Windows.Forms.RadioButton();
            this.rdoUndergrad = new System.Windows.Forms.RadioButton();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboEditCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.cboEditCounty = new System.Windows.Forms.ComboBox();
            this.txtEditCity = new System.Windows.Forms.TextBox();
            this.txtEditAddress2 = new System.Windows.Forms.TextBox();
            this.txtEditAddress1 = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditSname = new System.Windows.Forms.TextBox();
            this.txtEditFname = new System.Windows.Forms.TextBox();
            this.lblAddCounty = new System.Windows.Forms.Label();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.lblAddAddress2 = new System.Windows.Forms.Label();
            this.lblAddAddress1 = new System.Windows.Forms.Label();
            this.lblAddPhone = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddSname = new System.Windows.Forms.Label();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValidFname = new System.Windows.Forms.Label();
            this.lblAddFname = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.grpCourseDetails.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourseDetails
            // 
            this.grpCourseDetails.Controls.Add(this.rdoPostgrad);
            this.grpCourseDetails.Controls.Add(this.rdoUndergrad);
            this.grpCourseDetails.Controls.Add(this.lblLevel);
            this.grpCourseDetails.Controls.Add(this.cboEditCourse);
            this.grpCourseDetails.Controls.Add(this.lblCourse);
            this.grpCourseDetails.Location = new System.Drawing.Point(672, 104);
            this.grpCourseDetails.Name = "grpCourseDetails";
            this.grpCourseDetails.Size = new System.Drawing.Size(321, 255);
            this.grpCourseDetails.TabIndex = 57;
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
            // cboEditCourse
            // 
            this.cboEditCourse.FormattingEnabled = true;
            this.cboEditCourse.Location = new System.Drawing.Point(123, 70);
            this.cboEditCourse.Name = "cboEditCourse";
            this.cboEditCourse.Size = new System.Drawing.Size(192, 28);
            this.cboEditCourse.TabIndex = 1;
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
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(617, 536);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(133, 54);
            this.btnEditCancel.TabIndex = 54;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(238, 536);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(133, 54);
            this.btnEditStudent.TabIndex = 53;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click_1);
            // 
            // cboEditCounty
            // 
            this.cboEditCounty.FormattingEnabled = true;
            this.cboEditCounty.Location = new System.Drawing.Point(134, 351);
            this.cboEditCounty.Name = "cboEditCounty";
            this.cboEditCounty.Size = new System.Drawing.Size(286, 28);
            this.cboEditCounty.TabIndex = 52;
            // 
            // txtEditCity
            // 
            this.txtEditCity.Location = new System.Drawing.Point(134, 307);
            this.txtEditCity.Name = "txtEditCity";
            this.txtEditCity.Size = new System.Drawing.Size(286, 26);
            this.txtEditCity.TabIndex = 51;
            // 
            // txtEditAddress2
            // 
            this.txtEditAddress2.Location = new System.Drawing.Point(134, 266);
            this.txtEditAddress2.Name = "txtEditAddress2";
            this.txtEditAddress2.Size = new System.Drawing.Size(286, 26);
            this.txtEditAddress2.TabIndex = 50;
            // 
            // txtEditAddress1
            // 
            this.txtEditAddress1.Location = new System.Drawing.Point(131, 220);
            this.txtEditAddress1.Name = "txtEditAddress1";
            this.txtEditAddress1.Size = new System.Drawing.Size(286, 26);
            this.txtEditAddress1.TabIndex = 49;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(131, 178);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(286, 26);
            this.txtEditPhone.TabIndex = 48;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(131, 133);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEditEmail.TabIndex = 47;
            // 
            // txtEditSname
            // 
            this.txtEditSname.Location = new System.Drawing.Point(131, 86);
            this.txtEditSname.Name = "txtEditSname";
            this.txtEditSname.Size = new System.Drawing.Size(286, 26);
            this.txtEditSname.TabIndex = 46;
            // 
            // txtEditFname
            // 
            this.txtEditFname.Location = new System.Drawing.Point(131, 36);
            this.txtEditFname.Name = "txtEditFname";
            this.txtEditFname.Size = new System.Drawing.Size(286, 26);
            this.txtEditFname.TabIndex = 45;
            // 
            // lblAddCounty
            // 
            this.lblAddCounty.AutoSize = true;
            this.lblAddCounty.Location = new System.Drawing.Point(9, 354);
            this.lblAddCounty.Name = "lblAddCounty";
            this.lblAddCounty.Size = new System.Drawing.Size(59, 20);
            this.lblAddCounty.TabIndex = 43;
            this.lblAddCounty.Text = "County";
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(9, 310);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(35, 20);
            this.lblAddCity.TabIndex = 42;
            this.lblAddCity.Text = "City";
            // 
            // lblAddAddress2
            // 
            this.lblAddAddress2.AutoSize = true;
            this.lblAddAddress2.Location = new System.Drawing.Point(10, 269);
            this.lblAddAddress2.Name = "lblAddAddress2";
            this.lblAddAddress2.Size = new System.Drawing.Size(115, 20);
            this.lblAddAddress2.TabIndex = 41;
            this.lblAddAddress2.Text = "Address Line 2";
            // 
            // lblAddAddress1
            // 
            this.lblAddAddress1.AutoSize = true;
            this.lblAddAddress1.Location = new System.Drawing.Point(10, 222);
            this.lblAddAddress1.Name = "lblAddAddress1";
            this.lblAddAddress1.Size = new System.Drawing.Size(115, 20);
            this.lblAddAddress1.TabIndex = 40;
            this.lblAddAddress1.Text = "Address Line 1";
            // 
            // lblAddPhone
            // 
            this.lblAddPhone.AutoSize = true;
            this.lblAddPhone.Location = new System.Drawing.Point(13, 178);
            this.lblAddPhone.Name = "lblAddPhone";
            this.lblAddPhone.Size = new System.Drawing.Size(55, 20);
            this.lblAddPhone.TabIndex = 39;
            this.lblAddPhone.Text = "Phone";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(10, 136);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAddEmail.TabIndex = 38;
            this.lblAddEmail.Text = "Email";
            // 
            // lblAddSname
            // 
            this.lblAddSname.AutoSize = true;
            this.lblAddSname.Location = new System.Drawing.Point(9, 89);
            this.lblAddSname.Name = "lblAddSname";
            this.lblAddSname.Size = new System.Drawing.Size(74, 20);
            this.lblAddSname.TabIndex = 37;
            this.lblAddSname.Text = "Surname";
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.label3);
            this.grpStudentDetails.Controls.Add(this.label2);
            this.grpStudentDetails.Controls.Add(this.label1);
            this.grpStudentDetails.Controls.Add(this.lblValidFname);
            this.grpStudentDetails.Controls.Add(this.lblAddFname);
            this.grpStudentDetails.Controls.Add(this.lblAddCounty);
            this.grpStudentDetails.Controls.Add(this.cboEditCounty);
            this.grpStudentDetails.Controls.Add(this.lblAddCity);
            this.grpStudentDetails.Controls.Add(this.txtEditCity);
            this.grpStudentDetails.Controls.Add(this.lblAddAddress2);
            this.grpStudentDetails.Controls.Add(this.txtEditAddress2);
            this.grpStudentDetails.Controls.Add(this.lblAddAddress1);
            this.grpStudentDetails.Controls.Add(this.txtEditAddress1);
            this.grpStudentDetails.Controls.Add(this.txtEditPhone);
            this.grpStudentDetails.Controls.Add(this.txtEditEmail);
            this.grpStudentDetails.Controls.Add(this.lblAddSname);
            this.grpStudentDetails.Controls.Add(this.lblAddEmail);
            this.grpStudentDetails.Controls.Add(this.lblAddPhone);
            this.grpStudentDetails.Controls.Add(this.txtEditFname);
            this.grpStudentDetails.Controls.Add(this.txtEditSname);
            this.grpStudentDetails.Location = new System.Drawing.Point(32, 104);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(531, 399);
            this.grpStudentDetails.TabIndex = 56;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Personal Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(438, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "*Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(438, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "*Required";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(438, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "*Required";
            // 
            // lblValidFname
            // 
            this.lblValidFname.AutoSize = true;
            this.lblValidFname.ForeColor = System.Drawing.Color.Red;
            this.lblValidFname.Location = new System.Drawing.Point(438, 136);
            this.lblValidFname.Name = "lblValidFname";
            this.lblValidFname.Size = new System.Drawing.Size(80, 20);
            this.lblValidFname.TabIndex = 66;
            this.lblValidFname.Text = "*Required";
            // 
            // lblAddFname
            // 
            this.lblAddFname.AutoSize = true;
            this.lblAddFname.Location = new System.Drawing.Point(9, 39);
            this.lblAddFname.Name = "lblAddFname";
            this.lblAddFname.Size = new System.Drawing.Size(86, 20);
            this.lblAddFname.TabIndex = 1;
            this.lblAddFname.Text = "First Name";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(430, 536);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(133, 54);
            this.btnDeleteStudent.TabIndex = 58;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 629);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.grpCourseDetails);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.grpStudentDetails);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.Controls.SetChildIndex(this.grpStudentDetails, 0);
            this.Controls.SetChildIndex(this.btnEditStudent, 0);
            this.Controls.SetChildIndex(this.btnEditCancel, 0);
            this.Controls.SetChildIndex(this.grpCourseDetails, 0);
            this.Controls.SetChildIndex(this.btnDeleteStudent, 0);
            this.grpCourseDetails.ResumeLayout(false);
            this.grpCourseDetails.PerformLayout();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCourseDetails;
        private System.Windows.Forms.RadioButton rdoPostgrad;
        private System.Windows.Forms.RadioButton rdoUndergrad;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboEditCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.ComboBox cboEditCounty;
        private System.Windows.Forms.TextBox txtEditCity;
        private System.Windows.Forms.TextBox txtEditAddress2;
        private System.Windows.Forms.TextBox txtEditAddress1;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditSname;
        private System.Windows.Forms.TextBox txtEditFname;
        private System.Windows.Forms.Label lblAddCounty;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Label lblAddAddress2;
        private System.Windows.Forms.Label lblAddAddress1;
        private System.Windows.Forms.Label lblAddPhone;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddSname;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblAddFname;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValidFname;
    }
}