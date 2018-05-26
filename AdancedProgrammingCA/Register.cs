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
    public partial class Register : FormMenu
    {

        public Register()
        {
            InitializeComponent();          
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
