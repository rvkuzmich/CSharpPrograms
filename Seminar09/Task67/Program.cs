// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumNum(num / 10);
}

System.Console.WriteLine($"Сумма цифр числа: {SumNum(ReadInt("Введите число: "))}");