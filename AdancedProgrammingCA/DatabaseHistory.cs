using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdancedProgrammingCA
{
    public partial class DatabaseHistory : FormMenu
    {
        ShowData sd = new ShowData();

        public DatabaseHistory()
        {
            InitializeComponent();
        }

        public void RefreshGrid()
        {

            dgvDatabaseHistory.DataSource = sd.ShowDatabaseHistory();

        }

        private void DatabaseHistory_Load(object sender, EventArgs e)
        {
            Program.GRID = dgvDatabaseHistory;
            Program.SHOW_DATABASE_HISTORY = this;
            this.RefreshGrid();
        }
    }
}
