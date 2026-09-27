namespace WinForms
{
    partial class RobotEditorForm
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
            button2 = new Button();
            panel1 = new Panel();
            btnOk = new Button();
            lblId = new Label();
            lblNumber = new Label();
            lblSeries = new Label();
            lblType = new Label();
            lblName = new Label();
            lblGoal = new Label();
            lblDetails = new Label();
            lblAppearance = new Label();
            lblPrice = new Label();
            lblCriteria = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkedListCriteria = new CheckedListBox();
            rtxtIdValue = new RichTextBox();
            rtxtNumberValue = new RichTextBox();
            rtxtSeriesValue = new RichTextBox();
            rtxtTypeValue = new RichTextBox();
            rtxtNameValue = new RichTextBox();
            rtxtGoalValue = new RichTextBox();
            rtxtDetailsValue = new RichTextBox();
            rtxtAppearanceValue = new RichTextBox();
            rtxtPriceValue = new RichTextBox();
            btnNumber = new Button();
            btnSeries = new Button();
            btnType = new Button();
            btnName = new Button();
            btnGoal = new Button();
            btnDetails = new Button();
            btnAppearance = new Button();
            btnPrice = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.DialogResult = DialogResult.Cancel;
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(284, 0);
            button2.Name = "button2";
            button2.Size = new Size(199, 48);
            button2.TabIndex = 0;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 424);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 48);
            panel1.TabIndex = 3;
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
            lblNumber.Location = new Point(3, 33);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(64, 21);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Номер:";
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Location = new Point(3, 66);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(62, 21);
            lblSeries.TabIndex = 2;
            lblSeries.Text = "Серия:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(3, 99);
            lblType.Name = "lblType";
            lblType.Size = new Size(41, 21);
            lblType.TabIndex = 3;
            lblType.Text = "Тип:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 132);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Название:";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(3, 165);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(54, 21);
            lblGoal.TabIndex = 5;
            lblGoal.Text = "Цель:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(3, 198);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(72, 21);
            lblDetails.TabIndex = 6;
            lblDetails.Text = "Детали:";
            // 
            // lblAppearance
            // 
            lblAppearance.AutoSize = true;
            lblAppearance.Location = new Point(3, 231);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(101, 21);
            lblAppearance.TabIndex = 7;
            lblAppearance.Text = "Внешность:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 264);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(82, 21);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Цена (₽):";
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Location = new Point(3, 297);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(90, 42);
            lblCriteria.TabIndex = 10;
            lblCriteria.Text = "Критерии (Оценка):";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2038174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.79617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(checkedListCriteria, 1, 9);
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNumber, 0, 1);
            tableLayoutPanel1.Controls.Add(lblSeries, 0, 2);
            tableLayoutPanel1.Controls.Add(lblType, 0, 3);
            tableLayoutPanel1.Controls.Add(lblName, 0, 4);
            tableLayoutPanel1.Controls.Add(lblGoal, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDetails, 0, 6);
            tableLayoutPanel1.Controls.Add(lblAppearance, 0, 7);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 8);
            tableLayoutPanel1.Controls.Add(lblCriteria, 0, 9);
            tableLayoutPanel1.Controls.Add(rtxtIdValue, 1, 0);
            tableLayoutPanel1.Controls.Add(rtxtNumberValue, 1, 1);
            tableLayoutPanel1.Controls.Add(rtxtSeriesValue, 1, 2);
            tableLayoutPanel1.Controls.Add(rtxtTypeValue, 1, 3);
            tableLayoutPanel1.Controls.Add(rtxtNameValue, 1, 4);
            tableLayoutPanel1.Controls.Add(rtxtGoalValue, 1, 5);
            tableLayoutPanel1.Controls.Add(rtxtDetailsValue, 1, 6);
            tableLayoutPanel1.Controls.Add(rtxtAppearanceValue, 1, 7);
            tableLayoutPanel1.Controls.Add(rtxtPriceValue, 1, 8);
            tableLayoutPanel1.Controls.Add(btnNumber, 2, 1);
            tableLayoutPanel1.Controls.Add(btnSeries, 2, 2);
            tableLayoutPanel1.Controls.Add(btnType, 2, 3);
            tableLayoutPanel1.Controls.Add(btnName, 2, 4);
            tableLayoutPanel1.Controls.Add(btnGoal, 2, 5);
            tableLayoutPanel1.Controls.Add(btnDetails, 2, 6);
            tableLayoutPanel1.Controls.Add(btnAppearance, 2, 7);
            tableLayoutPanel1.Controls.Add(btnPrice, 2, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Size = new Size(483, 424);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // checkedListCriteria
            // 
            checkedListCriteria.BackColor = Color.FromArgb(30, 30, 30);
            checkedListCriteria.Dock = DockStyle.Fill;
            checkedListCriteria.ForeColor = Color.FromArgb(230, 230, 230);
            checkedListCriteria.FormattingEnabled = true;
            checkedListCriteria.Items.AddRange(new object[] { "1. За продвинутый ИИ", "2. За отличную манёвренность", "3. За высокую огневую мощь", "4. За прочную защиту", "5. За автономность", "6. За адаптивность", "7. За эффективность в роли", "8. За надёжность", "9. За универсальность", "10. За инновационность" });
            checkedListCriteria.Location = new Point(110, 300);
            checkedListCriteria.Name = "checkedListCriteria";
            checkedListCriteria.Size = new Size(329, 121);
            checkedListCriteria.TabIndex = 16;
            checkedListCriteria.ItemCheck += checkedListCriteria_ItemCheck;
            // 
            // rtxtIdValue
            // 
            rtxtIdValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtIdValue.Cursor = Cursors.IBeam;
            rtxtIdValue.Dock = DockStyle.Fill;
            rtxtIdValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtIdValue.Location = new Point(110, 3);
            rtxtIdValue.Name = "rtxtIdValue";
            rtxtIdValue.ReadOnly = true;
            rtxtIdValue.Size = new Size(329, 27);
            rtxtIdValue.TabIndex = 11;
            rtxtIdValue.TabStop = false;
            rtxtIdValue.Text = "";
            // 
            // rtxtNumberValue
            // 
            rtxtNumberValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtNumberValue.Cursor = Cursors.IBeam;
            rtxtNumberValue.Dock = DockStyle.Fill;
            rtxtNumberValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtNumberValue.Location = new Point(110, 36);
            rtxtNumberValue.Name = "rtxtNumberValue";
            rtxtNumberValue.ReadOnly = true;
            rtxtNumberValue.Size = new Size(329, 27);
            rtxtNumberValue.TabIndex = 12;
            rtxtNumberValue.TabStop = false;
            rtxtNumberValue.Text = "";
            // 
            // rtxtSeriesValue
            // 
            rtxtSeriesValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtSeriesValue.Cursor = Cursors.IBeam;
            rtxtSeriesValue.Dock = DockStyle.Fill;
            rtxtSeriesValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtSeriesValue.Location = new Point(110, 69);
            rtxtSeriesValue.Name = "rtxtSeriesValue";
            rtxtSeriesValue.ReadOnly = true;
            rtxtSeriesValue.Size = new Size(329, 27);
            rtxtSeriesValue.TabIndex = 13;
            rtxtSeriesValue.TabStop = false;
            rtxtSeriesValue.Text = "";
            // 
            // rtxtTypeValue
            // 
            rtxtTypeValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtTypeValue.Cursor = Cursors.IBeam;
            rtxtTypeValue.Dock = DockStyle.Fill;
            rtxtTypeValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtTypeValue.Location = new Point(110, 102);
            rtxtTypeValue.Name = "rtxtTypeValue";
            rtxtTypeValue.ReadOnly = true;
            rtxtTypeValue.Size = new Size(329, 27);
            rtxtTypeValue.TabIndex = 13;
            rtxtTypeValue.TabStop = false;
            rtxtTypeValue.Text = "";
            // 
            // rtxtNameValue
            // 
            rtxtNameValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtNameValue.Cursor = Cursors.IBeam;
            rtxtNameValue.Dock = DockStyle.Fill;
            rtxtNameValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtNameValue.Location = new Point(110, 135);
            rtxtNameValue.Name = "rtxtNameValue";
            rtxtNameValue.ReadOnly = true;
            rtxtNameValue.Size = new Size(329, 27);
            rtxtNameValue.TabIndex = 13;
            rtxtNameValue.TabStop = false;
            rtxtNameValue.Text = "";
            // 
            // rtxtGoalValue
            // 
            rtxtGoalValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtGoalValue.Cursor = Cursors.IBeam;
            rtxtGoalValue.Dock = DockStyle.Fill;
            rtxtGoalValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtGoalValue.Location = new Point(110, 168);
            rtxtGoalValue.Name = "rtxtGoalValue";
            rtxtGoalValue.ReadOnly = true;
            rtxtGoalValue.Size = new Size(329, 27);
            rtxtGoalValue.TabIndex = 13;
            rtxtGoalValue.TabStop = false;
            rtxtGoalValue.Text = "";
            // 
            // rtxtDetailsValue
            // 
            rtxtDetailsValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtDetailsValue.Cursor = Cursors.IBeam;
            rtxtDetailsValue.Dock = DockStyle.Fill;
            rtxtDetailsValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtDetailsValue.Location = new Point(110, 201);
            rtxtDetailsValue.Name = "rtxtDetailsValue";
            rtxtDetailsValue.ReadOnly = true;
            rtxtDetailsValue.Size = new Size(329, 27);
            rtxtDetailsValue.TabIndex = 13;
            rtxtDetailsValue.TabStop = false;
            rtxtDetailsValue.Text = "";
            // 
            // rtxtAppearanceValue
            // 
            rtxtAppearanceValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtAppearanceValue.Cursor = Cursors.IBeam;
            rtxtAppearanceValue.Dock = DockStyle.Fill;
            rtxtAppearanceValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtAppearanceValue.Location = new Point(110, 234);
            rtxtAppearanceValue.Name = "rtxtAppearanceValue";
            rtxtAppearanceValue.ReadOnly = true;
            rtxtAppearanceValue.Size = new Size(329, 27);
            rtxtAppearanceValue.TabIndex = 13;
            rtxtAppearanceValue.TabStop = false;
            rtxtAppearanceValue.Text = "";
            // 
            // rtxtPriceValue
            // 
            rtxtPriceValue.BackColor = Color.FromArgb(30, 30, 30);
            rtxtPriceValue.Cursor = Cursors.IBeam;
            rtxtPriceValue.Dock = DockStyle.Fill;
            rtxtPriceValue.ForeColor = Color.FromArgb(230, 230, 230);
            rtxtPriceValue.Location = new Point(110, 267);
            rtxtPriceValue.Name = "rtxtPriceValue";
            rtxtPriceValue.ReadOnly = true;
            rtxtPriceValue.Size = new Size(329, 27);
            rtxtPriceValue.TabIndex = 13;
            rtxtPriceValue.TabStop = false;
            rtxtPriceValue.Text = "";
            // 
            // btnNumber
            // 
            btnNumber.BackColor = Color.FromArgb(30, 30, 30);
            btnNumber.Location = new Point(445, 36);
            btnNumber.Name = "btnNumber";
            btnNumber.Size = new Size(27, 27);
            btnNumber.TabIndex = 14;
            btnNumber.Text = "✎";
            btnNumber.UseVisualStyleBackColor = false;
            btnNumber.Click += btnNumber_Click;
            // 
            // btnSeries
            // 
            btnSeries.BackColor = Color.FromArgb(30, 30, 30);
            btnSeries.Location = new Point(445, 69);
            btnSeries.Name = "btnSeries";
            btnSeries.Size = new Size(27, 27);
            btnSeries.TabIndex = 14;
            btnSeries.Text = "✎";
            btnSeries.UseVisualStyleBackColor = false;
            btnSeries.Click += btnSeries_Click;
            // 
            // btnType
            // 
            btnType.BackColor = Color.FromArgb(30, 30, 30);
            btnType.Location = new Point(445, 102);
            btnType.Name = "btnType";
            btnType.Size = new Size(27, 27);
            btnType.TabIndex = 14;
            btnType.Text = "✎";
            btnType.UseVisualStyleBackColor = false;
            btnType.Click += btnType_Click;
            // 
            // btnName
            // 
            btnName.BackColor = Color.FromArgb(30, 30, 30);
            btnName.Location = new Point(445, 135);
            btnName.Name = "btnName";
            btnName.Size = new Size(27, 27);
            btnName.TabIndex = 14;
            btnName.Text = "✎";
            btnName.UseVisualStyleBackColor = false;
            btnName.Click += btnName_Click;
            // 
            // btnGoal
            // 
            btnGoal.BackColor = Color.FromArgb(30, 30, 30);
            btnGoal.Location = new Point(445, 168);
            btnGoal.Name = "btnGoal";
            btnGoal.Size = new Size(27, 27);
            btnGoal.TabIndex = 14;
            btnGoal.Text = "✎";
            btnGoal.UseVisualStyleBackColor = false;
            btnGoal.Click += btnGoal_Click;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.FromArgb(30, 30, 30);
            btnDetails.Location = new Point(445, 201);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(27, 27);
            btnDetails.TabIndex = 14;
            btnDetails.Text = "✎";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnAppearance
            // 
            btnAppearance.BackColor = Color.FromArgb(30, 30, 30);
            btnAppearance.Location = new Point(445, 234);
            btnAppearance.Name = "btnAppearance";
            btnAppearance.Size = new Size(27, 27);
            btnAppearance.TabIndex = 14;
            btnAppearance.Text = "✎";
            btnAppearance.UseVisualStyleBackColor = false;
            btnAppearance.Click += btnAppearance_Click;
            // 
            // btnPrice
            // 
            btnPrice.BackColor = Color.FromArgb(30, 30, 30);
            btnPrice.Location = new Point(445, 267);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(27, 27);
            btnPrice.TabIndex = 14;
            btnPrice.Text = "✎";
            btnPrice.UseVisualStyleBackColor = false;
            btnPrice.Click += btnPrice_Click;
            // 
            // RobotEditorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(483, 472);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(230, 230, 230);
            Name = "RobotEditorForm";
            Text = "RobotEditorForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Panel panel1;
        private Button btnOk;
        private Label lblId;
        private Label lblNumber;
        private Label lblSeries;
        private Label lblType;
        private Label lblName;
        private Label lblGoal;
        private Label lblDetails;
        private Label lblAppearance;
        private Label lblPrice;
        private Label lblCriteria;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rtxtIdValue;
        private RichTextBox rtxtNumberValue;
        private RichTextBox rtxtSeriesValue;
        private RichTextBox rtxtTypeValue;
        private RichTextBox rtxtNameValue;
        private RichTextBox rtxtGoalValue;
        private RichTextBox rtxtDetailsValue;
        private RichTextBox rtxtAppearanceValue;
        private RichTextBox rtxtPriceValue;
        private Button btnNumber;
        private Button btnSeries;
        private Button btnType;
        private Button btnName;
        private Button btnGoal;
        private Button btnDetails;
        private Button btnAppearance;
        private Button btnPrice;
        private CheckedListBox checkedListCriteria;
    }
}