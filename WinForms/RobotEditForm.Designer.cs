namespace WinForms
{
    partial class RobotEditForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button2 = new Button();
            btnOk = new Button();
            lblNumber = new Label();
            txtNumber = new TextBox();
            lblSeries = new Label();
            txtSeries = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblGoal = new Label();
            txtGoal = new TextBox();
            lblDetails = new Label();
            txtDetails = new TextBox();
            lblAppearance = new Label();
            txtAppearance = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblCriteria = new Label();
            checkedListCriteria = new CheckedListBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.20382F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.79618F));
            tableLayoutPanel1.Controls.Add(checkedListCriteria, 1, 8);
            tableLayoutPanel1.Controls.Add(lblCriteria, 0, 8);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 7);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 7);
            tableLayoutPanel1.Controls.Add(txtAppearance, 1, 6);
            tableLayoutPanel1.Controls.Add(lblAppearance, 0, 6);
            tableLayoutPanel1.Controls.Add(txtDetails, 1, 5);
            tableLayoutPanel1.Controls.Add(lblDetails, 0, 5);
            tableLayoutPanel1.Controls.Add(txtGoal, 1, 4);
            tableLayoutPanel1.Controls.Add(lblGoal, 0, 4);
            tableLayoutPanel1.Controls.Add(txtName, 1, 3);
            tableLayoutPanel1.Controls.Add(lblName, 0, 3);
            tableLayoutPanel1.Controls.Add(txtType, 1, 2);
            tableLayoutPanel1.Controls.Add(lblType, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSeries, 1, 1);
            tableLayoutPanel1.Controls.Add(lblSeries, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(lblNumber, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(501, 539);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 539);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 48);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.DialogResult = DialogResult.Cancel;
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(302, 0);
            button2.Name = "button2";
            button2.Size = new Size(199, 48);
            button2.TabIndex = 0;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(30, 30, 30);
            btnOk.Dock = DockStyle.Left;
            btnOk.Location = new Point(0, 0);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(199, 48);
            btnOk.TabIndex = 0;
            btnOk.Text = "ОК";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(3, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(64, 21);
            lblNumber.TabIndex = 13;
            lblNumber.Text = "Номер:";
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.FromArgb(30, 30, 30);
            txtNumber.Dock = DockStyle.Fill;
            txtNumber.ForeColor = Color.FromArgb(230, 230, 230);
            txtNumber.Location = new Point(124, 3);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.ScrollBars = ScrollBars.Vertical;
            txtNumber.Size = new Size(374, 45);
            txtNumber.TabIndex = 14;
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Location = new Point(3, 51);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(62, 21);
            lblSeries.TabIndex = 15;
            lblSeries.Text = "Серия:";
            // 
            // txtSeries
            // 
            txtSeries.BackColor = Color.FromArgb(30, 30, 30);
            txtSeries.Dock = DockStyle.Fill;
            txtSeries.ForeColor = Color.FromArgb(230, 230, 230);
            txtSeries.Location = new Point(124, 54);
            txtSeries.Multiline = true;
            txtSeries.Name = "txtSeries";
            txtSeries.ScrollBars = ScrollBars.Vertical;
            txtSeries.Size = new Size(374, 45);
            txtSeries.TabIndex = 16;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(3, 102);
            lblType.Name = "lblType";
            lblType.Size = new Size(41, 21);
            lblType.TabIndex = 17;
            lblType.Text = "Тип:";
            // 
            // txtType
            // 
            txtType.BackColor = Color.FromArgb(30, 30, 30);
            txtType.Dock = DockStyle.Fill;
            txtType.ForeColor = Color.FromArgb(230, 230, 230);
            txtType.Location = new Point(124, 105);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.ScrollBars = ScrollBars.Vertical;
            txtType.Size = new Size(374, 45);
            txtType.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 153);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 21);
            lblName.TabIndex = 19;
            lblName.Text = "Название:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.Dock = DockStyle.Fill;
            txtName.ForeColor = Color.FromArgb(230, 230, 230);
            txtName.Location = new Point(124, 156);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ScrollBars = ScrollBars.Vertical;
            txtName.Size = new Size(374, 45);
            txtName.TabIndex = 20;
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(3, 204);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(54, 21);
            lblGoal.TabIndex = 21;
            lblGoal.Text = "Цель:";
            // 
            // txtGoal
            // 
            txtGoal.BackColor = Color.FromArgb(30, 30, 30);
            txtGoal.Dock = DockStyle.Fill;
            txtGoal.ForeColor = Color.FromArgb(230, 230, 230);
            txtGoal.Location = new Point(124, 207);
            txtGoal.Multiline = true;
            txtGoal.Name = "txtGoal";
            txtGoal.ScrollBars = ScrollBars.Vertical;
            txtGoal.Size = new Size(374, 45);
            txtGoal.TabIndex = 22;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(3, 255);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(72, 21);
            lblDetails.TabIndex = 23;
            lblDetails.Text = "Детали:";
            // 
            // txtDetails
            // 
            txtDetails.BackColor = Color.FromArgb(30, 30, 30);
            txtDetails.Dock = DockStyle.Fill;
            txtDetails.ForeColor = Color.FromArgb(230, 230, 230);
            txtDetails.Location = new Point(124, 258);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(374, 45);
            txtDetails.TabIndex = 24;
            // 
            // lblAppearance
            // 
            lblAppearance.AutoSize = true;
            lblAppearance.Location = new Point(3, 306);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(101, 21);
            lblAppearance.TabIndex = 25;
            lblAppearance.Text = "Внешность:";
            // 
            // txtAppearance
            // 
            txtAppearance.BackColor = Color.FromArgb(30, 30, 30);
            txtAppearance.Dock = DockStyle.Fill;
            txtAppearance.ForeColor = Color.FromArgb(230, 230, 230);
            txtAppearance.Location = new Point(124, 309);
            txtAppearance.Multiline = true;
            txtAppearance.Name = "txtAppearance";
            txtAppearance.ScrollBars = ScrollBars.Vertical;
            txtAppearance.Size = new Size(374, 45);
            txtAppearance.TabIndex = 26;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 357);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(82, 21);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "Цена (₽):";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(30, 30, 30);
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.ForeColor = Color.FromArgb(230, 230, 230);
            txtPrice.Location = new Point(124, 360);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.ScrollBars = ScrollBars.Vertical;
            txtPrice.Size = new Size(374, 45);
            txtPrice.TabIndex = 28;
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Location = new Point(3, 408);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(90, 42);
            lblCriteria.TabIndex = 29;
            lblCriteria.Text = "Критерии (Оценка):";
            // 
            // checkedListCriteria
            // 
            checkedListCriteria.BackColor = Color.FromArgb(30, 30, 30);
            checkedListCriteria.Dock = DockStyle.Fill;
            checkedListCriteria.ForeColor = Color.FromArgb(230, 230, 230);
            checkedListCriteria.FormattingEnabled = true;
            checkedListCriteria.Items.AddRange(new object[] { "1. За продвинутый ИИ", "2. За отличную манёвренность", "3. За высокую огневую мощь", "4. За прочную защиту", "5. За автономность", "6. За адаптивность", "7. За эффективность в роли", "8. За надёжность", "9. За универсальность", "10. За инновационность" });
            checkedListCriteria.Location = new Point(124, 411);
            checkedListCriteria.Name = "checkedListCriteria";
            checkedListCriteria.Size = new Size(374, 125);
            checkedListCriteria.TabIndex = 30;
            // 
            // RobotEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(501, 587);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(230, 230, 230);
            Name = "RobotEditForm";
            Text = "Добавить";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnOk;
        private Button button2;
        private CheckedListBox checkedListCriteria;
        private Label lblCriteria;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtAppearance;
        private Label lblAppearance;
        private TextBox txtDetails;
        private Label lblDetails;
        private TextBox txtGoal;
        private Label lblGoal;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtType;
        private Label lblType;
        private TextBox txtSeries;
        private Label lblSeries;
        private TextBox txtNumber;
        private Label lblNumber;
    }
}