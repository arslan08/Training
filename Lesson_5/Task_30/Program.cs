int[] arr = new int[12];
int Pos = 0;
int Neg = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 9);
    if (arr[i] < 0) Pos += arr[i];
    else Neg += arr[i];
}

Console.WriteLine($"в массиве [{string.Join(",", arr)}] cумма положительных чисел равна {Pos}, сумма отрицательных чисел равна {Neg}");