Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine(a + " -> Да");
}
else
{
    Console.WriteLine(a + " -> Нет");
}