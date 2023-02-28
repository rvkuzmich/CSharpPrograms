// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void TriangleCheck(int[] array)
{
    if (array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[1] + array[2] > array[0])
    {
        System.Console.WriteLine("Yes");
    }
    else System.Console.WriteLine("No");
}

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int[] triangle = InputArray("Введите 3 числа: ");
PrintArray(triangle);
TriangleCheck(triangle);
