using Model;

namespace WinForms
{
    /// <summary>
    /// Окно создания робота
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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название робота.", "Ошибка");
                return;
            }

            if (!int.TryParse(txtNumber.Text, out var number))
            {
                MessageBox.Show("Номер должен быть числом.", "Ошибка");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out var price))
            {
                MessageBox.Show("Цена должна быть числом.", "Ошибка");
                return;
            }

            var codes = new List<int>();
            for (int i = 0; i < checkedListCriteria.Items.Count; i++)
            {
                if (checkedListCriteria.GetItemChecked(i))
                    codes.Add(i + 1);
            }

            Result = new Robot
            {
                Id = 0,
                Number = number,
                Series = txtSeries.Text.Trim(),
                Type = txtType.Text.Trim(),
                Name = txtName.Text.Trim(),
                Goal = txtGoal.Text.Trim(),
                Details = txtDetails.Text.Trim(),
                Appearance = txtAppearance.Text.Trim(),
                CriteriaCodes = codes,
                PriceRub = price
            };

            DialogResult = DialogResult.OK;
        }
    }
}
