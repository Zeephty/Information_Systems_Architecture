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
    /// Модальное окно редактирования одного строкового значения.
    /// </summary>
    public partial class PropertyEditDialog : Form
    {
        /// <summary> Введённое значение. </summary>
        public string Value => txtValue.Text;

        /// <summary>
        /// Окно редактирования одного строкового значения
        /// </summary>
        /// <param name="title"> Тип изменения </param>
        /// <param name="initialValue"> Значение этого типа </param>
        public PropertyEditDialog(string title, string initialValue)
        {
            InitializeComponent();
            Text = title + ":";
            lblPrompt.Text = initialValue ?? "";
            txtValue.SelectAll();
            txtValue.Focus();
        }
    }
}
