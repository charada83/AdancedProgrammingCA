namespace AdancedProgrammingCA
{
    partial class DatabaseHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatabaseHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatabaseHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvDatabaseHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatabaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatabaseHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDatabaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabaseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabaseHistory.Location = new System.Drawing.Point(0, 33);
            this.dgvDatabaseHistory.Name = "dgvDatabaseHistory";
            this.dgvDatabaseHistory.RowTemplate.Height = 28;
            this.dgvDatabaseHistory.Size = new System.Drawing.Size(800, 417);
            this.dgvDatabaseHistory.TabIndex = 0;
            // 
            // DatabaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatabaseHistory);
            this.Name = "DatabaseHistory";
            this.Text = "Database History";
            this.Load += new System.EventHandler(this.DatabaseHistory_Load);
            this.Controls.SetChildIndex(this.dgvDatabaseHistory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatabaseHistory;
    }
}