int a;
do
{
    Console.WriteLine("Введите число с клавиатуры от 1 до 100:");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 1 || a > 100) Console.WriteLine("Error");
    else if (a % 3 == 0) Console.WriteLine("Fizz");
    else if (a % 5 == 0)Console.WriteLine("Buzz");
    else if (a % 3 == 0 && a % 5 == 0)Console.WriteLine("Fizz Buzz");
    else if (a % 3 != 0 && a % 5 != 0)Console.WriteLine(a);
} while (a != 111);

