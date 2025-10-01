namespace Attendance.Presentation.Forms
{
    partial class ClassManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(293, 182);
            button1.Name = "button1";
            button1.Size = new Size(262, 141);
            button1.TabIndex = 0;
            button1.Text = "Class Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "ClassManagement";
            Text = "Class Management";
            ResumeLayout(false);
        }
        private Button button1;
    }
}