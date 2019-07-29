using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSON11B
{
    public static class Program
    {
        public static MainForm mainForm;
        public static StartForm startForm;
        public static AboutBox aboutBox;
        public static Student student;
        public static StudentInfoForm studentInfoForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            mainForm = new MainForm();
            aboutBox = new AboutBox();
            student = new Student();
            studentInfoForm = new StudentInfoForm();
            Application.Run(startForm);
        }
    }
}
