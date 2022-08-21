Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
for (int i = n * -1; i <= n; i++)
{
    if (i < n)
    {
        Console.Write(i + ", ");
    }
    else
    {
        Console.Write(i);
    }

}
