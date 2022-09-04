// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = new int[8];
string text = string.Empty;
for (int i = 0; i < arr.Length; i++)
{

    arr[i] = new Random().Next(1, 11);
    if (i < arr.Length - 1) text = text + arr[i] + ", ";
    else text = text + arr[i];
}

Console.WriteLine($"{text} -> [{text}]");