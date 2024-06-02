namespace School
{
    partial class SearchStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numberTextBox = new TextBox();
            label1 = new Label();
            classTextBox = new TextBox();
            classLabel = new Label();
            showFileButton = new Button();
            studentInfoRichTextBox = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.Location = new Point(192, 9);
            numberTextBox.Margin = new Padding(3, 2, 3, 2);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(48, 32);
            numberTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 6;
            label1.Text = "№:";
            // 
            // classTextBox
            // 
            classTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classTextBox.Location = new Point(76, 9);
            classTextBox.Margin = new Padding(3, 2, 3, 2);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(48, 32);
            classTextBox.TabIndex = 5;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            classLabel.Location = new Point(15, 9);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(57, 28);
            classLabel.TabIndex = 4;
            classLabel.Text = "Клас:";
            // 
            // showFileButton
            // 
            showFileButton.Location = new Point(259, 9);
            showFileButton.Margin = new Padding(3, 2, 3, 2);
            showFileButton.Name = "showFileButton";
            showFileButton.Size = new Size(430, 28);
            showFileButton.TabIndex = 18;
            showFileButton.Text = "Търси Ученик";
            showFileButton.UseVisualStyleBackColor = true;
            showFileButton.Click += showFileButton_Click;
            // 
            // studentInfoRichTextBox
            // 
            studentInfoRichTextBox.Location = new Point(15, 42);
            studentInfoRichTextBox.Margin = new Padding(3, 2, 3, 2);
            studentInfoRichTextBox.Name = "studentInfoRichTextBox";
            studentInfoRichTextBox.ReadOnly = true;
            studentInfoRichTextBox.Size = new Size(675, 183);
            studentInfoRichTextBox.TabIndex = 19;
            studentInfoRichTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 229);
            label2.Name = "label2";
            label2.Size = new Size(460, 15);
            label2.TabIndex = 20;
            label2.Text = "При празни полета за клас и номер се показва кратка справка за всички ученици.";
            // 
            // SearchStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 253);
            Controls.Add(label2);
            Controls.Add(studentInfoRichTextBox);
            Controls.Add(showFileButton);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            Controls.Add(classTextBox);
            Controls.Add(classLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchStudent";
            Text = "SearchStudent";
            FormClosed += SearchStudent_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberTextBox;
        private Label label1;
        private TextBox classTextBox;
        private Label classLabel;
        private Button showFileButton;
        private RichTextBox studentInfoRichTextBox;
        private Label label2;
    }
}