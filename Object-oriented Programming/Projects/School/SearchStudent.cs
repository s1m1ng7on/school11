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
                try
                {
                    Student student = Program.School.GetStudent(
                    classTextBox.Text,
                    int.Parse(numberTextBox.Text)
                    );

                    result = student.ToLongReport();
                }
                catch (Exception exception)
                {
                    result = exception.Message;
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader("students.txt", Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }

            studentInfoRichTextBox.Text = result;
        }
    }
}
