Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
Console.Write($"M = {m}; N = {n}. -> \"\"");

void summ(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        summ(m + 1, n);
    }
}

summ(m, n);
Console.Write($"{n}\"\"");