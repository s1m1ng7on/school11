namespace School
{
    public partial class Form1 : Form
    {
        public List<Student> Students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(namesTextBox.Text, classTextBox.Text, int.Parse(numberTextBox.Text));

            newStudent.AddGrade(Subject.BulgarianLanguage, double.Parse(belGradeTextBox.Text));
            newStudent.AddGrade(Subject.ForeignLanguage, double.Parse(foreignLanguageGradeTextBox.Text));
            newStudent.AddGrade(Subject.Maths, double.Parse(mathGradeTextBox.Text));
            newStudent.AddGrade(Subject.Physics, double.Parse(physicsGradeTextBox.Text));
            newStudent.AddGrade(Subject.Chemistry, double.Parse(chemistryGradeTextBox.Text));
            newStudent.AddGrade(Subject.Biology, double.Parse(biologyGradeTextBox.Text));

            Students.Add(newStudent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = String.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchStudent().Show();
        }
    }
}
