//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());
int tmp = 1;
for (int i = 0; i < b; i++)
{
    tmp *= a;
}
Console.WriteLine(tmp);