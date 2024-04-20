namespace Task3
{
    partial class Task3
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
            biorhythmsCalculatorTitleTextBox = new Label();
            conditionLabel = new Label();
            dateOfBirthLabel = new Label();
            conditionComboBox = new ComboBox();
            dateOfBirthDateTimePicker = new DateTimePicker();
            calculateBiorhythmsButton = new Button();
            biorhythmsLabel = new Label();
            SuspendLayout();
            // 
            // biorhythmsCalculatorTitleTextBox
            // 
            biorhythmsCalculatorTitleTextBox.AutoSize = true;
            biorhythmsCalculatorTitleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            biorhythmsCalculatorTitleTextBox.Location = new Point(187, 18);
            biorhythmsCalculatorTitleTextBox.Name = "biorhythmsCalculatorTitleTextBox";
            biorhythmsCalculatorTitleTextBox.Size = new Size(417, 41);
            biorhythmsCalculatorTitleTextBox.TabIndex = 0;
            biorhythmsCalculatorTitleTextBox.Text = "BIORHYTHMS CALCULATOR";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conditionLabel.Location = new Point(129, 95);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(148, 38);
            conditionLabel.TabIndex = 1;
            conditionLabel.Text = "Condition:";
            conditionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateOfBirthLabel.Location = new Point(89, 147);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(188, 38);
            dateOfBirthLabel.TabIndex = 2;
            dateOfBirthLabel.Text = "Date of Birth:";
            dateOfBirthLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // conditionComboBox
            // 
            conditionComboBox.FormattingEnabled = true;
            conditionComboBox.Items.AddRange(new object[] { "Physical", "Emotional", "Intellectual" });
            conditionComboBox.Location = new Point(283, 105);
            conditionComboBox.Name = "conditionComboBox";
            conditionComboBox.Size = new Size(381, 28);
            conditionComboBox.TabIndex = 3;
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Location = new Point(283, 157);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(381, 27);
            dateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // calculateBiorhythmsButton
            // 
            calculateBiorhythmsButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateBiorhythmsButton.Location = new Point(89, 234);
            calculateBiorhythmsButton.Name = "calculateBiorhythmsButton";
            calculateBiorhythmsButton.Size = new Size(575, 53);
            calculateBiorhythmsButton.TabIndex = 5;
            calculateBiorhythmsButton.Text = "Calculate Biorhythms";
            calculateBiorhythmsButton.UseVisualStyleBackColor = true;
            calculateBiorhythmsButton.Click += calculateBiorhythmsButton_Click;
            // 
            // biorhythmsLabel
            // 
            biorhythmsLabel.AutoSize = true;
            biorhythmsLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            biorhythmsLabel.Location = new Point(245, 314);
            biorhythmsLabel.Name = "biorhythmsLabel";
            biorhythmsLabel.Size = new Size(272, 46);
            biorhythmsLabel.TabIndex = 6;
            biorhythmsLabel.Text = "300 biorhythms";
            biorhythmsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(biorhythmsLabel);
            Controls.Add(calculateBiorhythmsButton);
            Controls.Add(dateOfBirthDateTimePicker);
            Controls.Add(conditionComboBox);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(conditionLabel);
            Controls.Add(biorhythmsCalculatorTitleTextBox);
            Name = "Task3";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label biorhythmsCalculatorTitleTextBox;
        private Label conditionLabel;
        private Label dateOfBirthLabel;
        private ComboBox conditionComboBox;
        private DateTimePicker dateOfBirthDateTimePicker;
        private Button calculateBiorhythmsButton;
        private Label biorhythmsLabel;
    }
}
