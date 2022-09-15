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
void ProductMatrices(int[,] arrayA, int[,] arrayB)
{
    int[,] result = new int[2, 2];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        int tmp = 0;
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(1); k++)
            {
                tmp += arrayA[i, k] * arrayB[k, j];
            }
            result[i, j] = tmp;
            tmp = 0;

        }
    }
    PrintArray(result);
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
void PrintTwoArray(int[,] arrayA, int[,] arrayB)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            Console.Write(arrayA[i, j] + " ");
        }
        Console.Write("| ");
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            Console.Write(arrayB[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = 2;
int columns = 2;

int[,] resultA = GetArray(rows, columns, 0, 9);
int[,] resultB = GetArray(rows, columns, 0, 9);

PrintTwoArray(resultA, resultB);
Console.WriteLine();
ProductMatrices(resultA, resultB);