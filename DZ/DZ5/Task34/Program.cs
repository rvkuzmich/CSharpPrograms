// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int EvenCounter(int[] array)
{
    int evenCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenCounter += 1;
    }
    return evenCounter;

}
int[] newArray = GenerateArray(10, 100, 999);
PrintArray(newArray);
int evenC = EvenCounter(newArray);
System.Console.WriteLine($"Количество четных чисел в массиве {evenC}");