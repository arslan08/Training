Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int d = a;
if (b > d)
{
    d = b;
}
if (c > d)
{
    d = c;
}
Console.WriteLine("max = " + d);
