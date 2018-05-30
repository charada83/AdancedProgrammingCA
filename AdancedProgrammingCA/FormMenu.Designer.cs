namespace AdancedProgrammingCA
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitLoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseHistoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.studentMenuItem,
            this.viewMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitLoginMenuItem,
            this.registerMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileMenuItem.Text = "File";
            // 
            // exitLoginMenuItem
            // 
            this.exitLoginMenuItem.Name = "exitLoginMenuItem";
            this.exitLoginMenuItem.Size = new System.Drawing.Size(218, 30);
            this.exitLoginMenuItem.Text = "Exit Application";
            // 
            // registerMenuItem
            // 
            this.registerMenuItem.Name = "registerMenuItem";
            this.registerMenuItem.Size = new System.Drawing.Size(218, 30);
            this.registerMenuItem.Text = " ";
            // 
            // studentMenuItem
            // 
            this.studentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentMenuItem,
            this.editStudentMenuItem,
            this.deleteStudentMenuItem});
            this.studentMenuItem.Name = "studentMenuItem";
            this.studentMenuItem.Size = new System.Drawing.Size(85, 29);
            this.studentMenuItem.Text = "Student";
            // 
            // addStudentMenuItem
            // 
            this.addStudentMenuItem.Name = "addStudentMenuItem";
            this.addStudentMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addStudentMenuItem.Text = "Add Student";
            this.addStudentMenuItem.Click += new System.EventHandler(this.addStudentMenuItem_Click);
            // 
            // editStudentMenuItem
            // 
            this.editStudentMenuItem.Name = "editStudentMenuItem";
            this.editStudentMenuItem.Size = new System.Drawing.Size(252, 30);
            this.editStudentMenuItem.Text = "Edit Student";
            this.editStudentMenuItem.Click += new System.EventHandler(this.editStudentMenuItem_Click);
            // 
            // deleteStudentMenuItem
            // 
            this.deleteStudentMenuItem.Name = "deleteStudentMenuItem";
            this.deleteStudentMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deleteStudentMenuItem.Text = "Delete Student";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseHistoryMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewMenuItem.Text = "View";
            // 
            // databaseHistoryMenuItem
            // 
            this.databaseHistoryMenuItem.Name = "databaseHistoryMenuItem";
            this.databaseHistoryMenuItem.Size = new System.Drawing.Size(232, 30);
            this.databaseHistoryMenuItem.Text = "Database History";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 29);
            this.toolStripButton1.Text = "Add Student";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(112, 29);
            this.toolStripButton2.Text = "Edit Student";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(132, 29);
            this.toolStripButton3.Text = "Delete Student";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 487);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitLoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseHistoryMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}