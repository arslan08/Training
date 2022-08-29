int x = 0;
int y = 0;
while (x == 0)
{
    Console.WriteLine("Введите координаты точки X не равной 0");
    x = int.Parse(Console.ReadLine());
}
while (y == 0)
{
    Console.WriteLine("Введите координаты точки Y не равной 0");
    y = int.Parse(Console.ReadLine());
}
if (x > 0 && y > 0) Console.WriteLine("Плоскость №1");
if (x < 0 && y > 0) Console.WriteLine("Плоскость №2");
if (x < 0 && y < 0) Console.WriteLine("Плоскость №3");
if (x > 0 && y < 0) Console.WriteLine("Плоскость №4");