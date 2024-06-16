namespace Dictionary
{
    partial class DictionaryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            toggleAddButton = new Button();
            toggleSearchButton = new Button();
            addWordTextBox = new TextBox();
            addDefinitionTextBox = new TextBox();
            addButton = new Button();
            addWordPanel = new Panel();
            wordsListBox = new ListBox();
            wordLabel = new Label();
            wordDefinitionsLabel = new Label();
            searchWordPanel = new Panel();
            searchWordButton = new Button();
            searchWordTextBox = new TextBox();
            addWordPanel.SuspendLayout();
            searchWordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 60);
            label1.TabIndex = 0;
            label1.Text = "DICTIONARY";
            // 
            // toggleAddButton
            // 
            toggleAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleAddButton.BackgroundImage = Properties.Resources.AddIcon;
            toggleAddButton.Location = new Point(1190, 9);
            toggleAddButton.Name = "toggleAddButton";
            toggleAddButton.Size = new Size(60, 60);
            toggleAddButton.TabIndex = 1;
            toggleAddButton.UseVisualStyleBackColor = true;
            toggleAddButton.Click += toggleAddButton_Click;
            // 
            // toggleSearchButton
            // 
            toggleSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSearchButton.BackgroundImage = Properties.Resources.SearchIcon;
            toggleSearchButton.Location = new Point(1125, 9);
            toggleSearchButton.Name = "toggleSearchButton";
            toggleSearchButton.Size = new Size(60, 60);
            toggleSearchButton.TabIndex = 2;
            toggleSearchButton.UseVisualStyleBackColor = true;
            toggleSearchButton.Click += toggleSearchButton_Click;
            // 
            // addWordTextBox
            // 
            addWordTextBox.Location = new Point(10, 13);
            addWordTextBox.Margin = new Padding(3, 4, 3, 4);
            addWordTextBox.Name = "addWordTextBox";
            addWordTextBox.Size = new Size(114, 27);
            addWordTextBox.TabIndex = 3;
            // 
            // addDefinitionTextBox
            // 
            addDefinitionTextBox.Location = new Point(131, 13);
            addDefinitionTextBox.Margin = new Padding(3, 4, 3, 4);
            addDefinitionTextBox.Name = "addDefinitionTextBox";
            addDefinitionTextBox.Size = new Size(114, 27);
            addDefinitionTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.Location = new Point(253, 12);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(123, 32);
            addButton.TabIndex = 5;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addWordPanel
            // 
            addWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addWordPanel.Controls.Add(addButton);
            addWordPanel.Controls.Add(addDefinitionTextBox);
            addWordPanel.Controls.Add(addWordTextBox);
            addWordPanel.Location = new Point(865, 76);
            addWordPanel.Margin = new Padding(3, 4, 3, 4);
            addWordPanel.Name = "addWordPanel";
            addWordPanel.Size = new Size(384, 56);
            addWordPanel.TabIndex = 6;
            addWordPanel.Visible = false;
            // 
            // wordsListBox
            // 
            wordsListBox.FormattingEnabled = true;
            wordsListBox.Location = new Point(9, 119);
            wordsListBox.Margin = new Padding(3, 4, 3, 4);
            wordsListBox.Name = "wordsListBox";
            wordsListBox.Size = new Size(348, 524);
            wordsListBox.TabIndex = 9;
            wordsListBox.SelectedIndexChanged += wordsListBox_SelectedIndexChanged;
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Font = new Font("PMingLiU-ExtB", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wordLabel.Location = new Point(377, 124);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(103, 40);
            wordLabel.TabIndex = 10;
            wordLabel.Text = "Word";
            // 
            // wordDefinitionsLabel
            // 
            wordDefinitionsLabel.Location = new Point(377, 184);
            wordDefinitionsLabel.Name = "wordDefinitionsLabel";
            wordDefinitionsLabel.Size = new Size(873, 459);
            wordDefinitionsLabel.TabIndex = 11;
            wordDefinitionsLabel.Text = "Definitions";
            // 
            // searchWordPanel
            // 
            searchWordPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchWordPanel.Controls.Add(searchWordButton);
            searchWordPanel.Controls.Add(searchWordTextBox);
            searchWordPanel.Location = new Point(865, 76);
            searchWordPanel.Margin = new Padding(3, 4, 3, 4);
            searchWordPanel.Name = "searchWordPanel";
            searchWordPanel.Size = new Size(384, 56);
            searchWordPanel.TabIndex = 7;
            searchWordPanel.Visible = false;
            // 
            // searchWordButton
            // 
            searchWordButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchWordButton.Location = new Point(253, 12);
            searchWordButton.Margin = new Padding(3, 4, 3, 4);
            searchWordButton.Name = "searchWordButton";
            searchWordButton.Size = new Size(123, 32);
            searchWordButton.TabIndex = 5;
            searchWordButton.Text = "SEARCH";
            searchWordButton.UseVisualStyleBackColor = true;
            searchWordButton.Click += searchWordButton_Click;
            // 
            // searchWordTextBox
            // 
            searchWordTextBox.Location = new Point(131, 13);
            searchWordTextBox.Margin = new Padding(3, 4, 3, 4);
            searchWordTextBox.Name = "searchWordTextBox";
            searchWordTextBox.Size = new Size(114, 27);
            searchWordTextBox.TabIndex = 4;
            // 
            // DictionaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(searchWordPanel);
            Controls.Add(wordDefinitionsLabel);
            Controls.Add(wordLabel);
            Controls.Add(wordsListBox);
            Controls.Add(toggleSearchButton);
            Controls.Add(toggleAddButton);
            Controls.Add(label1);
            Controls.Add(addWordPanel);
            Name = "DictionaryForm";
            Text = "Dictionary";
            Load += DictionaryForm_Load;
            addWordPanel.ResumeLayout(false);
            addWordPanel.PerformLayout();
            searchWordPanel.ResumeLayout(false);
            searchWordPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button toggleAddButton;
        private Button toggleSearchButton;
        private TextBox addWordTextBox;
        private TextBox addDefinitionTextBox;
        private Button addButton;
        private Panel addWordPanel;
        private ListBox wordsListBox;
        private Label wordLabel;
        private Label wordDefinitionsLabel;
        private Panel searchWordPanel;
        private Button searchWordButton;
        private TextBox searchWordTextBox;
    }
}
