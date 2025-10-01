namespace Attendance.Presentation.Forms
{
    partial class Reports
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
            button1.Location = new Point(269, 155);
            button1.Name = "button1";
            button1.Size = new Size(262, 141);
            button1.TabIndex = 1;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
        }
        private Button button1;
    }
}