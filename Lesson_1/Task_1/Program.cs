string numberStrA;
string numberStrB;
Console.WriteLine("Введите первое число:");
numberStrA = Console.ReadLine();
Console.WriteLine("Введите второе число:");
numberStrB = Console.ReadLine();
int numberA = int.Parse(numberStrA);
int numberB = int.Parse(numberStrB);
if (numberA / numberB == numberB)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}