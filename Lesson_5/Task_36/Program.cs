int[] arr = new int[new Random().Next(2, 10)];
int ChekNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-10, 10);
}
for (int i = 0; i < arr.Length; i += 2)
{
    ChekNum += arr[i];
}
Console.WriteLine($"[{string.Join(", ", arr)}] -> {ChekNum}");