int[] arr = new int[12];
int PosSumNum = 0;
int NegSumNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 9);
    PosSumNum += arr[i] < 0 ? arr[i] : 0;
    NegSumNum += arr[i] > 0 ? arr[i] : 0;
}

Console.WriteLine($"в массиве [{string.Join(",", arr)}] cумма положительных чисел равна {PosSumNum}, сумма отрицательных чисел равна {NegSumNum}");