namespace WinForms
{
    /// <summary>
    /// Универсальное окно для показа длинного текста с прокруткой.
    /// Используется вместо MessageBox, когда текст не помещается.
    /// </summary>
    public partial class TextDisplayForm : Form
    {
        /// <summary>
        /// Создаёт окно с указанным заголовком и текстом.
        /// </summary>
        /// <param name="title"> Заголовок окна. </param>
        /// <param name="content"> Текст для отображения. </param>
        public TextDisplayForm(string title, string content)
        {
            InitializeComponent();

            Text = title;
            richTextBoxText.Text = content;
        }
    }
}
