﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.Write("Введите число N ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for (int i = 1; i <= N; i++)
{
    System.Console.Write(Math.Pow(i, 2) + " ");
}
