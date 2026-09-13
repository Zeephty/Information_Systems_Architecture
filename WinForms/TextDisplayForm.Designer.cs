namespace WinForms
{
    partial class TextDisplayForm
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
            richTextBoxText = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBoxText
            // 
            richTextBoxText.BackColor = Color.FromArgb(38, 38, 38);
            richTextBoxText.ForeColor = Color.FromArgb(230, 230, 230);
            richTextBoxText.Location = new Point(12, 12);
            richTextBoxText.Name = "richTextBoxText";
            richTextBoxText.ReadOnly = true;
            richTextBoxText.Size = new Size(258, 329);
            richTextBoxText.TabIndex = 0;
            richTextBoxText.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 38, 38);
            button1.DialogResult = DialogResult.OK;
            button1.ForeColor = Color.FromArgb(230, 230, 230);
            button1.Location = new Point(176, 347);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            // 
            // TextDisplayForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(284, 397);
            Controls.Add(button1);
            Controls.Add(richTextBoxText);
            Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TextDisplayForm";
            Text = "Результат";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxText;
        private Button button1;
    }
}