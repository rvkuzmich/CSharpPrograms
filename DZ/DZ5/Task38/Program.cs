// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(0, 99) + rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    System.Console.WriteLine($"Наибольший элемент массива {max}");
    return max;
}
double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    System.Console.WriteLine($"Наименьший элемент массива {min}");
    return min;
}
double Diff(double arg1, double arg2)
{
    double difference = Math.Abs(arg1 - arg2);
    return difference;
}
double[] newArray = GenerateArray(10);
PrintArray(newArray);
double maxElement = Max(newArray);
double minElement = Min(newArray);
double difference = Diff(maxElement, minElement);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");
