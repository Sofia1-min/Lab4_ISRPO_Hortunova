Console.WriteLine("Привет!");
Console.WriteLine("ФИО:Хортюнова София Юрьевна");
Console.WriteLine("Группа: ИСП-241");
Console.WriteLine("Дата: 24.09.2026");
Console.WriteLine("Меню:");
Console.WriteLine("1 — Показать ФИО");
Console.WriteLine("2 — Показать группу");
 Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");
string? a = Console.ReadLine();
while (true)
{
    if (a == "1")

    {
        Console.WriteLine("Хортюнова София Юрьевна");
        break;
    }
    else if (a == "2")

    {
        Console.WriteLine("ИСП-241");
        break;
    }
    else if (a == "3")

    {
        Console.WriteLine("24.09.2026");
        break;
    }
    else if (a == "4")
    {

        break;
    }
    else

    {
        Console.WriteLine("Неверный выбор");
        break;
    }

}