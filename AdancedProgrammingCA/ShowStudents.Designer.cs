﻿namespace AdancedProgrammingCA
{
    partial class ShowStudents
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
            this.myList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // myList
            // 
            this.myList.Location = new System.Drawing.Point(111, 107);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(519, 266);
            this.myList.TabIndex = 1;
            this.myList.UseCompatibleStateImageBehavior = false;
            // 
            // ShowStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 528);
            this.Controls.Add(this.myList);
            this.Name = "ShowStudents";
            this.Text = "Show Students";
            this.Controls.SetChildIndex(this.myList, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView myList;
    }
}