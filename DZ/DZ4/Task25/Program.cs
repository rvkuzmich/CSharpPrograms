// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int a, int b)
{
    int pow = a;
    for (int i = 0; i < b-1; i++)
    {
        pow *= a;
    }
    return pow;
}

int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
System.Console.WriteLine(Pow(A, B));