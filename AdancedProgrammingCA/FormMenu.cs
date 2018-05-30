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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void addStudentMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStu = new AddStudent();
            addStu.Show();
        }

        private void editStudentMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editStu = new EditStudent();
            editStu.Show();
        }
    }
}
