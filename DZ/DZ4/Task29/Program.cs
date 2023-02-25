// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void GenArray(int[] array)
{
        Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}
System.Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] NewArray = new int[size];
GenArray(NewArray);
PrintArray(NewArray);