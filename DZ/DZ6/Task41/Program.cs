// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(string text)
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
void CountPositive(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    System.Console.WriteLine($"Количество введенных чисел больше нуля - {count}");;
}

int[] newArray = CreateArray("Введите желаемые числа через пробел");
PrintArray(newArray);
CountPositive(newArray);
