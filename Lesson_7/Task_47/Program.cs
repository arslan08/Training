double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}


int rows = new Random().Next(1, 10);
int columns = new Random().Next(2, 10);
double[,] result = GetArray(rows, columns);
PrintArray(result);