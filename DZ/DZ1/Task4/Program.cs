﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    System.Console.WriteLine($"Максимальным числом является {a}");
}
else if (b > a && b > c)
{
    System.Console.WriteLine($"Максимальным числом является {b}");
}
else
{
    System.Console.WriteLine($"Максимальным числом является {c}");
}