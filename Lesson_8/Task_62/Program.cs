
int[,] FillingSpiralArray(int size)
{
    int[,] result = new int[size, size];
    int number = 0;
    int minRow = 0;
    int maxRow = size - 1;
    int minCol = 0;
    int maxCol = size - 1;
    while (number < size * size)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            result[minRow, i] = number;
            number++;
        }
        minRow = minRow + 1;
        for (int i = minRow; i <= maxRow; i++)
        {
            result[i, maxCol] = number;
            number++;
        }
        maxCol = maxCol - 1;
        for (int i = maxCol; i >= minCol; i--)
        {
            result[maxRow, i] = number;
            number++;
        }
        maxRow = maxRow - 1;
        for (int i = maxRow; i >= minRow; i--)
        {
            result[i, minCol] = number;
            number++;
        }
        minCol = minCol + 1;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int size = 4;

int[,] result = FillingSpiralArray(size);
PrintArray(result);