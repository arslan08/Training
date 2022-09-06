int[] arr = new int[new Random().Next(2, 10)];
string ChekNum = string.Empty;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    if (i != arr.Length - 1 - i & i < arr.Length - 1 - i) ChekNum = ChekNum + " " + (arr[i] + arr[arr.Length - 1 - i]);
    else if (i < arr.Length - 1 - i) ChekNum = ChekNum + " " + arr[i];
}
Console.WriteLine($"[{string.Join(", ", arr)}] -> {ChekNum}");