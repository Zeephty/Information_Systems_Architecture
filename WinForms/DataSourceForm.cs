using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    /// <summary>
    /// Форма выбора источника
    /// </summary>
    public partial class DataSourceForm : Form
    {
        /// <summary>
        /// Выбранный пользователем источник. Заполняется при OK
        /// </summary>
        public DataSourceKind Selected { get; private set; }

        /// <summary>
        /// Создание формы с выбором источника
        /// </summary>
        public DataSourceForm(DataSourceKind current)
        {
            InitializeComponent();

            if (current == DataSourceKind.Json)
            {
                rbJson.Checked = true;
            }
            else if (current == DataSourceKind.Dapper)
            {
                rbDapper.Checked = true;
            }
            else if (current == DataSourceKind.EntityFramework)
            {
                rbEf.Checked = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbJson.Checked)
            {
                Selected = DataSourceKind.Json;
            }
            else if (rbDapper.Checked)
            {
                Selected = DataSourceKind.Dapper;
            }
            else
            {
                Selected = DataSourceKind.EntityFramework;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
