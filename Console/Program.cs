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
        else
        {
            logic.Save();
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
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
        Console.WriteLine($"<R> {r}");
}


static void AddRobot(Logic logic)
{
    var r = ReadRobot();
    logic.Add(r);
    Console.WriteLine("<W> Добавлено.");
}


static void FindById(Logic logic)
{
    Console.Write("<I> ID: ");
    var id = Console.ReadLine()!;
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
    var id = Console.ReadLine()!;
    var existing = logic.GetById(id);
    if (existing == null) 
    { 
        Console.WriteLine("<E> Не найдено."); 
        return; 
    }

    var updated = ReadRobot();
    updated.Id = id;
    logic.Update(updated);
    Console.WriteLine("<W> Обновлено.");
}


static void DeleteRobot(Logic logic)
{
    Console.Write("<I> ID: ");
    var id = Console.ReadLine()!;
    Console.WriteLine(logic.Delete(id) ? "<W> Удалено." : "<E> Не найдено.");
}


static void GroupByType(Logic logic)
{
    foreach (var g in logic.GroupByType())
    {
        Console.WriteLine($"[{g.Key}] ({g.Value.Count}):");
        foreach (var r in g.Value) 
            Console.WriteLine($"  {r.Name}");
    }
}


static void AvgPrice(Logic logic)
{
    foreach (var kv in logic.AveragePriceBySeries())
        Console.WriteLine($"{kv.Key}: {kv.Value:N0} ₽");
}


static Robot ReadRobot()
{
    Console.Write("<I> ID: "); 
    string id = Console.ReadLine()!;

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
        Id = id,
        Number = num,
        Series = series,
        Type = type,
        Name = name,
        Goal = goal,
        Details = details,
        Appearance = appearance,
        CriteriaCodes = codes,
        Score = codes.Count,
        PriceRub = price
    };
}