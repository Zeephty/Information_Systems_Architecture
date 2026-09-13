using Model;

namespace WinForms
{
    /// <summary>
    /// Окно создания или редактирования робота.
    /// Заполняет поля формы и возвращает готовый объект Robot.
    /// </summary>
    public partial class RobotEditForm : Form
    {
        /// <summary>
        /// Результат редактирования. Заполняется при нажатии кнопки «OK».
        /// </summary>
        public Robot Result { get; private set; } = new Robot();

        /// <summary>
        /// Создаёт окно редактирования.
        /// </summary>
        /// <param name="existing">Существующий робот для редактирования или null для создания нового.</param>
        public RobotEditForm(Robot? existing)
        {
            InitializeComponent();

            // Заполняем CheckedListBox критериями
            checkedListCriteria.Items.Clear();
            foreach (var kv in CriteriaLegend.Legend)
                checkedListCriteria.Items.Add($"{kv.Key}: {kv.Value}");

            if (existing != null)
            {
                Text = "Редактирование";
                txtId.Text = existing.Id;
                txtId.ReadOnly = true;
                txtNumber.Text = existing.Number.ToString();
                txtSeries.Text = existing.Series;
                txtType.Text = existing.Type;
                txtName.Text = existing.Name;
                txtGoal.Text = existing.Goal;
                txtDetails.Text = existing.Details;
                txtAppearance.Text = existing.Appearance;
                txtScore.Text = existing.Score.ToString();
                txtPrice.Text = existing.PriceRub.ToString();

                // Отмечаем нужные критерии
                for (int i = 0; i < CriteriaLegend.Legend.Count; i++)
                {
                    int code = i + 1;
                    if (existing.CriteriaCodes.Contains(code))
                        checkedListCriteria.SetItemChecked(i, true);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result = new Robot
            {
                Id = txtId.Text.Trim(),
                Number = int.TryParse(txtNumber.Text, out var n) ? n : 0,
                Series = txtSeries.Text.Trim(),
                Type = txtType.Text.Trim(),
                Name = txtName.Text.Trim(),
                Goal = txtGoal.Text.Trim(),
                Details = txtDetails.Text.Trim(),
                Appearance = txtAppearance.Text.Trim(),
                Score = int.TryParse(txtScore.Text, out var s) ? s : 0,
                PriceRub = decimal.TryParse(txtPrice.Text, out var p) ? p : 0,
                CriteriaCodes = checkedListCriteria.CheckedIndices.Cast<int>().Select(i => i + 1).ToList()
            };
        }
    }
}
