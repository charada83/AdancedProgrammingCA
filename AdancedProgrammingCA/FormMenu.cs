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
using System.Xml.Serialization;

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
            int studentId = Program.SHOW_STUDENTS.GetCurrentStudentId();
            Dictionary<String, String> student = sd.GetStudentDataById(studentId);
            EditStudent editStu = new EditStudent(student);
            editStu.ShowDialog();
        }

        private void deleteStudentMenuItem_Click(object sender, EventArgs e)
        {
            int studentId = Program.SHOW_STUDENTS.GetCurrentStudentId();
            Dictionary<String, String> student = sd.GetStudentDataById(studentId);
            EditStudent editStu = new EditStudent(student);
            editStu.ShowDialog();
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

        //Serialise Student to XML
        public class Item
        {
            [XmlAttribute]
            public string id;
            [XmlAttribute]
            public string value;
        }

        private void saveStudentToXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            System.IO.Stream o = saveFileDialog.OpenFile();
            int studentId = Program.SHOW_STUDENTS.GetCurrentStudentId();
            Dictionary<String, String> student = sd.GetStudentDataById(studentId);
            
            XmlSerializer x = new XmlSerializer(typeof(Item[]), new XmlRootAttribute() { ElementName = "items" });

            x.Serialize(o, student.Select(kv => new Item() { id = kv.Key, value = kv.Value }).ToArray());
            MessageBox.Show("Saved");
            o.Close();
        }
    }
}
