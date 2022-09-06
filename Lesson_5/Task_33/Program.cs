int[] arr = new int[5];
string ChekNum = "Нет";
int RandNum = new Random().Next(-9, 9);
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 9);
}
foreach (int item in arr)
{
    if (item == RandNum) ChekNum = "Да";
}
Console.WriteLine($"{RandNum},  массив [{string.Join(", ", arr)}] -> {ChekNum}");