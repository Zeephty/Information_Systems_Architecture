using Model;

namespace WinForms
{
    /// <summary>
    /// Окно с подробной информацией о роботе.
    /// Отображает все поля сущности в режиме только для чтения.
    /// </summary>
    public partial class RobotDetailsForm : Form
    {
        /// <summary>
        /// Создаёт окно c описанием для указанного робота.
        /// </summary>
        /// <param name="robot"> Робот, чьи данные нужно отобразить. </param>
        public RobotDetailsForm(Robot robot)
        {
            InitializeComponent();

            Text = $"Детали: {robot.Name}";

            richTextBoxDetails.Text =
                $"ID: {robot.Id}\n" +
                $"Номер: {robot.Number}\n" +
                $"Серия: {robot.Series}\n" +
                $"Тип: {robot.Type}\n" +
                $"Название: {robot.Name}\n\n" +
                $"Цель: {robot.Goal}\n\n" +
                $"Детали: {robot.Details}\n\n" +
                $"Внешность: {robot.Appearance}\n\n" +
                $"Оценка: {robot.Score}/10\n" +
                $"Критерии:\n{CriteriaLegend.Describe(robot.CriteriaCodes)}\n\n" +
                $"Цена: {robot.PriceRub:N0} ₽";
        }
    }
}
