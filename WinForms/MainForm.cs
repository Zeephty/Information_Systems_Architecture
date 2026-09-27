using Model;

namespace WinForms
{
    /// <summary>
    /// Главное окно приложения. Отображает список роботов,
    /// предоставляет кнопки CRUD-операций и бизнес-функций.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Экземпляр бизнес-логики приложения. </summary>
        private readonly Logic logic = new Logic();

        /// <summary>
        /// Инициализирует главное окно, загружает данные из файла и заполняет список роботов.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            logic.Load();
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxRobots.Items.Clear();
            foreach (var r in logic.GetAll())
            {
                listBoxRobots.Items.Add(r.ToString());
            }
        }

        private Robot? GetSelected()
        {
            if (listBoxRobots.SelectedIndex < 0) 
            {
                MessageBox.Show("Выберите робота.", "Внимание");
                return null;
            }

            var text = listBoxRobots.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            string idStr = text.Split('|')[0].Trim();
            return int.TryParse(idStr, out int id) ? logic.GetById(id) : null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new RobotEditForm(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    logic.Add(form.Result);
                    RefreshList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null)
            {
                return;
            } 

            var form = new RobotEditorForm(logic, selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) 
            { 
                return; 
            }

            if (MessageBox.Show($"Удалить {selected.Name}?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                logic.Delete(selected.Id);
                RefreshList();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) 
            { 
                return; 
            }
            new RobotDetailsForm(selected).ShowDialog();
        }

        private void btnGroupByType_Click(object sender, EventArgs e)
        {
            var groups = logic.GroupByType();

            if (groups.Count == 0)
            {
                MessageBox.Show("Список пуст.", "Группировка по типу");
                return;
            }

            var text = string.Join("\n\n", groups.Select(g => $"[{g.Key}] ({g.Value.Count}):\n" +
                string.Join("\n", g.Value.Select(r => "  " + r.Name))));

            new TextDisplayForm("Группировка по типу", text).ShowDialog();
        }

        private void btnAvgPrice_Click(object sender, EventArgs e)
        {
            var stats = logic.AveragePriceBySeries();

            if (stats.Count == 0)
            {
                MessageBox.Show("Список пуст.", "Средняя цена по серии");
                return;
            }

            var text = string.Join("\n", stats.Select(kv => $"{kv.Key}: {kv.Value:N0} ₽"));

            new TextDisplayForm("Средняя цена по серии", text).ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logic.Save();
        }
    }
}
