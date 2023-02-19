// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Fact(int A)
{
    int result = 1;
    for (int i = 2; i <= A; i++)
    {
        result *= i;
    }
    return result;
}
System.Console.WriteLine(Fact(ReadInt("Введите желаемое число: ")));