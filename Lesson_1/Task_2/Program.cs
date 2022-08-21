Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a + ", min = " + b);
}
else
{
    Console.WriteLine("max = " + b + ", min = " + a);
}