// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] DefineLine(string text)
{
    System.Console.WriteLine(text);
    double[] array = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
    return array;
}
void CrossCoords(double[] array)
{
    double x = Math.Round((array[2]-array[0])/(array[1]-array[3]), 1);
    double y = Math.Round(array[1]*x+array[0], 1);
    System.Console.WriteLine($"Точка пересечения двух прямых находится в координатах {x}; {y}");
}
double[] newArray = DefineLine("Введите значения коэффициентов прямых b1, k1, b2 и k2 через пробел");
CrossCoords(newArray);