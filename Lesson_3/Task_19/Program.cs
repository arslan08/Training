int Pal = 0;
bool PalCheck = false;
while (Pal / 10000 < 1 ^ Pal / 10000 > 10)
{
    Console.WriteLine("Введите пятизначное число");
    Pal = int.Parse(Console.ReadLine());
}
for (int i = 10; i <= 100000; i = i * 10)
{
    if (Pal % i / (i / 10) == Pal / (100000 / i) % 10)
    {
        PalCheck = true;
    }
    else
    {
        PalCheck = false;
        break;
    };
}
switch (PalCheck)
{
    case true:
        Console.WriteLine(Pal + " -> да");
        break;
    case false:
        Console.WriteLine(Pal + " -> нет");
        break;
}