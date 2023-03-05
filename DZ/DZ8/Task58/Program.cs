// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMulti = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixMulti[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMulti;
}

int m = ReadInt("Введите количетсво строк первой матрицы: ");
int n = ReadInt("Введите количество столбцов первой матрицы: ");
int k = ReadInt("Введите количество строк второй матрицы: ");
int l = ReadInt("Введите количество столбцов второй матрицы: ");
var myMatrix1 = GenerateMatrix(m, n);
var myMatrix2 = GenerateMatrix(k, l);
System.Console.WriteLine("Первая матрица: ");
PrintMatrix(myMatrix1);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица: ");
PrintMatrix(myMatrix2);
System.Console.WriteLine();
if (m != l) System.Console.WriteLine("Перемножение матриц невозможно");
else
{
    var multiMatrix = MatrixMultiplication(myMatrix1, myMatrix2);
    System.Console.WriteLine("Результат перемножения матриц: ");
    PrintMatrix(multiMatrix);
}