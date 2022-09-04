// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int tmp = n % 10;
while (n / 10 > 0)
{
    n = n / 10;
    tmp += n % 10;
}
Console.WriteLine(tmp);