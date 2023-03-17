// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + SumNum(num1 + 1, num2);
}
int num1 = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите второе число: ");
if (num1 < num2) System.Console.WriteLine($"Сумма чисел от {num1} до {num2} равна {SumNum(num1, num2)}");
else System.Console.WriteLine($"Сумма чисел от {num2} до {num1} равна {SumNum(num2, num1)}");