Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());
int[] Fibo = new int[N];
for (int i = 0; i < Fibo.Length; i++)
{
    if (i == 0) Fibo[i] = 0;
    if (i == 1) Fibo[i] = 1;
    if (i >= 2) Fibo[i] = (Fibo[i - 1]) + (Fibo[i - 2]);
}
Console.WriteLine($"Если N = {N} -> {string.Join(" ", Fibo)}");