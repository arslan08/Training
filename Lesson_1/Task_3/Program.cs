Console.WriteLine("Введите номер дня недели:");
int NumDay = int.Parse(Console.ReadLine());
if (NumDay == 1)
{
    Console.Write("Понедельник");
}
if (NumDay == 2)
{
    Console.Write("Вторник");
}
if (NumDay == 3)
{
    Console.Write("Среда");
}
if (NumDay == 4)
{
    Console.Write("Четверг");
}
if (NumDay == 5)
{
    Console.Write("Пятница");
}
if (NumDay == 6)
{
    Console.Write("Суббота");
}
if (NumDay == 7)
{
    Console.Write("Воскресенье");
}
if (NumDay > 7 ^ NumDay < 0)
{
    Console.Write("Такого дня не существует");
}