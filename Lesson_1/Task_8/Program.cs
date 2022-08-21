Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i < n & i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    if (i == n & i % 2 == 0)
    {
        Console.Write(i);
    }
}