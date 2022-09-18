Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
Console.Write($"M = {m}; N = {n} -> ");
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
sumNaturalElements(m, n, temp = 0);

void sumNaturalElements(int m, int n, int NuberSumm)
{
    NuberSumm = NuberSumm + n;
    if (n <= m)
    {
        Console.Write($"{NuberSumm} ");
        return;
    }
    sumNaturalElements(m, n - 1, NuberSumm);
}