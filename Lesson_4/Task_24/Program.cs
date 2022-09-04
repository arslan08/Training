int GetSumNums(int num)
{
    int a = 0;
    for (int i = 1; i <= num; i++) a += i;
    return a;
}
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(GetSumNums(a));