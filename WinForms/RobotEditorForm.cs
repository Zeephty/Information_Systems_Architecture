using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLogic;

namespace WinForms
{
    /// <summary>
    /// Окно редактирования робота
    /// </summary>
    public partial class RobotEditorForm : Form
    {
        private readonly Logic logic;
        private readonly int robotId;
        private Robot draft;

        private bool suppressCriteriaCheck;

        /// <summary>
        /// Окно редактирования робота
        /// </summary>
        /// <param name="logic"> Логика </param>
        /// <param name="source"> Выбранный робот </param>
        /// <exception cref="ArgumentNullException"></exception>
        public RobotEditorForm(Logic logic, Robot source)
        {
            InitializeComponent();

            this.logic = logic ?? throw new ArgumentNullException(nameof(logic));
            this.robotId = source.Id;
            this.draft = source.Clone();

            Text = $"Редактирование робота #{source.Id} — {source.Name}";
            rtxtIdValue.Text = source.Id.ToString();

            checkedListCriteria.Items.Clear();
            foreach (var kv in CriteriaLegend.Legend)
            {
                checkedListCriteria.Items.Add($"{kv.Key}: {kv.Value}");
            }

            RefreshFromLogic();
        }

        private void RefreshFromLogic()
        {
            rtxtNumberValue.Text = draft.Number.ToString();
            rtxtSeriesValue.Text = draft.Series;
            rtxtTypeValue.Text = draft.Type;
            rtxtNameValue.Text = draft.Name;
            rtxtGoalValue.Text = draft.Goal;
            rtxtDetailsValue.Text = draft.Details;
            rtxtAppearanceValue.Text = draft.Appearance;

            suppressCriteriaCheck = true;
            int i = 0;
            foreach (var kv in CriteriaLegend.Legend)
            {
                checkedListCriteria.SetItemChecked(i, draft.CriteriaCodes.Contains(kv.Key));
                i++;
            }
            suppressCriteriaCheck = false;

            rtxtPriceValue.Text = $"{draft.PriceRub:N0} руб.";
        }

        private void EditText(string title, Func<Robot, string> getter, Action<Robot, string> setter)
        {
            var dlg = new PropertyEditDialog(title, getter(draft));
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            setter(draft, dlg.Value);
            RefreshFromLogic();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            var dlg = new PropertyEditDialog("Номер", draft.Number.ToString());
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            if (!int.TryParse(dlg.Value, out var n) || n < 0)
            {
                MessageBox.Show(this, "Номер должен быть целым неотрицательным числом.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            draft.Number = n;
            RefreshFromLogic();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            EditText("Серия", r => r.Series, (r, v) => r.Series = v);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            EditText("Тип", r => r.Type, (r, v) => r.Type = v);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            EditText("Название", r => r.Name, (r, v) => r.Name = v);
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            EditText("Цель", r => r.Goal, (r, v) => r.Goal = v);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            EditText("Детали", r => r.Details, (r, v) => r.Details = v);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            EditText("Внешность", r => r.Appearance, (r, v) => r.Appearance = v);
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            var dlg = new PropertyEditDialog("Цена (руб.)", draft.PriceRub.ToString());
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            if (!decimal.TryParse(dlg.Value, out var p) || p < 0)
            {
                MessageBox.Show(this, "Цена должна быть неотрицательным числом.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            draft.PriceRub = p;
            RefreshFromLogic();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(draft.Name))
            {
                MessageBox.Show(this, "Название робота не может быть пустым.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            draft.Id = robotId;
            logic.Update(draft);

            DialogResult = DialogResult.OK;
        }

        private void checkedListCriteria_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (suppressCriteriaCheck)
            {
                return;
            }

            var codes = new List<int>();
            for (int i = 0; i < checkedListCriteria.Items.Count; i++)
            {
                bool isChecked = (i == e.Index)
                    ? (e.NewValue == CheckState.Checked)
                    : checkedListCriteria.GetItemChecked(i);

                if (isChecked) codes.Add(i + 1);
            }

            draft.CriteriaCodes = codes;
        }
    }
}