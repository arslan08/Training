Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вотрое число");
int b = int.Parse(Console.ReadLine());
while (b == 0)
{
    Console.WriteLine("Введите число не кратное 0");
    b = int.Parse(Console.ReadLine());
}
if (a % b == 0)
{
    Console.WriteLine(a + ", " + b + " -> кратно");
}
else
{
    Console.WriteLine(a + ", " + b + " -> не кратно, остаток " + a % b);
}