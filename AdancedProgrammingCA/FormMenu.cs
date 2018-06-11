using BAL;
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
    public partial class FormMenu : Form
    {
        ShowData sd = new ShowData();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void addStudentMenuItem_Click(object sender, EventArgs e)
        {
            bool formOpen = false;

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Form current = Application.OpenForms[i];
                if (current.Name == "AddStudent")
                {
                    current.BringToFront();
                    formOpen = true;
                }
            }
            if (!formOpen)
            {
                AddStudent form = new AddStudent();
                form.Name = "AddStudent";
                form.Show();
            }
        }
            

        private void editStudentMenuItem_Click(object sender, EventArgs e)
        {
            // AddStudent.MY_PROPERTY = 12;
            int studentId = Program.SHOW_STUDENTS.GetCurrentStudentId();
            Dictionary<String, String> student = sd.GetStudentDataById(studentId);
            EditStudent editStu = new EditStudent(student);
            editStu.ShowDialog();
        }

        private void deleteStudentMenuItem_Click(object sender, EventArgs e)
        {
            //EditStudent deleteStu = new EditStudent();
            //deleteStu.ShowDialog();
        }

        private void databaseHistoryMenuItem_Click(object sender, EventArgs e)
        {
            //DatabaseHistory history = new DatabaseHistory();
            //history.ShowDialog();
        }

        private void exitLoginMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
