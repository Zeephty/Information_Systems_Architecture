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
            lblId = new Label();
            lblNumber = new Label();
            lblSeries = new Label();
            lblType = new Label();
            lblName = new Label();
            lblGoal = new Label();
            lblDetails = new Label();
            lblAppearance = new Label();
            lblScore = new Label();
            lblPrice = new Label();
            lblCriteria = new Label();
            checkedListCriteria = new CheckedListBox();
            txtId = new TextBox();
            txtNumber = new TextBox();
            txtSeries = new TextBox();
            txtType = new TextBox();
            txtName = new TextBox();
            txtGoal = new TextBox();
            txtDetails = new TextBox();
            txtAppearance = new TextBox();
            txtScore = new TextBox();
            txtPrice = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            btnOk = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2038212F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.79618F));
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNumber, 0, 1);
            tableLayoutPanel1.Controls.Add(lblSeries, 0, 2);
            tableLayoutPanel1.Controls.Add(lblType, 0, 3);
            tableLayoutPanel1.Controls.Add(lblName, 0, 4);
            tableLayoutPanel1.Controls.Add(lblGoal, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDetails, 0, 6);
            tableLayoutPanel1.Controls.Add(lblAppearance, 0, 7);
            tableLayoutPanel1.Controls.Add(lblScore, 0, 8);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 9);
            tableLayoutPanel1.Controls.Add(lblCriteria, 0, 10);
            tableLayoutPanel1.Controls.Add(checkedListCriteria, 1, 10);
            tableLayoutPanel1.Controls.Add(txtId, 1, 0);
            tableLayoutPanel1.Controls.Add(txtNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSeries, 1, 2);
            tableLayoutPanel1.Controls.Add(txtType, 1, 3);
            tableLayoutPanel1.Controls.Add(txtName, 1, 4);
            tableLayoutPanel1.Controls.Add(txtGoal, 1, 5);
            tableLayoutPanel1.Controls.Add(txtDetails, 1, 6);
            tableLayoutPanel1.Controls.Add(txtAppearance, 1, 7);
            tableLayoutPanel1.Controls.Add(txtScore, 1, 8);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 9);
            tableLayoutPanel1.Location = new Point(14, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Size = new Size(471, 496);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 21);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(3, 37);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(64, 21);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Номер:";
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Location = new Point(3, 74);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(62, 21);
            lblSeries.TabIndex = 2;
            lblSeries.Text = "Серия:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(3, 111);
            lblType.Name = "lblType";
            lblType.Size = new Size(41, 21);
            lblType.TabIndex = 3;
            lblType.Text = "Тип:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 148);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Название:";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(3, 185);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(54, 21);
            lblGoal.TabIndex = 5;
            lblGoal.Text = "Цель:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(3, 222);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(72, 21);
            lblDetails.TabIndex = 6;
            lblDetails.Text = "Детали:";
            // 
            // lblAppearance
            // 
            lblAppearance.AutoSize = true;
            lblAppearance.Location = new Point(3, 259);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(101, 21);
            lblAppearance.TabIndex = 7;
            lblAppearance.Text = "Внешность:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(3, 296);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(72, 21);
            lblScore.TabIndex = 8;
            lblScore.Text = "Оценка:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 333);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(82, 21);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Цена (₽):";
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Location = new Point(3, 370);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(89, 21);
            lblCriteria.TabIndex = 10;
            lblCriteria.Text = "Критерии:";
            // 
            // checkedListCriteria
            // 
            checkedListCriteria.BackColor = Color.FromArgb(30, 30, 30);
            checkedListCriteria.ForeColor = Color.FromArgb(230, 230, 230);
            checkedListCriteria.FormattingEnabled = true;
            checkedListCriteria.Items.AddRange(new object[] { "1. За продвинутый ИИ", "2. За отличную манёвренность", "3. За высокую огневую мощь", "4. За прочную защиту", "5. За автономность", "6. За адаптивность", "7. За эффективность в роли", "8. За надёжность", "9. За универсальность", "10. За инновационность" });
            checkedListCriteria.Location = new Point(117, 373);
            checkedListCriteria.Name = "checkedListCriteria";
            checkedListCriteria.Size = new Size(316, 119);
            checkedListCriteria.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(30, 30, 30);
            txtId.ForeColor = Color.FromArgb(230, 230, 230);
            txtId.Location = new Point(117, 3);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ScrollBars = ScrollBars.Vertical;
            txtId.Size = new Size(316, 28);
            txtId.TabIndex = 12;
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.FromArgb(30, 30, 30);
            txtNumber.ForeColor = Color.FromArgb(230, 230, 230);
            txtNumber.Location = new Point(117, 40);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.ScrollBars = ScrollBars.Vertical;
            txtNumber.Size = new Size(316, 28);
            txtNumber.TabIndex = 12;
            // 
            // txtSeries
            // 
            txtSeries.BackColor = Color.FromArgb(30, 30, 30);
            txtSeries.ForeColor = Color.FromArgb(230, 230, 230);
            txtSeries.Location = new Point(117, 77);
            txtSeries.Multiline = true;
            txtSeries.Name = "txtSeries";
            txtSeries.ScrollBars = ScrollBars.Vertical;
            txtSeries.Size = new Size(316, 28);
            txtSeries.TabIndex = 12;
            // 
            // txtType
            // 
            txtType.BackColor = Color.FromArgb(30, 30, 30);
            txtType.ForeColor = Color.FromArgb(230, 230, 230);
            txtType.Location = new Point(117, 114);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.ScrollBars = ScrollBars.Vertical;
            txtType.Size = new Size(316, 28);
            txtType.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.ForeColor = Color.FromArgb(230, 230, 230);
            txtName.Location = new Point(117, 151);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ScrollBars = ScrollBars.Vertical;
            txtName.Size = new Size(316, 28);
            txtName.TabIndex = 12;
            // 
            // txtGoal
            // 
            txtGoal.BackColor = Color.FromArgb(30, 30, 30);
            txtGoal.ForeColor = Color.FromArgb(230, 230, 230);
            txtGoal.Location = new Point(117, 188);
            txtGoal.Multiline = true;
            txtGoal.Name = "txtGoal";
            txtGoal.ScrollBars = ScrollBars.Vertical;
            txtGoal.Size = new Size(316, 28);
            txtGoal.TabIndex = 12;
            // 
            // txtDetails
            // 
            txtDetails.BackColor = Color.FromArgb(30, 30, 30);
            txtDetails.ForeColor = Color.FromArgb(230, 230, 230);
            txtDetails.Location = new Point(117, 225);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(316, 28);
            txtDetails.TabIndex = 12;
            // 
            // txtAppearance
            // 
            txtAppearance.BackColor = Color.FromArgb(30, 30, 30);
            txtAppearance.ForeColor = Color.FromArgb(230, 230, 230);
            txtAppearance.Location = new Point(117, 262);
            txtAppearance.Multiline = true;
            txtAppearance.Name = "txtAppearance";
            txtAppearance.ScrollBars = ScrollBars.Vertical;
            txtAppearance.Size = new Size(316, 28);
            txtAppearance.TabIndex = 12;
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.FromArgb(30, 30, 30);
            txtScore.ForeColor = Color.FromArgb(230, 230, 230);
            txtScore.Location = new Point(117, 299);
            txtScore.Multiline = true;
            txtScore.Name = "txtScore";
            txtScore.ScrollBars = ScrollBars.Vertical;
            txtScore.Size = new Size(316, 28);
            txtScore.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(30, 30, 30);
            txtPrice.ForeColor = Color.FromArgb(230, 230, 230);
            txtPrice.Location = new Point(117, 336);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.ScrollBars = ScrollBars.Vertical;
            txtPrice.Size = new Size(316, 28);
            txtPrice.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnOk);
            panel1.Location = new Point(14, 527);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 48);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(261, 10);
            button2.Name = "button2";
            button2.Size = new Size(199, 29);
            button2.TabIndex = 0;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(30, 30, 30);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(10, 10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(199, 29);
            btnOk.TabIndex = 0;
            btnOk.Text = "ОК";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // RobotEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(501, 587);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(230, 230, 230);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RobotEditForm";
            Text = "RobotEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblId;
        private Label lblNumber;
        private Label lblSeries;
        private Label lblType;
        private Label lblName;
        private Label lblGoal;
        private Label lblDetails;
        private Label lblAppearance;
        private Label lblScore;
        private Label lblPrice;
        private Label lblCriteria;
        private CheckedListBox checkedListCriteria;
        private TextBox txtId;
        private TextBox txtNumber;
        private TextBox txtSeries;
        private TextBox txtType;
        private TextBox txtName;
        private TextBox txtGoal;
        private TextBox txtDetails;
        private TextBox txtAppearance;
        private TextBox txtScore;
        private TextBox txtPrice;
        private Panel panel1;
        private Button btnOk;
        private Button button2;
    }
}