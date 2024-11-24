namespace TestWinFormsApp
{
    partial class CalendarForm
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
            label1 = new Label();
            StudentListButton = new Button();
            LogOutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 172);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Calendar";
            // 
            // StudentListButton
            // 
            StudentListButton.Location = new Point(22, 160);
            StudentListButton.Name = "StudentListButton";
            StudentListButton.Size = new Size(94, 29);
            StudentListButton.TabIndex = 1;
            StudentListButton.Text = "Student List";
            StudentListButton.UseVisualStyleBackColor = true;
            StudentListButton.Click += StudentListButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Location = new Point(22, 218);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(94, 29);
            LogOutButton.TabIndex = 2;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOutButton);
            Controls.Add(StudentListButton);
            Controls.Add(label1);
            Name = "CalendarForm";
            Text = "Calendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StudentListButton;
        private Button LogOutButton;
    }
}