using System.Text;

namespace Dictionary
{
    public partial class DictionaryForm : Form
    {
        public List<string> Words { get; set; }

        public DictionaryForm()
        {
            InitializeComponent();
            LoadDictionary();
        }

        private void performOperationButton_Click(object sender, EventArgs e)
        {
            AddWord(operationWordTextBox.Text, operationDefinitionTextBox.Text);
        }

        public void LoadDictionary()
        {
            try
            {
                using (StreamReader reader = new StreamReader("words.txt", Encoding.UTF8))
                {
                    Words = reader.ReadToEnd().Split("\r\n").ToList();
                    wordsListBox.DataSource = Words;
                }
            }
            catch
            {
                Words = new List<string>();
            }
        }

        private void wordsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedWord = wordsListBox.SelectedItem.ToString();
            string selectedWordDefinitionsFilePath = $"definitions/{selectedWord}.txt";

            using (StreamReader reader = new StreamReader(selectedWordDefinitionsFilePath, Encoding.UTF8))
            {
                wordLabel.Text = selectedWord;
                wordDefinitionsLabel.Text = reader.ReadToEnd();
            }
        }

        private void AddWord(string word, string definition)
        {
            if (!Words.Contains(word))
            {
                using (StreamWriter writer = new StreamWriter("words.txt", true, Encoding.UTF8))
                    writer.WriteLine(word);
            }
            else
            {
                string wordDefinitionsFilePath = $"definitions/{word}.txt";

                using (StreamWriter writer = new StreamWriter(wordDefinitionsFilePath, true, Encoding.UTF8))
                    writer.WriteLine(definition);

                Words.Add(word);
            }

            LoadDictionary();
        }
    }
}
