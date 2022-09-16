Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
Console.Write($"M = {m}; N = {n}. -> \"\"");
for (int i = m; i < n; i++)
{
    Console.Write($"{i}, ");
}
Console.Write($"{n}\"\"");