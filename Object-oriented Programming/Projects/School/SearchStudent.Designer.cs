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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.Location = new Point(220, 12);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(54, 38);
            numberTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 35);
            label1.TabIndex = 6;
            label1.Text = "№:";
            // 
            // classTextBox
            // 
            classTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classTextBox.Location = new Point(87, 12);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(54, 38);
            classTextBox.TabIndex = 5;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            classLabel.Location = new Point(17, 12);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(71, 35);
            classLabel.TabIndex = 4;
            classLabel.Text = "Клас:";
            // 
            // showFileButton
            // 
            showFileButton.Location = new Point(296, 12);
            showFileButton.Name = "showFileButton";
            showFileButton.Size = new Size(492, 38);
            showFileButton.TabIndex = 18;
            showFileButton.Text = "Покажи файла";
            showFileButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 56);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(771, 243);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // SearchStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 311);
            Controls.Add(richTextBox1);
            Controls.Add(showFileButton);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            Controls.Add(classTextBox);
            Controls.Add(classLabel);
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
        private RichTextBox richTextBox1;
    }
}