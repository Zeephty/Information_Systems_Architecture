namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxRobots = new ListBox();
            panelButtons = new Panel();
            btnAvgPrice = new Button();
            btnGroupByType = new Button();
            btnDetails = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxRobots
            // 
            listBoxRobots.BackColor = Color.FromArgb(38, 38, 38);
            listBoxRobots.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold);
            listBoxRobots.ForeColor = Color.FromArgb(230, 230, 230);
            listBoxRobots.FormattingEnabled = true;
            listBoxRobots.HorizontalScrollbar = true;
            listBoxRobots.Location = new Point(23, 24);
            listBoxRobots.Name = "listBoxRobots";
            listBoxRobots.Size = new Size(648, 403);
            listBoxRobots.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAvgPrice);
            panelButtons.Controls.Add(btnGroupByType);
            panelButtons.Controls.Add(btnDetails);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Location = new Point(677, 24);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(222, 403);
            panelButtons.TabIndex = 1;
            // 
            // btnAvgPrice
            // 
            btnAvgPrice.BackColor = Color.FromArgb(38, 38, 38);
            btnAvgPrice.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAvgPrice.ForeColor = Color.FromArgb(230, 230, 230);
            btnAvgPrice.Location = new Point(23, 301);
            btnAvgPrice.Name = "btnAvgPrice";
            btnAvgPrice.Size = new Size(177, 67);
            btnAvgPrice.TabIndex = 0;
            btnAvgPrice.Text = "Средняя цена по серии\t";
            btnAvgPrice.UseVisualStyleBackColor = false;
            btnAvgPrice.Click += btnAvgPrice_Click;
            // 
            // btnGroupByType
            // 
            btnGroupByType.BackColor = Color.FromArgb(38, 38, 38);
            btnGroupByType.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnGroupByType.ForeColor = Color.FromArgb(230, 230, 230);
            btnGroupByType.Location = new Point(23, 229);
            btnGroupByType.Name = "btnGroupByType";
            btnGroupByType.Size = new Size(177, 66);
            btnGroupByType.TabIndex = 0;
            btnGroupByType.Text = "Группировка по типу";
            btnGroupByType.UseVisualStyleBackColor = false;
            btnGroupByType.Click += btnGroupByType_Click;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.FromArgb(38, 38, 38);
            btnDetails.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDetails.ForeColor = Color.FromArgb(230, 230, 230);
            btnDetails.Location = new Point(23, 162);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(177, 40);
            btnDetails.TabIndex = 0;
            btnDetails.Text = "Подробнее";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(38, 38, 38);
            btnDelete.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.FromArgb(230, 230, 230);
            btnDelete.Location = new Point(23, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(38, 38, 38);
            btnEdit.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.ForeColor = Color.FromArgb(230, 230, 230);
            btnEdit.Location = new Point(23, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(177, 40);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(38, 38, 38);
            btnAdd.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.FromArgb(230, 230, 230);
            btnAdd.Location = new Point(23, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(911, 450);
            Controls.Add(panelButtons);
            Controls.Add(listBoxRobots);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Роботы";
            FormClosing += MainForm_FormClosing;
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxRobots;
        private Panel panelButtons;
        private Button btnAvgPrice;
        private Button btnGroupByType;
        private Button btnDetails;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}
