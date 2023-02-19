// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// System.Console.WriteLine("Введите желаемое число");
// string? str = Console.ReadLine();
// System.Console.WriteLine($"Количество цифр в числе - {str.Length}");

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int count(int number)
{
    int n = 0;
    while (number > 0)
    {
        number = number / 10;
        n++;
    }
    return n;
}
int num = ReadInt("Введите желаемое число: ");
System.Console.WriteLine($"Количество цифр в числе {num} - {count(num)}");