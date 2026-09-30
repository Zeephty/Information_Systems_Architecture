namespace WinForms
{
    partial class DataSourceForm
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
            rbJson = new RadioButton();
            rbDapper = new RadioButton();
            rbEf = new RadioButton();
            panel1 = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // rbJson
            // 
            rbJson.AutoSize = true;
            rbJson.Dock = DockStyle.Top;
            rbJson.Location = new Point(20, 20);
            rbJson.Name = "rbJson";
            rbJson.Size = new Size(366, 25);
            rbJson.TabIndex = 0;
            rbJson.TabStop = true;
            rbJson.Text = "JSON-файл";
            rbJson.UseVisualStyleBackColor = true;
            // 
            // rbDapper
            // 
            rbDapper.AutoSize = true;
            rbDapper.Dock = DockStyle.Fill;
            rbDapper.Location = new Point(20, 45);
            rbDapper.Name = "rbDapper";
            rbDapper.Size = new Size(366, 121);
            rbDapper.TabIndex = 1;
            rbDapper.TabStop = true;
            rbDapper.Text = "Dapper (SQL Server)";
            rbDapper.UseVisualStyleBackColor = true;
            // 
            // rbEf
            // 
            rbEf.AutoSize = true;
            rbEf.Dock = DockStyle.Bottom;
            rbEf.Location = new Point(20, 166);
            rbEf.Name = "rbEf";
            rbEf.Size = new Size(366, 25);
            rbEf.TabIndex = 2;
            rbEf.TabStop = true;
            rbEf.Text = "Entity Framework (SQL Server)";
            rbEf.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 245);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(406, 68);
            panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(30, 30, 30);
            btnCancel.Dock = DockStyle.Right;
            btnCancel.Location = new Point(198, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 48);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(30, 30, 30);
            btnOk.Dock = DockStyle.Left;
            btnOk.Location = new Point(10, 10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(182, 48);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbDapper);
            panel2.Controls.Add(rbJson);
            panel2.Controls.Add(rbEf);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(406, 211);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 34);
            label1.TabIndex = 0;
            label1.Text = "Выбор источника:";
            // 
            // DataSourceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(406, 313);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(230, 230, 230);
            Name = "DataSourceForm";
            Text = "Выбор источника";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbJson;
        private RadioButton rbDapper;
        private RadioButton rbEf;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnCancel;
        private Button btnOk;
    }
}