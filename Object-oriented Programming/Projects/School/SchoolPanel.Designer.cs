namespace School
{
    partial class SchoolPanel
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
            classLabel = new Label();
            classTextBox = new TextBox();
            numberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            firstNameTextBox = new TextBox();
            belGradeTextBox = new TextBox();
            label3 = new Label();
            foreignLanguageGradeTextBox = new TextBox();
            label4 = new Label();
            mathGradeTextBox = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            averageGradeTextBox = new TextBox();
            label6 = new Label();
            button4 = new Button();
            biologyGradeTextBox = new TextBox();
            label7 = new Label();
            chemistryGradeTextBox = new TextBox();
            label8 = new Label();
            physicsGradeTextBox = new TextBox();
            label9 = new Label();
            lastNameTextBox = new TextBox();
            label10 = new Label();
            studentsListBox = new ListBox();
            SuspendLayout();
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            classLabel.Location = new Point(11, 20);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(71, 35);
            classLabel.TabIndex = 0;
            classLabel.Text = "Клас:";
            // 
            // classTextBox
            // 
            classTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classTextBox.Location = new Point(82, 20);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(54, 38);
            classTextBox.TabIndex = 1;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.Location = new Point(215, 20);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(54, 38);
            numberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(165, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 35);
            label1.TabIndex = 2;
            label1.Text = "№:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(309, 20);
            label2.Name = "label2";
            label2.Size = new Size(91, 35);
            label2.TabIndex = 4;
            label2.Text = "Имена:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(397, 20);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(174, 38);
            firstNameTextBox.TabIndex = 5;
            // 
            // belGradeTextBox
            // 
            belGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            belGradeTextBox.Location = new Point(215, 91);
            belGradeTextBox.Name = "belGradeTextBox";
            belGradeTextBox.Size = new Size(54, 38);
            belGradeTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(11, 91);
            label3.Name = "label3";
            label3.Size = new Size(66, 35);
            label3.TabIndex = 6;
            label3.Text = "БЕЛ:";
            // 
            // foreignLanguageGradeTextBox
            // 
            foreignLanguageGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreignLanguageGradeTextBox.Location = new Point(215, 135);
            foreignLanguageGradeTextBox.Name = "foreignLanguageGradeTextBox";
            foreignLanguageGradeTextBox.Size = new Size(54, 38);
            foreignLanguageGradeTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(11, 135);
            label4.Name = "label4";
            label4.Size = new Size(133, 35);
            label4.TabIndex = 8;
            label4.Text = "Чужд език:";
            // 
            // mathGradeTextBox
            // 
            mathGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mathGradeTextBox.Location = new Point(215, 179);
            mathGradeTextBox.Name = "mathGradeTextBox";
            mathGradeTextBox.Size = new Size(54, 38);
            mathGradeTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label5.Location = new Point(11, 179);
            label5.Name = "label5";
            label5.Size = new Size(149, 35);
            label5.TabIndex = 10;
            label5.Text = "Математика:";
            // 
            // button1
            // 
            button1.Location = new Point(616, 88);
            button1.Name = "button1";
            button1.Size = new Size(171, 37);
            button1.TabIndex = 12;
            button1.Text = "Изчисти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(616, 135);
            button2.Name = "button2";
            button2.Size = new Size(171, 37);
            button2.TabIndex = 13;
            button2.Text = "Запази";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(616, 181);
            button3.Name = "button3";
            button3.Size = new Size(171, 37);
            button3.TabIndex = 14;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // averageGradeTextBox
            // 
            averageGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            averageGradeTextBox.Location = new Point(215, 248);
            averageGradeTextBox.Name = "averageGradeTextBox";
            averageGradeTextBox.ReadOnly = true;
            averageGradeTextBox.Size = new Size(185, 38);
            averageGradeTextBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label6.Location = new Point(11, 248);
            label6.Name = "label6";
            label6.Size = new Size(160, 35);
            label6.TabIndex = 15;
            label6.Text = "Среден успех:";
            // 
            // button4
            // 
            button4.Location = new Point(405, 248);
            button4.Name = "button4";
            button4.Size = new Size(383, 37);
            button4.TabIndex = 17;
            button4.Text = "Пресметни среден успех";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // biologyGradeTextBox
            // 
            biologyGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            biologyGradeTextBox.Location = new Point(517, 179);
            biologyGradeTextBox.Name = "biologyGradeTextBox";
            biologyGradeTextBox.Size = new Size(54, 38);
            biologyGradeTextBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label7.Location = new Point(313, 179);
            label7.Name = "label7";
            label7.Size = new Size(124, 35);
            label7.TabIndex = 22;
            label7.Text = "Биология:";
            // 
            // chemistryGradeTextBox
            // 
            chemistryGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chemistryGradeTextBox.Location = new Point(517, 135);
            chemistryGradeTextBox.Name = "chemistryGradeTextBox";
            chemistryGradeTextBox.Size = new Size(54, 38);
            chemistryGradeTextBox.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label8.Location = new Point(313, 135);
            label8.Name = "label8";
            label8.Size = new Size(93, 35);
            label8.TabIndex = 20;
            label8.Text = "Химия:";
            // 
            // physicsGradeTextBox
            // 
            physicsGradeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            physicsGradeTextBox.Location = new Point(517, 91);
            physicsGradeTextBox.Name = "physicsGradeTextBox";
            physicsGradeTextBox.Size = new Size(54, 38);
            physicsGradeTextBox.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label9.Location = new Point(313, 91);
            label9.Name = "label9";
            label9.Size = new Size(100, 35);
            label9.TabIndex = 18;
            label9.Text = "Физика:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(611, 20);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(174, 38);
            lastNameTextBox.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display Semibold", 14F, FontStyle.Bold);
            label10.Location = new Point(12, 629);
            label10.Name = "label10";
            label10.Size = new Size(739, 35);
            label10.TabIndex = 25;
            label10.Text = "Средният успех се изчислява без да се запазват данните за ученика.";
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.Location = new Point(803, 20);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(447, 264);
            studentsListBox.TabIndex = 26;
            studentsListBox.SelectedIndexChanged += studentsListBox_SelectedIndexChanged;
            // 
            // SchoolPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1262, 673);
            Controls.Add(studentsListBox);
            Controls.Add(label10);
            Controls.Add(lastNameTextBox);
            Controls.Add(biologyGradeTextBox);
            Controls.Add(label7);
            Controls.Add(chemistryGradeTextBox);
            Controls.Add(label8);
            Controls.Add(physicsGradeTextBox);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(averageGradeTextBox);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mathGradeTextBox);
            Controls.Add(label5);
            Controls.Add(foreignLanguageGradeTextBox);
            Controls.Add(label4);
            Controls.Add(belGradeTextBox);
            Controls.Add(label3);
            Controls.Add(firstNameTextBox);
            Controls.Add(label2);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            Controls.Add(classTextBox);
            Controls.Add(classLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SchoolPanel";
            ShowIcon = false;
            Text = "School";
            Load += SchoolPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classLabel;
        private TextBox classTextBox;
        private TextBox numberTextBox;
        private Label label1;
        private Label label2;
        private TextBox firstNameTextBox;
        private TextBox belGradeTextBox;
        private Label label3;
        private TextBox foreignLanguageGradeTextBox;
        private Label label4;
        private TextBox mathGradeTextBox;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox averageGradeTextBox;
        private Label label6;
        private Button button4;
        private TextBox biologyGradeTextBox;
        private Label label7;
        private TextBox chemistryGradeTextBox;
        private Label label8;
        private TextBox physicsGradeTextBox;
        private Label label9;
        private TextBox lastNameTextBox;
        private Label label10;
        private ListBox studentsListBox;
    }
}
