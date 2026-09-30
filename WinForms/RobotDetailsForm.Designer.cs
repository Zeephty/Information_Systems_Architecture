namespace WinForms
{
    partial class RobotDetailsForm
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
            richTextBoxDetails = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.BackColor = Color.FromArgb(30, 30, 30);
            richTextBoxDetails.Dock = DockStyle.Fill;
            richTextBoxDetails.ForeColor = Color.FromArgb(230, 230, 230);
            richTextBoxDetails.Location = new Point(0, 0);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.ReadOnly = true;
            richTextBoxDetails.Size = new Size(726, 472);
            richTextBoxDetails.TabIndex = 0;
            richTextBoxDetails.Text = "";
            // 
            // RobotDetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(726, 472);
            Controls.Add(richTextBoxDetails);
            Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(230, 230, 230);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RobotDetailsForm";
            Text = "RobotDetailsForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxDetails;
    }
}