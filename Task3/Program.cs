// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
int[,] GetSpire(int n)
{
    int[,] result = new int[n, n];
    int columns = result.GetLength(1);
    int rows = result.GetLength(0);
    int value = 1;
    int count = 0;
    while (value - 1 < n * n)
    {
        for (int j = count; j < columns - count; j++)
        {
            result[count, j] = value;
            value++;
        }
        for (int k = count + 1; k < rows - count; k++)
        {
            result[k, columns - (1 + count)] = value;
            value++;
        }
        for (int m = columns - (2 + count); m >= count; m--)
        {
            result[rows - (1 + count), m] = value;
            value++;
        }
        for (int s = rows - (2 + count); s >= count + 1; s--)
        {
            result[s, count] = value;
            value++;
        }
        count++;
    }
    return result;
}

void Show2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int n;
Console.WriteLine("Введите размерность массива");
n = Convert.ToInt32(Console.ReadLine());

int[,] myArr = GetSpire(n);

Show2dArray(myArr);