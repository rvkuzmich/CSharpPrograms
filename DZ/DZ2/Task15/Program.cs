// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите номер дня недели: ");
int dayn = Convert.ToInt32(Console.ReadLine());
if (dayn < 1 || dayn > 7)
{
    System.Console.WriteLine("Такого дня недели не существует");
}
else if (dayn == 6 || dayn == 7)
{
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");