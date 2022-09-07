int[] arr = new int[new Random().Next(0, 10)];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
}
Console.Write($"[{string.Join(", ", arr)}] -> ");
for (int i = 0; i < arr.Length / 2; i++)
{
    int tmp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = tmp;
}
Console.Write($"[{string.Join(", ", arr)}]");