// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
    if (num == 0) return;
    WriteNumbers(num - 1);
    Console.Write(num + " ");
}
WriteNumbers(ReadInt("Введиче число: "));