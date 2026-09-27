namespace WinForms
{
    partial class PropertyEditDialog
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
            lblPrompt = new Label();
            txtValue = new TextBox();
            panel1 = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Dock = DockStyle.Top;
            lblPrompt.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPrompt.Location = new Point(0, 0);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(119, 28);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Значение:";
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.FromArgb(30, 30, 30);
            txtValue.Dock = DockStyle.Fill;
            txtValue.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtValue.ForeColor = Color.FromArgb(230, 230, 230);
            txtValue.Location = new Point(0, 28);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.ScrollBars = ScrollBars.Vertical;
            txtValue.Size = new Size(665, 135);
            txtValue.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 51);
            panel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(30, 30, 30);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancel.Location = new Point(507, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 51);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(30, 30, 30);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnOk.Location = new Point(356, 0);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 51);
            btnOk.TabIndex = 3;
            btnOk.Text = "ОК";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // PropertyEditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(665, 214);
            Controls.Add(txtValue);
            Controls.Add(panel1);
            Controls.Add(lblPrompt);
            ForeColor = Color.FromArgb(230, 230, 230);
            Name = "PropertyEditDialog";
            Text = "Редактирование";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtValue;
        private Panel panel1;
        private Button btnOk;
        private Button btnCancel;
    }
}