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
void CountingRow(int[,] array)
{
    int SumFlag = 1;
    int tmp = 0;
    int tmpSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmpSum += array[i, j];
        }
        if (i == 0) tmp = tmpSum;
        if (tmpSum < tmp)
        {
            SumFlag += 1;
            tmp = tmpSum;
        }
        tmpSum = 0;
    }
    Console.WriteLine($"{SumFlag} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int columns = 4;

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);
Console.WriteLine();
CountingRow(result);