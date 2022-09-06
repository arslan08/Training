int[] arr = new int[new Random().Next(0, 10)];
int ChekNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(99, 1000);
}
foreach (int item in arr)
{
    if (item % 2 == 0) ChekNum += 1;
}
Console.WriteLine($"[{string.Join(", ", arr)}] -> {ChekNum}");