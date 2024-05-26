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
            operationWordTextBox = new TextBox();
            operationDefinitionTextBox = new TextBox();
            performOperationButton = new Button();
            operationPanel = new Panel();
            refreshDictionaryButton = new Button();
            wordsListBox = new ListBox();
            wordLabel = new Label();
            wordDefinitionsLabel = new Label();
            operationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(313, 48);
            label1.TabIndex = 0;
            label1.Text = "DICTIONARY";
            // 
            // toggleAddButton
            // 
            toggleAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleAddButton.Image = Properties.Resources.addIcon;
            toggleAddButton.Location = new Point(1041, 7);
            toggleAddButton.Margin = new Padding(3, 2, 3, 2);
            toggleAddButton.Name = "toggleAddButton";
            toggleAddButton.Size = new Size(52, 45);
            toggleAddButton.TabIndex = 1;
            toggleAddButton.Text = "button1";
            toggleAddButton.UseVisualStyleBackColor = true;
            // 
            // toggleSearchButton
            // 
            toggleSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSearchButton.Image = Properties.Resources.addIcon;
            toggleSearchButton.Location = new Point(984, 7);
            toggleSearchButton.Margin = new Padding(3, 2, 3, 2);
            toggleSearchButton.Name = "toggleSearchButton";
            toggleSearchButton.Size = new Size(52, 45);
            toggleSearchButton.TabIndex = 2;
            toggleSearchButton.Text = "button1";
            toggleSearchButton.UseVisualStyleBackColor = true;
            // 
            // operationWordTextBox
            // 
            operationWordTextBox.Location = new Point(9, 10);
            operationWordTextBox.Name = "operationWordTextBox";
            operationWordTextBox.Size = new Size(100, 23);
            operationWordTextBox.TabIndex = 3;
            // 
            // operationDefinitionTextBox
            // 
            operationDefinitionTextBox.Location = new Point(115, 10);
            operationDefinitionTextBox.Name = "operationDefinitionTextBox";
            operationDefinitionTextBox.Size = new Size(100, 23);
            operationDefinitionTextBox.TabIndex = 4;
            // 
            // performOperationButton
            // 
            performOperationButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            performOperationButton.Location = new Point(221, 9);
            performOperationButton.Name = "performOperationButton";
            performOperationButton.Size = new Size(108, 24);
            performOperationButton.TabIndex = 5;
            performOperationButton.Text = "ADD";
            performOperationButton.UseVisualStyleBackColor = true;
            performOperationButton.Click += performOperationButton_Click;
            // 
            // operationPanel
            // 
            operationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            operationPanel.Controls.Add(performOperationButton);
            operationPanel.Controls.Add(operationDefinitionTextBox);
            operationPanel.Controls.Add(operationWordTextBox);
            operationPanel.Location = new Point(763, 48);
            operationPanel.Name = "operationPanel";
            operationPanel.Size = new Size(336, 42);
            operationPanel.TabIndex = 6;
            // 
            // refreshDictionaryButton
            // 
            refreshDictionaryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshDictionaryButton.Image = Properties.Resources.addIcon;
            refreshDictionaryButton.Location = new Point(926, 7);
            refreshDictionaryButton.Margin = new Padding(3, 2, 3, 2);
            refreshDictionaryButton.Name = "refreshDictionaryButton";
            refreshDictionaryButton.Size = new Size(52, 45);
            refreshDictionaryButton.TabIndex = 8;
            refreshDictionaryButton.Text = "button1";
            refreshDictionaryButton.UseVisualStyleBackColor = true;
            // 
            // wordsListBox
            // 
            wordsListBox.FormattingEnabled = true;
            wordsListBox.ItemHeight = 15;
            wordsListBox.Location = new Point(8, 89);
            wordsListBox.Name = "wordsListBox";
            wordsListBox.Size = new Size(305, 394);
            wordsListBox.TabIndex = 9;
            wordsListBox.SelectedValueChanged += wordsListBox_SelectedValueChanged;
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Font = new Font("PMingLiU-ExtB", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wordLabel.Location = new Point(330, 93);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(86, 32);
            wordLabel.TabIndex = 10;
            wordLabel.Text = "label2";
            // 
            // wordDefinitionsLabel
            // 
            wordDefinitionsLabel.AutoSize = true;
            wordDefinitionsLabel.Location = new Point(330, 138);
            wordDefinitionsLabel.Name = "wordDefinitionsLabel";
            wordDefinitionsLabel.Size = new Size(38, 15);
            wordDefinitionsLabel.TabIndex = 11;
            wordDefinitionsLabel.Text = "label2";
            // 
            // DictionaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(wordDefinitionsLabel);
            Controls.Add(wordLabel);
            Controls.Add(wordsListBox);
            Controls.Add(refreshDictionaryButton);
            Controls.Add(operationPanel);
            Controls.Add(toggleSearchButton);
            Controls.Add(toggleAddButton);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DictionaryForm";
            Text = "Dictionary";
            operationPanel.ResumeLayout(false);
            operationPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button toggleAddButton;
        private Button toggleSearchButton;
        private TextBox operationWordTextBox;
        private TextBox operationDefinitionTextBox;
        private Button performOperationButton;
        private Panel operationPanel;
        private Button refreshDictionaryButton;
        private ListBox wordsListBox;
        private Label wordLabel;
        private Label wordDefinitionsLabel;
    }
}
