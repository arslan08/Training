int[] arr = new int[new Random().Next(0, 123)];
int ChekNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 123);
}
foreach (int item in arr)
{
    if (item > 10 & item < 99) ChekNum += 1;
}
Console.WriteLine($"[{string.Join(", ", arr)}] -> {ChekNum}");