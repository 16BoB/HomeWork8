// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindLargesSumElementsRow(int[,] arr)
{
    int[] sumRow = new int[arr.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        sumRow[i] = sum;
        sum = 0;
    }
    int minSumRow = sumRow[0];
    int minSumRowIndex = 0;
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (minSumRow > sumRow[i])
        {
            minSumRow = sumRow[i];
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex; // Либо написать return minSumRowIndex + 1; чтобы возвращал номер строки удобный для пользователя
}

int[,] myArr = CreateRandom2dArray(5, 3, 1, 9);

Show2dArray(myArr);

Console.WriteLine("Наименьшая сума елементов на строке: " + FindLargesSumElementsRow(myArr));