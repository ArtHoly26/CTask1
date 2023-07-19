double temp;
int choise;
bool flag = false;
Console.WriteLine("Введите температуру: ");
temp=Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("1 - Перевести из Цельсий в Фаренгейты");
    Console.WriteLine("2 - Перевести из Фаренгейты в Цельсий");
    Console.WriteLine("3 - Выход");
    choise = Convert.ToInt32(Console.ReadLine());

    switch (choise)
    {
        case 1:
            temp = temp * 1.8 + 32;
            Console.WriteLine("Температура в Фаренгейт равна {0} F ", temp);
            break;
        case 2:
            temp = (temp - 32) / 1.8;
            Console.WriteLine("Температура в Цельсий равна {0} C", temp );
            break;
        case 3:
            flag = true;
            break;
    }

} while (!flag);