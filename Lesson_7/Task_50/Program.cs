int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    int SumDiagonal = array[1, 1];
    string TextDiaganal = string.Join((""), array[1, 1]);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int rowsRandom = new Random().Next(1, 10);
int columnsRandom = new Random().Next(2, 10);
Console.Write("Введите номер строки:  ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rowsRandom, columnsRandom, 0, 9);
if (rows > result.GetLength(0) & columns > result.GetLength(1)) Console.WriteLine($"такого элемента нет");
else
{
    PrintArray(result);
    Console.WriteLine($"значение элемента: {result[rows, columns]}");
}