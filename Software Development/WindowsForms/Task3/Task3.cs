using System.Diagnostics;

namespace Task3
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void calculateBiorhythmsButton_Click(object sender, EventArgs e)
        {
            int conditionIndex = GetConditionIndex();
            DateTime dateOfBirth = dateOfBirthDateTimePicker.Value;

            try
            {
                double biorhythms = CalculateBiorhythms(conditionIndex, dateOfBirth);
                biorhythmsLabel.Text = $"{biorhythms} biorhytms";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private int GetConditionIndex()
        {
            switch (conditionComboBox.SelectedItem.ToString())
            {
                case "Physical":
                    return 23;
                case "Emotional":
                    return 28;
                case "Intellectual":
                    return 33;
            }

            return 0;
        }

        private double CalculateBiorhythms(int conditionIndex, DateTime dateOfBirth)
        {
            if (conditionIndex != 23 && conditionIndex != 28 && conditionIndex != 33)
                throw new ArgumentException("Invalid condition.");

            return Math.Sin(360 * (DateTime.Now - dateOfBirth).Days) * 100;
        }
    }
}
