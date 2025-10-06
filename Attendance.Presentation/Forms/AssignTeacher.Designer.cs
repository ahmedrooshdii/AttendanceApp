namespace Attendance.Presentation.Forms
{
    partial class AssignTeacher
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
            Panal_ChkBox = new Panel();
            BtnCansel = new Button();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // Panal_ChkBox
            // 
            Panal_ChkBox.BackColor = SystemColors.ButtonHighlight;
            Panal_ChkBox.Location = new Point(291, 56);
            Panal_ChkBox.Name = "Panal_ChkBox";
            Panal_ChkBox.Size = new Size(321, 214);
            Panal_ChkBox.TabIndex = 0;
            // 
            // BtnCansel
            // 
            BtnCansel.BackColor = Color.Red;
            BtnCansel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCansel.ForeColor = SystemColors.ButtonHighlight;
            BtnCansel.Location = new Point(483, 338);
            BtnCansel.Name = "BtnCansel";
            BtnCansel.Size = new Size(162, 54);
            BtnCansel.TabIndex = 2;
            BtnCansel.Text = "Cancel";
            BtnCansel.UseVisualStyleBackColor = false;
            BtnCansel.Click += BtnCansel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 0;
            label1.Text = "Select teachers to assign";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(153, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(191, 54);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Assignment";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // AssignTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCansel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(Panal_ChkBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AssignTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignTeacher";
            Load += AssignTeacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panal_ChkBox;
        private Label label1;
        private Button btnSave;
        private Button BtnCansel;
    }
}