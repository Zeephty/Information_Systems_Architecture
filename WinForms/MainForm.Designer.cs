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
            panel1 = new Panel();
            lblSource = new Label();
            btnChangeSource = new Button();
            panelButtons.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxRobots
            // 
            listBoxRobots.BackColor = Color.FromArgb(38, 38, 38);
            listBoxRobots.Dock = DockStyle.Fill;
            listBoxRobots.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold);
            listBoxRobots.ForeColor = Color.FromArgb(230, 230, 230);
            listBoxRobots.FormattingEnabled = true;
            listBoxRobots.HorizontalScrollbar = true;
            listBoxRobots.Location = new Point(0, 0);
            listBoxRobots.Name = "listBoxRobots";
            listBoxRobots.Size = new Size(778, 399);
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
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(778, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(222, 399);
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
            // panel1
            // 
            panel1.Controls.Add(btnChangeSource);
            panel1.Controls.Add(lblSource);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 399);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 51);
            panel1.TabIndex = 2;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSource.ForeColor = Color.FromArgb(230, 230, 230);
            lblSource.Location = new Point(12, 13);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(97, 24);
            lblSource.TabIndex = 0;
            lblSource.Text = "Источник";
            // 
            // btnChangeSource
            // 
            btnChangeSource.BackColor = Color.FromArgb(38, 38, 38);
            btnChangeSource.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnChangeSource.ForeColor = Color.FromArgb(230, 230, 230);
            btnChangeSource.Location = new Point(801, 0);
            btnChangeSource.Name = "btnChangeSource";
            btnChangeSource.Size = new Size(177, 41);
            btnChangeSource.TabIndex = 1;
            btnChangeSource.Text = "Сменить источник";
            btnChangeSource.UseVisualStyleBackColor = false;
            btnChangeSource.Click += btnChangeSource_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 450);
            Controls.Add(listBoxRobots);
            Controls.Add(panelButtons);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Роботы";
            panelButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label lblSource;
        private Button btnChangeSource;
    }
}
