using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /// <summary>
    /// Консольное представление Console (View)
    /// </summary>
    public class ConsoleView : IView
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
        /// Показать роботов
        /// </summary>
        /// <param name="robots"> DTO робота </param>
        public void ShowRobots(IEnumerable<RobotDTO> robots)
        {
            currentRobots = robots.ToList();
            Console.WriteLine("\n=== СПИСОК РОБОТОВ ===");
            if (currentRobots.Count == 0)
            {
                Console.WriteLine("  (пусто)");
                return;
            }
            foreach (var r in currentRobots)
            {
                Console.WriteLine($"  {r.Id} | {r.Series}-{r.Number} | {r.Name} | {r.Type} | {r.CriteriaCodes.Count}/10 | {r.PriceRub:N0} руб.");
            }
        }

        /// <summary>
        /// Ошибка
        /// </summary>
        /// <param name="message"> Сообщение о ошибке </param>
        public void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ОШИБКА] {message}");
            Console.ResetColor();
            Pause();
        }

        /// <summary>
        /// Сообщение
        /// </summary>
        /// <param name="message"> Показ сообщения </param>
        public void ShowMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[OK] {message}");
            Console.ResetColor();
        }

        /// <summary>
        /// Обновление источника
        /// </summary>
        /// <param name="sourceName"> Новый источник </param>
        public void UpdateSourceLabel(string sourceName)
        {
            if (Enum.TryParse<DataSourceKind>(sourceName, out var kind))
            {
                currentKind = kind;
            }
            Console.WriteLine($"[ИНФО] Текущий источник: {sourceName}");
        }

        /// <summary>
        /// Подробнее посмореть сущность
        /// </summary>
        /// <param name="robot"> DTO робота </param>
        public void ShowDetails(RobotDTO robot)
        {
            Console.WriteLine($"\n--- ДЕТАЛИ РОБОТА ---");
            Console.WriteLine($"ID:         {robot.Id}");
            Console.WriteLine($"Номер:      {robot.Number}");
            Console.WriteLine($"Серия:      {robot.Series}");
            Console.WriteLine($"Тип:        {robot.Type}");
            Console.WriteLine($"Название:   {robot.Name}");
            Console.WriteLine($"Цель:       {robot.Goal}");
            Console.WriteLine($"Детали:     {robot.Details}");
            Console.WriteLine($"Внешность:  {robot.Appearance}");
            Console.WriteLine($"Оценка:     {robot.CriteriaCodes.Count}/{CriteriaLegend.Legend.Count}");
            Console.WriteLine($"Критерии:   {CriteriaLegend.Describe(robot.CriteriaCodes)}");
            Console.WriteLine($"Цена:       {robot.PriceRub:N0} руб.");
            Pause();
        }

        /// <summary>
        /// Отрисовка группировки
        /// </summary>
        /// <param name="groups"> Словарь из сгруппированных элементов </param>
        public void ShowGrouping(Dictionary<string, List<RobotDTO>> groups)
        {
            Console.WriteLine("\n=== ГРУППИРОВКА ПО ТИПУ ===");
            if (groups.Count == 0)
            {
                Console.WriteLine("  (пусто)");
            }
            else
            {
                foreach (var g in groups)
                {
                    Console.WriteLine($"  [{g.Key}] ({g.Value.Count}):");
                    foreach (var r in g.Value)
                    {
                        Console.WriteLine($"    - {r.Name}");
                    }
                }
            }
            Pause();
        }

        /// <summary>
        /// Отрисовка ср. арифм
        /// </summary>
        /// <param name="stats"> Словарь ср. арифм </param>
        public void ShowAveragePrice(Dictionary<string, decimal> stats)
        {
            Console.WriteLine("\n=== СРЕДНЯЯ ЦЕНА ПО СЕРИИ ===");
            if (stats.Count == 0)
            {
                Console.WriteLine("  (пусто)");
            }
            else
            {
                foreach (var kv in stats)
                {
                    Console.WriteLine($"  {kv.Key}: {kv.Value:N0} руб.");
                }
            }
            Pause();
        }

        /// <summary>
        /// Меню
        /// </summary>
        public void RunMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"=== МЕНЮ === [{currentKind}]");
                Console.WriteLine("1. Показать всех");
                Console.WriteLine("2. Добавить робота");
                Console.WriteLine("3. Найти по ID");
                Console.WriteLine("4. Редактировать");
                Console.WriteLine("5. Удалить");
                Console.WriteLine("6. Группировка по типу");
                Console.WriteLine("7. Средняя цена по серии");
                Console.WriteLine("8. Сменить источник данных");
                Console.WriteLine("0. Выход");
                Console.Write("</> ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    RefreshRequested?.Invoke();
                }
                else if (choice == "2")
                {
                    HandleAdd();
                }
                else if (choice == "3")
                {
                    HandleFind();
                }
                else if (choice == "4")
                {
                    HandleEdit();
                }
                else if (choice == "5")
                {
                    HandleDelete();
                }
                else if (choice == "6")
                {
                    GroupByTypeRequested?.Invoke();
                }
                else if (choice == "7")
                {
                    AveragePriceRequested?.Invoke();
                }
                else if (choice == "8")
                {
                    HandleChangeSource();
                }
                else if (choice == "0")
                {
                    Console.WriteLine("Выход...");
                    Environment.Exit(0);
                    return;
                }
                else
                {
                    Console.WriteLine("Неверная команда.");
                }
            }
        }

        // --- Вспомогательные методы ---
        
        private void HandleAdd()
        {
            var dto = ReadRobotFromConsole(0);
            if (dto != null)
                AddRobotRequested?.Invoke(dto);
        }

        private void HandleFind()
        {
            Console.Write("ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                FindRobotRequested?.Invoke(id);
            }
            else
            {
                Console.WriteLine("Некорректный ID.");
            }
        }

        private void HandleEdit()
        {
            if (currentRobots.Count == 0)
            {
                Console.WriteLine("Список пуст.");
                return;
            }

            Console.Write("ID для редактирования: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Некорректный ID.");
                return;
            }

            var original = currentRobots.FirstOrDefault(r => r.Id == id);
            if (original == null)
            {
                Console.WriteLine("Робот не найден.");
                return;
            }

            // Делаем копию, чтобы можно было отменить изменения
            var draft = CloneRobot(original);

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== РЕДАКТИРОВАНИЕ РОБОТА #{draft.Id} ===");
                Console.WriteLine($"  1. Номер:      {draft.Number}");
                Console.WriteLine($"  2. Серия:      {draft.Series}");
                Console.WriteLine($"  3. Тип:        {draft.Type}");
                Console.WriteLine($"  4. Название:   {draft.Name}");
                Console.WriteLine($"  5. Цель:       {draft.Goal}");
                Console.WriteLine($"  6. Детали:     {draft.Details}");
                Console.WriteLine($"  7. Внешность:  {draft.Appearance}");
                Console.WriteLine($"  8. Критерии:   {draft.CriteriaCodes.Count}/10 — {CriteriaLegend.Describe(draft.CriteriaCodes)}");
                Console.WriteLine($"  9. Цена:       {draft.PriceRub:N0} руб.");
                Console.WriteLine();
                Console.WriteLine("  0. Сохранить и выйти");
                Console.WriteLine("  X. Отменить изменения");
                Console.Write("</> ");

                var choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    EditIntField("Новый номер: ", v => draft.Number = v);
                }
                else if (choice == "2")
                {
                    EditStringField("Новая серия: ", v => draft.Series = v);
                }
                else if (choice == "3")
                {
                    EditStringField("Новый тип: ", v => draft.Type = v);
                }
                else if (choice == "4")
                {
                    EditStringField("Новое название: ", v => draft.Name = v);
                }
                else if (choice == "5")
                {
                    EditStringField("Новая цель: ", v => draft.Goal = v);
                }
                else if (choice == "6")
                {
                    EditStringField("Новые детали: ", v => draft.Details = v);
                }
                else if (choice == "7")
                {
                    EditStringField("Новая внешность: ", v => draft.Appearance = v);
                }
                else if (choice == "8")
                {
                    EditCriteria(draft);
                }
                else if (choice == "9")
                {
                    EditDecimalField("Новая цена (руб.): ", v => draft.PriceRub = v);
                }
                else if (choice == "0")
                {
                    UpdateRobotRequested?.Invoke(draft);
                    return;
                }
                else if (choice == "X" || choice == "x")
                {
                    Console.WriteLine("Изменения отменены.");
                    Pause();
                    return;
                }
                else
                {
                    Console.WriteLine("Неверная команда.");
                }
            }
        }

        private void EditIntField(string prompt, Action<int> setter)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= 0)
            {
                setter(value);
            }
            else
            {
                Console.WriteLine("Некорректное число.");
            }
        }

        private void EditDecimalField(string prompt, Action<decimal> setter)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal value) && value >= 0)
            {
                setter(value);
            }
            else
            {
                Console.WriteLine("Некорректное число.");
            }
        }

        private void EditStringField(string prompt, Action<string> setter)
        {
            Console.Write(prompt);
            var value = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(value))
            {
                setter(value.Trim());
            }
            else
            {
                Console.WriteLine("Значение не может быть пустым.");
            }
        }

        private void EditCriteria(RobotDTO draft)
        {
            Console.WriteLine("Выберите критерии (каждый с новой строки, пустая строка — конец):");
            foreach (var kv in CriteriaLegend.Legend)
            {
                Console.WriteLine($"  {kv.Key}. {kv.Value}");
            }

            var codes = new List<int>();
            while (true)
            {
                Console.Write("Код: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                if (int.TryParse(input, out int c) && c >= 1 && c <= 10 && !codes.Contains(c))
                {
                    codes.Add(c);
                }
                else
                {
                    Console.WriteLine("Неверный код (1–10).");
                }
            }

            draft.CriteriaCodes = codes;
        }

        private static RobotDTO CloneRobot(RobotDTO src) => new RobotDTO
        {
            Id = src.Id,
            Number = src.Number,
            Series = src.Series,
            Type = src.Type,
            Name = src.Name,
            Goal = src.Goal,
            Details = src.Details,
            Appearance = src.Appearance,
            CriteriaCodes = new List<int>(src.CriteriaCodes),
            PriceRub = src.PriceRub
        };

        private void HandleDelete()
        {
            var selected = SelectRobot();
            if (selected == null)
            {
                return;
            }

            Console.Write($"Удалить «{selected.Name}»? (y/n): ");
            if (Console.ReadLine()?.ToLower() == "y")
            {
                DeleteRobotRequested?.Invoke(selected.Id);
            }
        }

        private void HandleChangeSource()
        {
            Console.WriteLine("Выберите источник:");
            Console.WriteLine("  1. JSON");
            Console.WriteLine("  2. Dapper");
            Console.WriteLine("  3. Entity Framework");
            Console.Write("</> ");

            var k = Console.ReadLine();
            DataSourceKind? kind = k switch
            {
                "1" => DataSourceKind.Json,
                "2" => DataSourceKind.Dapper,
                "3" => DataSourceKind.EntityFramework,
                _ => null
            };

            if (kind == null)
            {
                Console.WriteLine("Отменено.");
            }
            else
            {
                ChangeSourceRequested?.Invoke(kind.Value);
            }
        }

        /// <summary>
        /// Показывает список и просит ввести ID робота.
        /// </summary>
        private RobotDTO? SelectRobot()
        {
            if (currentRobots.Count == 0)
            {
                Console.WriteLine("Список пуст.");
                return null;
            }

            ShowRobots(currentRobots);
            Console.Write("Введите ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Некорректный ID.");
                return null;
            }
            var robot = currentRobots.FirstOrDefault(r => r.Id == id);
            if (robot == null)
            {
                Console.WriteLine("Робот с таким ID не найден.");
            }
            return robot;
        }

        /// <summary>
        /// Читает поля робота с консоли.
        /// </summary>
        private RobotDTO? ReadRobotFromConsole(int id)
        {
            try
            {
                Console.Write("Номер: ");
                int number = int.Parse(Console.ReadLine()!);

                Console.Write("Серия: ");
                string series = Console.ReadLine() ?? "";

                Console.Write("Тип: ");
                string type = Console.ReadLine() ?? "";

                Console.Write("Название: ");
                string name = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Название не может быть пустым.");
                    return null;
                }

                Console.Write("Цель: ");
                string goal = Console.ReadLine() ?? "";

                Console.Write("Детали: ");
                string details = Console.ReadLine() ?? "";

                Console.Write("Внешность: ");
                string appearance = Console.ReadLine() ?? "";

                Console.WriteLine("\nВыберите критерии (каждый с новой строки, пустая строка — конец):");
                foreach (var kv in CriteriaLegend.Legend)
                {
                    Console.WriteLine($"  {kv.Key}. {kv.Value}");
                }

                var codes = new List<int>();
                while (true)
                {
                    Console.Write("Код: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    if (int.TryParse(input, out int c) && c >= 1 && c <= 10 && !codes.Contains(c))
                    {
                        codes.Add(c);
                    }
                    else
                    {
                        Console.WriteLine("Неверный код (1–10).");
                    }
                }

                Console.Write("Цена (руб.): ");
                decimal price = decimal.Parse(Console.ReadLine()!);

                return new RobotDTO
                {
                    Id = id,
                    Number = number,
                    Series = series.Trim(),
                    Type = type.Trim(),
                    Name = name.Trim(),
                    Goal = goal.Trim(),
                    Details = details.Trim(),
                    Appearance = appearance.Trim(),
                    CriteriaCodes = codes,
                    PriceRub = price
                };
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода: проверьте, что числа введены правильно.");
                return null;
            }
        }

        private static void Pause()
        {
            Console.WriteLine("\nНажмите Enter...");
            Console.ReadLine();
        }
    }
}
