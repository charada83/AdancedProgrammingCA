using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdancedProgrammingCA
{
    static class Program
    {
        public static DataGridView GRID { get; internal set; }
        public static ShowStudents SHOW_STUDENTS { get; internal set; }
        public static DatabaseHistory SHOW_DATABASE_HISTORY { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formSMS());
        }
    }
}
