using System.Collections.Generic;

int begin, end;
List<int> integer=new List<int>();
Console.WriteLine("Введите два числа: ");
begin = Convert.ToInt32(Console.ReadLine());
end = Convert.ToInt32(Console.ReadLine());

if (begin>end)
{
    int buffer;
    buffer = begin;
    begin = end;
    end = buffer;
}

for (int i = begin; i <= end; i++)
{
    integer.Add(i);
}

foreach (var item in integer)
{
    Console.Write("\t{0}",item);
}

Console.WriteLine();

for (int i=0;i<integer.Count;i++)
{
    if (integer[i]%2==0)
    {
        Console.Write("\t{0}",integer[i]);
    }
}