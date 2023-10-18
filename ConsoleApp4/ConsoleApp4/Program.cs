int a = 0;

while (true)
{
    bool c = true;
    while (c)
    {
        Console.WriteLine("Ежедневник");

        Console.Write("Текущая дата:");
        DateOnly now = DateOnly.Parse("17.10.2023");
        now = now.AddDays(a);
        Console.WriteLine(now);

        Console.WriteLine();
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("  :Открыть полную информацию о заметке");
        Console.WriteLine("  :Выйти из программы");

        ConsoleKeyInfo key;

        int pos = 4;
        while (true)
        {
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow && pos != 4)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                pos--;
            }
            else if (key.Key == ConsoleKey.DownArrow && pos != 5)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                pos++;
            }
            if (pos == 5 && key.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
            else if (pos == 4 && key.Key == ConsoleKey.Enter)
            {
                if (a == 0)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дел нет :)");
                }
                else if (a == 1)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дела:");
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("1) написать код");
                    Console.SetCursorPosition(1, 11);
                    Console.WriteLine("2) поспать");
                    Console.SetCursorPosition(1, 12);
                    Console.WriteLine("3) поесть");
                }
                else if (a == 2)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дела:");
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("1) размышлять о делах насушьных");
                    Console.SetCursorPosition(1, 11);
                    Console.WriteLine("2) поспать");
                    Console.SetCursorPosition(1, 12);
                    Console.WriteLine("3) принять тот факт что в ноуте нет разьёма под VR\n    и даже через переходник эта хрень не работает,\n    а ноут дорогой :(");
                }
                else if (a == 75)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дела:");
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("1) Отметить НОВЫЙ ГОД!!!!!!!");
                }
                else if (a == -1)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дел нет :)");
                }
                else if (a == -2)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дела:");
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("1) написать код");
                    Console.SetCursorPosition(1, 11);
                    Console.WriteLine("2) пароль от стима: *******");
                    Console.SetCursorPosition(1, 12);
                    Console.WriteLine("3) пойти на пары");
                }
                else if (a == 76)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дела:");
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("1) СРОЧНО ЛИТР ААА ЛУЧШЕ ДВА, ВОДЫ СЮДА!!!!!!");
                }
                else if (a == -3)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дел нет :)");
                }
                else if (a == -4)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дела:");
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("1) создать игру");
                    Console.SetCursorPosition(1, 11);
                    Console.WriteLine("2) понять что слишком туп :|");
                }
                else if (a <= -5 || a <= 74 || a >=77)
                {
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("Дел нет :)");
                }
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                a = a + 1;
                Console.Clear();
                c = true;
                break;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                a = a - 1;
                Console.Clear();
                c = false;
                break;
            }
        }
    }
}