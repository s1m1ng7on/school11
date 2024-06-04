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
            numberTextBox.Location = new Point(214, 12);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(54, 38);
            numberTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(165, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 35);
            label1.TabIndex = 6;
            label1.Text = "№:";
            // 
            // classTextBox
            // 
            classTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classTextBox.Location = new Point(82, 12);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(54, 38);
            classTextBox.TabIndex = 5;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            classLabel.Location = new Point(12, 12);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(71, 35);
            classLabel.TabIndex = 4;
            classLabel.Text = "Клас:";
            // 
            // showFileButton
            // 
            showFileButton.Location = new Point(662, 13);
            showFileButton.Name = "showFileButton";
            showFileButton.Size = new Size(588, 37);
            showFileButton.TabIndex = 18;
            showFileButton.Text = "Търси Ученик";
            showFileButton.UseVisualStyleBackColor = true;
            showFileButton.Click += showFileButton_Click;
            // 
            // studentInfoRichTextBox
            // 
            studentInfoRichTextBox.Location = new Point(12, 56);
            studentInfoRichTextBox.Name = "studentInfoRichTextBox";
            studentInfoRichTextBox.ReadOnly = true;
            studentInfoRichTextBox.Size = new Size(1238, 570);
            studentInfoRichTextBox.TabIndex = 19;
            studentInfoRichTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 629);
            label2.Name = "label2";
            label2.Size = new Size(884, 35);
            label2.TabIndex = 20;
            label2.Text = "При празни полета за клас и номер се показва кратка справка за всички ученици.";
            // 
            // SearchStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1262, 673);
            Controls.Add(label2);
            Controls.Add(studentInfoRichTextBox);
            Controls.Add(showFileButton);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            Controls.Add(classTextBox);
            Controls.Add(classLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SearchStudent";
            ShowIcon = false;
            Text = "School";
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