// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 99 || num >= 1000)
{
    System.Console.WriteLine("Введено не трехзначное число");
}
else
{
    int divnum = num / 10;
    System.Console.WriteLine($"Вторая цифра вашего числа: {divnum % 10}");
}