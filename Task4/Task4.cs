var size = 6;
var arr = new int [size];
int l, y;
Console.WriteLine("Введите шестизначное число:");

int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

if (numbers.Length>6)
{
    Console.WriteLine("Error");
    Environment.Exit(0);
}

for (int i = 0; i < arr.Length; i++) arr[i] = numbers[i];
foreach (var item in arr) Console.Write(item);
Console.WriteLine();
Console.WriteLine("Введите номера разрядов для обмена цифр: ");
l = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());

void SwapNumber(int[]arr, int l ,int y)
{
    l--;
    y--;
    int buffer1=0;
    int buffer2=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i==l) buffer1 = arr[i];
        if (i==y) buffer2 = arr[i];
    }

    for (int i = 0; i < arr.Length; i++)
    {
        arr[y] = buffer1;
        arr[l] = buffer2;
    }

    foreach (var item in arr)
    {
        Console.Write(item);
    }
}

SwapNumber(arr, l, y);

