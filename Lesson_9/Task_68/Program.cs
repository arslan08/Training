Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
Console.Write($"M = {m}; N = {n} -> A({m},{n}) = ");

int AckermanFunctions(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunctions(m - 1, 1);
    else return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
}

if (m < 0 | n < 0) Console.Write($"Отрицательные числа");
else Console.Write($"{AckermanFunctions(m, n)}");