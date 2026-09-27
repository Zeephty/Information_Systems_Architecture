using Model;

Logic logic = new Logic();
logic.Load();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== РОБОТЫ ===");
    Console.WriteLine("1. Показать всех");
    Console.WriteLine("2. Добавить");
    Console.WriteLine("3. Найти по ID");
    Console.WriteLine("4. Редактировать");
    Console.WriteLine("5. Удалить");
    Console.WriteLine("6. Группировка по типу");
    Console.WriteLine("7. Средняя цена по серии");
    Console.WriteLine("0. Выход");
    Console.Write("</> ");

    string choice = Console.ReadLine();
    Console.WriteLine();

    try
    {
        if (choice == "1")
        {
            ShowAll(logic);
        }
        else if (choice == "2")
        {
            AddRobot(logic);
        }
        else if (choice == "3")
        {
            FindById(logic);
        } 
        else if (choice == "4")
        {
            EditRobot(logic);
        }
        else if (choice == "5")
        {
            DeleteRobot(logic);
        }
        else if (choice == "6")
        {
            GroupByType(logic);
        }
        else if (choice == "7")
        {
            AvgPrice(logic);
        }
        else if (choice == "0")
        {
            logic.Save();
            break;
        }
        else
        {
            Console.WriteLine("<W> Неверная команда");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"<W> Ошибка: {ex.Message}");
    }

    Console.WriteLine("\n<W> Нажмите Enter...");
    Console.ReadLine();
}


static void ShowAll(Logic logic)
{
    var all = logic.GetAll();
    if (all.Count == 0)
    {
        Console.WriteLine("<W> Пусто.");
        return;
    }
    foreach (var r in all)
    {
        Console.WriteLine($"<R> {r}");
    }
}


static void AddRobot(Logic logic)
{
    var r = ReadRobot();
    Console.WriteLine($"<W> Добавлен {logic.Add(r)} робот.");
}


static void FindById(Logic logic)
{
    Console.Write("<I> ID: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("<E> Некорректный ID.");
        return;
    }

    var r = logic.GetById(id);
    if (r == null) 
    { 
        Console.WriteLine("<E> Не найдено."); 
        return; 
    }

    Console.WriteLine(r);
    Console.WriteLine($"<I> Критерии: {CriteriaLegend.Describe(r.CriteriaCodes)}");
}


static void EditRobot(Logic logic)
{
    Console.Write("<I> ID: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("<E> Некорректный ID.");
        return;
    }

    var robot = logic.GetById(id);
    if (robot == null)
    {
        Console.WriteLine("<E> Не найдено.");
        return;
    }

    while (true)
    {
        Console.Clear();
        Console.WriteLine($"=== РЕДАКТИРОВАНИЕ РОБОТА #{robot.Id} ===");
        Console.WriteLine($"  Номер:      {robot.Number}");
        Console.WriteLine($"  Серия:      {robot.Series}");
        Console.WriteLine($"  Тип:        {robot.Type}");
        Console.WriteLine($"  Название:   {robot.Name}");
        Console.WriteLine($"  Цель:       {robot.Goal}");
        Console.WriteLine($"  Детали:     {robot.Details}");
        Console.WriteLine($"  Внешность:  {robot.Appearance}");
        Console.WriteLine($"  Критерии:   {robot.CriteriaCodes.Count}/10 — {CriteriaLegend.Describe(robot.CriteriaCodes)}");
        Console.WriteLine($"  Цена:       {robot.PriceRub:N0} руб.");
        Console.WriteLine();

        Console.WriteLine("Что изменить?");
        Console.WriteLine("  1. Номер");
        Console.WriteLine("  2. Серия");
        Console.WriteLine("  3. Тип");
        Console.WriteLine("  4. Название");
        Console.WriteLine("  5. Цель");
        Console.WriteLine("  6. Детали");
        Console.WriteLine("  7. Внешность");
        Console.WriteLine("  8. Критерии");
        Console.WriteLine("  9. Цена");
        Console.WriteLine("  0. Закончить редактирование");
        Console.Write("</> ");

        string choice = Console.ReadLine();
        Console.WriteLine();

        try
        {
            if (choice == "1")
            {
                Console.Write("<I> Новый номер: ");
                if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
                {
                    Console.WriteLine("<E> Номер должен быть целым неотрицательным числом.");

                    Console.WriteLine("\n<W> Нажмите Enter...");
                    Console.ReadLine();

                    continue;
                }
                logic.Update(id, r => r.Number = number);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "2")
            {
                Console.Write("<I> Новая серия: ");
                string series = Console.ReadLine() ?? "";
                logic.Update(id, r => r.Series = series);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "3")
            {
                Console.Write("<I> Новый тип: ");
                string type = Console.ReadLine() ?? "";
                logic.Update(id, r => r.Type = type);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "4")
            {
                Console.Write("<I> Новое название: ");
                string name = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("<E> Название не может быть пустым.");

                    Console.WriteLine("\n<W> Нажмите Enter...");
                    Console.ReadLine();

                    continue;
                }
                logic.Update(id, r => r.Name = name);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "5")
            {
                Console.Write("<I> Новая цель: ");
                string goal = Console.ReadLine() ?? "";
                logic.Update(id, r => r.Goal = goal);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "6")
            {
                Console.Write("<I> Новые детали: ");
                string details = Console.ReadLine() ?? "";
                logic.Update(id, r => r.Details = details);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "7")
            {
                Console.Write("<I> Новая внешность: ");
                string appearance = Console.ReadLine() ?? "";
                logic.Update(id, r => r.Appearance = appearance);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "8")
            {
                Console.WriteLine("<I> Критерии (через запятую, например 1,2,5):");
                foreach (var kv in CriteriaLegend.Legend)
                    Console.WriteLine($"  {kv.Key}: {kv.Value}");
                Console.Write("</> ");

                var codes = Console.ReadLine()!
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s.Trim()))
                    .Where(c => c >= 1 && c <= 10)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToList();

                logic.Update(id, r => r.CriteriaCodes = codes);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "9")
            {
                Console.Write("<I> Новая цена (руб.): ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
                {
                    Console.WriteLine("<E> Цена должна быть неотрицательным числом.");

                    Console.WriteLine("\n<W> Нажмите Enter...");
                    Console.ReadLine();

                    continue;
                }
                logic.Update(id, r => r.PriceRub = price);
                Console.WriteLine("<W> Изменено.");
            }
            else if (choice == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("<W> Неверная команда.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"<E> Ошибка: {ex.Message}");
        }

        Console.WriteLine("\n<W> Нажмите Enter...");
        Console.ReadLine();

        // обновляем снимок робота — вдруг изменили
        robot = logic.GetById(id);
        if (robot == null)
        {
            Console.WriteLine("<E> Робот больше не существует.");
            return;
        }
    }
}


