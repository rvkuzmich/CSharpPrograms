﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите желаемое число: ");
int N = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// if (N > 0)
// {
//     while (index <= N)
//     {
//         if (index % 2 == 0)
//         {
//             System.Console.Write(index + " ");
//             index++;
//         }
//         else index++;

//     }
// }
// else
// {
//     while (index >= N)
//     {
//         // if (index == 0) // на случай, если 0 не является четным числом
//         // {
//         //     index = index -1;
//         // }
//         if (index % 2 == 0)
//         {
//             System.Console.Write(index + " ");
//             index = index - 1;
//         }
//         else index = index - 1;
//     }
// }

for (int i=2, i<=N, i+=2)
{
    System.Console.WriteLine(i);
}