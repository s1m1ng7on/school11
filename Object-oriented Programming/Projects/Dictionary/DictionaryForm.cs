namespace Dictionary
{
    public partial class DictionaryForm : Form
    {
        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            wordsListBox.DataSource = Program.Dictionary.Words.Keys.ToList();
        }
    }
}
