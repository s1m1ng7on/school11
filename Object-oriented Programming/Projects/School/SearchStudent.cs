using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class SearchStudent : Form
    {
        private readonly FormHelper formHelper;

        public SearchStudent()
        {
            InitializeComponent();
            formHelper = new FormHelper(this);
        }

        private void SearchStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.Show();
        }

        private void showFileButton_Click(object sender, EventArgs e)
        {
            string result;
            
            if (formHelper.AreAllTextBoxesFilled())
            {
                Student student = Program.School.GetStudent(
                    classTextBox.Text,
                    int.Parse(numberTextBox.Text)
                );

                if (student != null)
                    result = student.ToLongReport();
                else
                    result = "Ученик в този клас или с такъв номер не беше намерен.";
            }
            else
            {
                using (StreamReader reader = new StreamReader("students.txt", Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }

                //Alternative way without reading from the text file
                //result = string.Join("\n", Program.School.Students.Select(s => s.ToShortReport()).ToArray());
            }

            studentInfoRichTextBox.Text = result;
        }
    }
}
