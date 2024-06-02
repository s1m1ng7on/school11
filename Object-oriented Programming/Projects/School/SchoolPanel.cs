using School;

namespace School
{
    public partial class SchoolPanel : Form
    {
        private readonly FormHelper formHelper;

        public SchoolPanel()
        {
            InitializeComponent();
            formHelper = new FormHelper(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formHelper.AreAllTextBoxesFilled())
            {
                Program.School.AddStudent(
                    classTextBox.Text,
                    int.Parse(numberTextBox.Text),
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    [
                        double.Parse(belGradeTextBox.Text),
                        double.Parse(foreignLanguageGradeTextBox.Text),
                        double.Parse(mathGradeTextBox.Text),
                        double.Parse(physicsGradeTextBox.Text),
                        double.Parse(chemistryGradeTextBox.Text),
                        double.Parse(biologyGradeTextBox.Text)
                    ]
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formHelper.ClearAllTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchStudent().Show();
        }
    }
}
