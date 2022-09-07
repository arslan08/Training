int[] GetArr(int Size, int Min, int Max)
{
    int[] arr = new int[Size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(Min, Max + 1);
    }
    return arr;
}

int[] CopyArr(int[] arr)
{
    int[] tmpArr = new int[arr.Length];
    int i = 0;
    foreach (var item in arr)
    {
        tmpArr[i] = item;
        Console.WriteLine($"[{i}] -> {item}");
        i += 1;
    }
    return tmpArr;
}
int[] arr = GetArr(10, 0, 10);
Console.WriteLine($"[{string.Join(", ", arr)}] -> [{string.Join(", ", CopyArr(arr))}]");