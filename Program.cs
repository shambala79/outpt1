Console.WriteLine("Введите элементы массива через пробел: ");
string num = Console.ReadLine()!;
string[] numS = num.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int count = 0;
foreach (string el in numS)
{
    if (el.Length <= 3)
        count++;
}

int i = 0;
string[] Ar = new string[count];
foreach (string el in numS)
{
    if (el.Length <= 3)
    {
        Ar[i] = el;
        i++;
    }
}
Console.Write($"[{String.Join(' ', Ar)}]");
