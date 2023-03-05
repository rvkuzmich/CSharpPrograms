// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,,] Generate3DArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i, j, l] = rand.Next(10, 100);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                System.Console.Write($"{array[i, j, l]}({i},{j},{l})\t");
            }
            System.Console.WriteLine();
        }
    }
}

int m = ReadInt("Введите первый размер массива: ");
int n = ReadInt("Введите второй размер массива: ");
int k = ReadInt("Введите третий размер массива: ");
int[,,] my3DArray = Generate3DArray(m, n, k);
Print3DArray(my3DArray);