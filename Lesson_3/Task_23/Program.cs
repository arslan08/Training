int n = 0;
if (n == 0)
{
    Console.WriteLine("Введите число");
    n = int.Parse(Console.ReadLine());
}
Console.Write(n + "-> ");
for (int i = 1; i <= n; i++)
{
    if (i < n) Console.Write(Math.Pow(i, 3) + ", ");
    if (i == n) Console.WriteLine(Math.Pow(i, 3));
}