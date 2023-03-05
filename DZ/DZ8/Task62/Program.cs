// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralFill(int m, int n)
{
    int[,] matrix = new int[m, n];
    int l = 1;
    int i = 0;
    int j = 0;
    for (j = 0; j < n; j++)
    {
        matrix[0, j] = l;
        l++;
    }
    for (i = 1; i < m; i++)
    {
        matrix[i, 3] = l;
        l++;
    }
    for (j = 2; j >= 0; j--)
    {
        matrix[3, j] = l;
        l++;
    }
    for (i = 2; i >= 1; i--)
    {
        matrix[i, 0] = l;
        l++;
    }
    for (j = 1; j < m - 1; j++)
    {
        matrix[1, j] = l;
        l++;
    }
    for (j = 2; j >= n - 3; j--)
    {
        matrix[2, j] = l;
        l++;
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] spiralMatrix = SpiralFill(4, 4);
PrintMatrix(spiralMatrix);