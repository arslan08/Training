int[,,] GetArray(int m, int n, int b, int minValue, int maxValue)
{
    int[] tmp = new int[0];
    int tmpNumber = 0;
    int[,,] result = new int[m, n, b];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < b; k++)
            {
                bool check = true;
                while (check)
                {
                    tmpNumber = new Random().Next(minValue, maxValue + 1);
                    check = freeNumber(tmp, tmpNumber);
                }
                result[i, j, k] = tmpNumber;
                Array.Resize(ref tmp, tmp.Length + 1);
                tmp[tmp.Length - 1] = tmpNumber;
            }
        }
    }
    return result;
}

bool freeNumber(int[] array, int nuberChek)
{
    foreach (var item in array)
    {
        if (item == nuberChek) return true;
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }

    }
}

int rows = 2;
int columns = 2;
int depth = 2;

int[,,] result = GetArray(rows, columns, depth, 10, 100);
PrintArray(result);