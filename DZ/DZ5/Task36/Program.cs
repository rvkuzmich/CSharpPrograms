// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // [-9, 10) > -9 до 9
    }

    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
void SumArrayElements(int[] array)
{
    int sumArrayElements = 0;
    for (int i=1; i<array.Length; i+=2)
    {
        sumArrayElements+=array[i];
    }
    System.Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {sumArrayElements}");
}

int[] newArray = GenerateArray(20, -9, 99);
PrintArray(newArray);
SumArrayElements(newArray);