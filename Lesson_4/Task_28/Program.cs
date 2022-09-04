int GetProisvNum(int num)
{
    int tmp = 1;
    for (int i = 1; i <= num; i++) tmp *= i;
    return tmp;
}
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(GetProisvNum(n));