static void DeleteRobot(Logic logic)
{
    Console.Write("<I> ID: ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("<E> Некорректный ID.");
        return;
    }

    Console.WriteLine(logic.Delete(id) ? "<W> Удалено." : "<E> Не найдено.");
}


static void GroupByType(Logic logic)
{
    var groups = logic.GroupByType();
    if (groups.Count == 0)
    {
        Console.WriteLine("<W> Пусто.");
        return;
    }

    foreach (var g in groups)
    {
        Console.WriteLine($"[{g.Key}] ({g.Value.Count}):");
        foreach (var r in g.Value) 
            Console.WriteLine($"  {r.Name}");
    }
}


static void AvgPrice(Logic logic)
{
    var stats = logic.AveragePriceBySeries();
    if (stats.Count == 0)
    {
        Console.WriteLine("<W> Пусто.");
        return;
    }

    foreach (var kv in stats)
        Console.WriteLine($"{kv.Key}: {kv.Value:N0} руб.");
}


static Robot ReadRobot()
{
    Console.Write("<I> Номер: "); 
    int num = int.Parse(Console.ReadLine()!);

    Console.Write("<I> Серия: "); 
    string series = Console.ReadLine()!;

    Console.Write("<I> Тип: "); 
    string type = Console.ReadLine()!;

    Console.Write("<I> Название: "); 
    string name = Console.ReadLine()!;

    Console.Write("<I> Цель: "); 
    string goal = Console.ReadLine()!;

    Console.Write("<I> Детали: "); 
    string details = Console.ReadLine()!;

    Console.Write("<I> Внешность: "); 
    string appearance = Console.ReadLine()!;

    Console.WriteLine("<I> Критерии (через запятую, например 1,2,5):");

    foreach (var kv in CriteriaLegend.Legend)
        Console.WriteLine($"  {kv.Key}: {kv.Value}");

    Console.Write("</> ");
    var codes = Console.ReadLine()!.Split(',', StringSplitOptions.RemoveEmptyEntries)
        .Select(s => int.Parse(s.Trim())).ToList();

    Console.Write("<I> Цена (₽): "); var price = decimal.Parse(Console.ReadLine()!);

    return new Robot
    {
        Number = num,
        Series = series,
        Type = type,
        Name = name,
        Goal = goal,
        Details = details,
        Appearance = appearance,
        CriteriaCodes = codes,
        PriceRub = price
    };
}