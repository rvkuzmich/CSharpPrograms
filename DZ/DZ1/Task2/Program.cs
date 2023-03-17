// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine($"Число {a} является большим, а число {b} - меньшим");
}
else
{
    System.Console.WriteLine($"Число {b} является большим, а число {a} - меньшим");
}