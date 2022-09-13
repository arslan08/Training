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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void arithmeticMeanArray(int[,] array)
{
    double SumColumns = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            SumColumns += array[j, i];
        }
        Console.Write("{0,3:F1}; ", SumColumns / array.GetLength(0));
        SumColumns = 0;

    }
}

int rows = new Random().Next(1, 5);
int columns = new Random().Next(2, 5);

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);
arithmeticMeanArray(result);