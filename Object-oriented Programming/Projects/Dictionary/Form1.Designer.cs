namespace Dictionary
{
    partial class Form1
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 60);
            label1.TabIndex = 0;
            label1.Text = "DICTIONARY";
            // 
            // toggleAddButton
            // 
            toggleAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleAddButton.Image = Properties.Resources.addIcon;
            toggleAddButton.Location = new Point(1190, 9);
            toggleAddButton.Name = "toggleAddButton";
            toggleAddButton.Size = new Size(60, 60);
            toggleAddButton.TabIndex = 1;
            toggleAddButton.Text = "button1";
            toggleAddButton.UseVisualStyleBackColor = true;
            // 
            // toggleSearchButton
            // 
            toggleSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleSearchButton.Image = Properties.Resources.addIcon;
            toggleSearchButton.Location = new Point(1124, 9);
            toggleSearchButton.Name = "toggleSearchButton";
            toggleSearchButton.Size = new Size(60, 60);
            toggleSearchButton.TabIndex = 2;
            toggleSearchButton.Text = "button1";
            toggleSearchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(toggleSearchButton);
            Controls.Add(toggleAddButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button toggleAddButton;
        private Button toggleSearchButton;
    }
}
