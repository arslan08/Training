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
void ArrangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; ++j)
        {
            if (array[i, j] < array[i, j + 1])
            {
                int min = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = min;
                j = 0;
            }
        }
    }
    PrintArray(array);
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

int rows = 3;
int columns = 4;

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);
Console.WriteLine();
ArrangeArray(result);