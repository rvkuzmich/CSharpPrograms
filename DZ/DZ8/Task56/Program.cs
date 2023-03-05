// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine("Полученная матрица:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] StringSumArray(int[,] matrix)
{
    int[] stringSum = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        stringSum[i] = sum;
        sum = 0;
    }
    return stringSum;
}
int FindMinSumString(int[] array)
{
    int minSumString = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minSumString = i;
        }
    }
    return minSumString;
}
var myMatrix = GenerateMatrix(4, 4);
PrintMatrix(myMatrix);
System.Console.WriteLine();
var stringSumArray = StringSumArray(myMatrix);
var minSumString = FindMinSumString(stringSumArray);
System.Console.WriteLine($"Минимальная сумма элементов массива находится на строке {minSumString+1}");