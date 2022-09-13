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
            if (i == j & i != 1)
            {
                SumDiagonal += array[i, j];
                TextDiaganal = TextDiaganal + " + " + array[i, j];
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {TextDiaganal} = {SumDiagonal}");
}


int rows = new Random().Next(1, 10);
int columns = new Random().Next(2, 10);

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);