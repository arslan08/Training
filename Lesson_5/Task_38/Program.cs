int[] arr = new int[new Random().Next(2, 10)];
int ChekNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
}
int min = arr[0];
int max = arr[0];
foreach (int item in arr)
{
    if (item < min) min = item;
    if (item > max) max = item;
}
Console.WriteLine($"[{string.Join(", ", arr)}] -> {(min + max)}");