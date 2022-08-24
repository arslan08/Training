
int num = 0;
while (num <= 7 ^ num > 0)
{
    Console.WriteLine("введите цифру равную дню недели");
    num = int.Parse(Console.ReadLine());
}
if (num == 6 ^ num == 7)
{
    Console.WriteLine(num + " -> Да");
}
else
{
    Console.WriteLine(num + " -> Нет");
}
