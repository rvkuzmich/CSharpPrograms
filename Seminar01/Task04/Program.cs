﻿// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int index = -N;
if (N > 0)
{
    while (index <= N)
    {
        System.Console.Write(index + " ");
        index++;
    }
}
else
{
    index = N;
    while (index <= -N)
    {
        System.Console.Write(index + " ");
        index++;
    }
}


// for (index = -N; index <= number; index++)
//{

//}