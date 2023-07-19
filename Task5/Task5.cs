
Console.Write("Введите месяц: ");
int month =int.Parse(Console.ReadLine());
Console.Write("Введите день: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Введите год: ");
int year = int.Parse(Console.ReadLine());

DateTime date = new DateTime(year, month, day);

Console.WriteLine(date.DayOfWeek);
if (month == 1 || month == 2 || month == 12) Console.WriteLine("Winter");
else if (month == 3 || month == 4 || month == 5) Console.WriteLine("Spring");
else if (month == 6 || month == 7 || month == 8) Console.WriteLine("Summer");
else  Console.WriteLine("Autumn");




