using Shared;

namespace WinForms
{
    /// <summary>
    /// Реализация представления WinForms (View)
    /// </summary>
    public partial class MainForm : Form, IView
    {
        /// <summary>
        /// Добавить робота
        /// </summary>
        public event Action<RobotDTO>? AddRobotRequested;

        /// <summary>
        /// Редактировать робота
        /// </summary>
        public event Action<RobotDTO>? UpdateRobotRequested;

        /// <summary>
        /// Удалить робота
        /// </summary>
        public event Action<int>? DeleteRobotRequested;

        /// <summary>
        /// Найти робота
        /// </summary>
        public event Action<int>? FindRobotRequested;

        /// <summary>
        /// Обновить
        /// </summary>
        public event Action? RefreshRequested;

        /// <summary>
        /// Изменить источник
        /// </summary>
        public event Action<DataSourceKind>? ChangeSourceRequested;

        /// <summary>
        /// Сгруппировать
        /// </summary>
        public event Action? GroupByTypeRequested;

        /// <summary>
        /// Вычислить ср. значения
        /// </summary>
        public event Action? AveragePriceRequested;

        private List<RobotDTO> currentRobots = new List<RobotDTO>();

        private DataSourceKind currentKind = DataSourceKind.Json;

        /// <summary>
        /// Инициализирует главное окно, загружает данные из файла и заполняет список роботов.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            lblSource.Text = $"Источник: {currentKind}";
        }

        /// <summary>
        /// Показать роботов
        /// </summary>
        /// <param name="robots"> DTO робота </param>
        public void ShowRobots(IEnumerable<RobotDTO> robots)
        {
            currentRobots = robots.ToList();

            listBoxRobots.Items.Clear();
            foreach (var r in currentRobots)
            {
                listBoxRobots.Items.Add($"{r.Id} | {r.Series}-{r.Number} | {r.Name} | {r.Type} | {r.CriteriaCodes.Count}/10 | {r.PriceRub:N0} руб.");
            }
        }

        /// <summary>
        /// Показать ошибку
        /// </summary>
        /// <param name="message"> Сообщение о ошибке </param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Показать сообщение
        /// </summary>
        /// <param name="message"> Показ сообщения </param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Отобразить обновленный источник
        /// </summary>
        /// <param name="sourceName"> Новый источник </param>
        public void UpdateSourceLabel(string sourceName)
        {
            lblSource.Text = $"Источник: {sourceName}";

            if (Enum.TryParse<DataSourceKind>(sourceName, out var kind))
            {
                currentKind = kind;
            }
        }

        /// <summary>
        /// Подробнее посмореть сущность
        /// </summary>
        /// <param name="robot"> DTO робота </param>
        public void ShowDetails(RobotDTO robot)
        {
            new RobotDetailsForm(robot).ShowDialog();
        }

        /// <summary>
        /// Отрисовка группировки
        /// </summary>
        /// <param name="groups"> Словарь из сгруппированных элементов </param>
        public void ShowGrouping(Dictionary<string, List<RobotDTO>> groups)
        {
            if (groups.Count == 0)
            {
                MessageBox.Show("Список пуст.", "Группировка по типу");
                return;
            }

            var text = string.Join("\n\n", groups.Select(g => $"[{g.Key}] ({g.Value.Count}):\n" + string.Join("\n", g.Value.Select(r => "  " + r.Name))));
            new TextDisplayForm("Группировка по типу", text).ShowDialog();
        }

        /// <summary>
        /// Отрисовка ср. арифм
        /// </summary>
        /// <param name="stats"> Словарь ср. арифм </param>
        public void ShowAveragePrice(Dictionary<string, decimal> stats)
        {
            if (stats.Count == 0)
            {
                MessageBox.Show("Список пуст.", "Средняя цена по серии");
                return;
            }

            var text = string.Join("\n", stats.Select(kv => $"{kv.Key}: {kv.Value:N0} ₽"));
            new TextDisplayForm("Средняя цена", text).ShowDialog();
        }

        private RobotDTO? GetSelectedDTO()
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
            return int.TryParse(idStr, out int id) ? currentRobots.FirstOrDefault(r => r.Id == id) : null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new RobotEditForm(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddRobotRequested?.Invoke(form.Result);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedDTO();
            if (selected == null)
            {
                return;
            }

            var form = new RobotEditorForm(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateRobotRequested?.Invoke(form.Result);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedDTO();
            if (selected == null)
            {
                return;
            }

            if (MessageBox.Show($"Удалить {selected.Name}?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteRobotRequested?.Invoke(selected.Id);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedDTO();
            if (selected != null)
            {
                FindRobotRequested?.Invoke(selected.Id);
            }
        }

        private void btnGroupByType_Click(object sender, EventArgs e)
        {
            GroupByTypeRequested?.Invoke();
        }

        private void btnAvgPrice_Click(object sender, EventArgs e)
        {
            AveragePriceRequested?.Invoke();
        }

        private void btnChangeSource_Click(object sender, EventArgs e)
        {
            using var dlg = new DataSourceForm(currentKind);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                ChangeSourceRequested?.Invoke(dlg.Selected);
            }
        }
    }
}
