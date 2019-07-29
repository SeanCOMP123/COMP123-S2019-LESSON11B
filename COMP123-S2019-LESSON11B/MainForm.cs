using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace COMP123_S2019_LESSON11B
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// THis is the event handler for the mianform's formclosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the Exit menu item's click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataBaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.testDataBaseDataSet.StudentTable);

        }

        private void StudnetTableDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // local scope aliases
            var rowIndex = StudnetTableDataGridView.CurrentCell.RowIndex;
            var rows = StudnetTableDataGridView.Rows;
            var columnCount = StudnetTableDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;

            string outputString = string.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }
            SelectionLabel.Text = outputString;

            Program.student.id = int.Parse(cells[(int)StudentField.ID].Value.ToString());
            Program.student.StudentID = cells[(int)StudentField.STUDENT_ID].Value.ToString();
            Program.student.FirstName = cells[(int)StudentField.FIRST_NAME].Value.ToString();
            Program.student.LastName = cells[(int)StudentField.LAST_NAME].Value.ToString();
    
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            StudentSaveFileDialog.FileName = "Student.txt";
            StudentSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All File (*.*)|(*.*";

            //open file dialog mod    var result = StudentSaveFileDialog.ShowDialog();
            var result = StudentSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamWriter outputString = new StreamWriter(File.Open(StudentSaveFileDialog.FileName, FileMode.Create)))
                {

                    //write stuff to the file
                    outputString.WriteLine(Program.student.id);
                    outputString.WriteLine(Program.student.StudentID);
                    outputString.WriteLine(Program.student.FirstName);
                    outputString.WriteLine(Program.student.LastName);
                    //cleanup
                    outputString.Close();
                    outputString.Dispose();
                }
                MessageBox.Show("File Saved", "Saving....");
            }
        }
    

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.studentInfoForm.Show();
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            StudentOpenFileDialog.FileName = "Student.txt";
            StudentOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentOpenFileDialog.Filter= "Text Files (*.txt)|*.txt| All File (*.*)|(*.*";
            //opne the file dialog
            var result = StudentOpenFileDialog.ShowDialog();
            if (result!= DialogResult.Cancel)
            {
                try
                {
                    //open the file dialog
                    using (StreamReader inputStream = new StreamReader(File.Open("Student.txt", FileMode.Open)))
                    {
                        //read stuff from the file into the student object
                        Program.student.id = int.Parse(inputStream.ReadLine());
                        Program.student.StudentID = inputStream.ReadLine();
                        Program.student.FirstName = inputStream.ReadLine();
                        Program.student.LastName = inputStream.ReadLine();

                        //cleanup
                        inputStream.Close();
 
                        inputStream.Dispose();
                        NextButton_Click(sender, e);
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error:" + exception.Message, "File I/O error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void saveBinaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            StudentSaveFileDialog.FileName = "Student.dat";
            StudentSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentSaveFileDialog.Filter = "Binary Files (*.dat)|*.dat| All File (*.*)|(*.*";

            //open file dialog mod    var result = StudentSaveFileDialog.ShowDialog();
            var result = StudentSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (BinaryWriter outputString = new BinaryWriter(File.Open(StudentSaveFileDialog.FileName, FileMode.Create)))
                {

                    //write stuff to the file
                    outputString.Write(Program.student.id.ToString());
                    outputString.Write(Program.student.StudentID);
                    outputString.Write(Program.student.FirstName);
                    outputString.Write(Program.student.LastName);
                    //cleanup
                    outputString.Flush();
                    outputString.Close();
                    outputString.Dispose();
                }
                MessageBox.Show("File Saved", "Saving....", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void openBinaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            StudentOpenFileDialog.FileName = "Student.dat";
            StudentOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentOpenFileDialog.Filter = "Text Files (*.dat)|*.dat| All File (*.*)|(*.*";
            //opne the file dialog
            var result = StudentOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open the file dialog
                    using (BinaryReader inputStream = new BinaryReader(File.Open(StudentOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //read stuff from the file into the student object
                        Program.student.id = int.Parse(inputStream.ReadString());
                        Program.student.StudentID = inputStream.ReadString();
                        Program.student.FirstName = inputStream.ReadString();
                        Program.student.LastName = inputStream.ReadString();

                        //cleanup
                        inputStream.Close();

                        inputStream.Dispose();
                        NextButton_Click(sender, e);
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error:" + exception.Message, "File I/O error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
