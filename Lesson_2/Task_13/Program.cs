Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num / 100 > 0)
{
    int numTmp = num;
    while (numTmp / 1000 > 0)
    {
        numTmp = numTmp / 10;
    }

    Console.WriteLine(num + " -> " + (numTmp % 10));
}
else
{
    Console.WriteLine(num + " -> третьей цифры нет");
}