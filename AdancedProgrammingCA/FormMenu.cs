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
    public abstract partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void editMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            
                editMenuItem.Enabled = false;
                addStudentMenuItem.Enabled = false;
                editStudentMenuItem.Enabled = false;
                deleteStudentMenuItem.Enabled = false;
            
        }
    }
}
