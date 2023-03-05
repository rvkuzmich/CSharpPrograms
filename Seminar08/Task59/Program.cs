// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void FindMin(int[,] matrix, out int mini, out int minj)
{
    mini = 0;
    minj = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[mini, minj] > matrix[i, j])
            {
                mini = i;
                minj = j;
            }
        }
    }
}
int[,] Delete(int[,] matrix, int mini, int minj)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == mini) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minj) continue;
            newMatrix[row, col] = matrix[i, j];
            col++;
        }
        row++;
        col = 0;
    }
    return newMatrix;
}

int[,] myMatrix = GenerateMatrix(4, 4);
PrintMatrix(myMatrix);
System.Console.WriteLine();
FindMin(myMatrix, out int mini, out int minj);
System.Console.WriteLine($"{mini} {minj}");
System.Console.WriteLine();
int[,] myNewMatrix=Delete(myMatrix,mini,minj);
PrintMatrix(myNewMatrix);