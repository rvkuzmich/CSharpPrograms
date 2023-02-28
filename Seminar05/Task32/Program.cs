// Задача 32: Напишите программу замены элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
void Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=-array[i];
    }
}
int[] arr = GenerateArray(10, -9, 9);
PrintArray(arr);
Reverse(arr);
PrintArray(arr);
