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
        Console.Write("     ");
        for (int l = 0; l < array.GetLength(1); l++)
        {
            if (i % 2 == 1 & l % 2 == 1) Console.Write(Math.Pow(array[i, l], 2) + " ");
            else Console.Write(array[i, l] + " ");
        }
        Console.WriteLine();
    }
}


int rows = new Random().Next(1, 10);
int columns = new Random().Next(2, 10);

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);