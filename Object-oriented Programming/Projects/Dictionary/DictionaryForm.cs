using System.ComponentModel;

namespace Dictionary
{
    public partial class DictionaryForm : Form
    {
        public WordDictionary WordDictionary { get; } = new WordDictionary();

        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            wordsListBox.DataSource = WordDictionary.Words.Keys.ToList();
        }

        private void wordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, List<string>> currentWord = WordDictionary.FindWord(wordsListBox.SelectedItem.ToString());
            DisplayWord(currentWord);
        }

        private void toggleAddButton_Click(object sender, EventArgs e)
        {
            HidePanel(searchWordPanel);
            ToggleVisibility(addWordPanel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WordDictionary.Add(
                addWordTextBox.Text,
                addDefinitionTextBox.Text
            );

            wordsListBox.DataSource = WordDictionary.Words.Keys.ToList();
        }

        private void toggleSearchButton_Click(object sender, EventArgs e)
        {
            HidePanel(addWordPanel);
            ToggleVisibility(searchWordPanel);
        }

        private void searchWordButton_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, List<string>> selectedWord = WordDictionary.FindWord(searchWordTextBox.Text);
            DisplayWord(selectedWord);
        }

        private void DisplayWord(KeyValuePair<string, List<string>> word)
        {
            wordLabel.Text = word.Key;
            wordDefinitionsLabel.Text = string.Join("\n", word.Value.Select(d => $"• {d}"));
        }

        #region TO IMPROVE CODE ABSTRACTION AND SEPARATE INTO A HELPER CLASS
        private void ClearAllTextBoxes(Control _control)
        {
            foreach (Control control in _control.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void ToggleVisibility(Control control)
        {
            if (control.Visible == true)
                ClearAllTextBoxes(control);

            control.Visible = !control.Visible;
        }

        private void HidePanel(Control control)
        {
            ClearAllTextBoxes(control);
            control.Visible = false;
        }
        #endregion
    }
}
