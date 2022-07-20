// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArr;
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

int[,] SortingRowsFromLargest(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, k];
                    arr[i, k] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
        }
    }
    return arr;
}

Console.WriteLine("Enter the number of rows in the array");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of elements in the array row");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum value in the array");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum value in the array");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArr = CreateRandom2dArray(rows, columns, minValue, maxValue);

Console.WriteLine("Created array");
Show2dArray(myArr);

Console.WriteLine();

SortingRowsFromLargest(myArr);

Console.WriteLine("Sorted array");
Show2dArray(myArr);
