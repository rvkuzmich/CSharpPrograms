// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Akkerman (int num1, int num2)
{
    if (num1 == 0) return num2+1;
    else if (num1>0 && num2==0) return Akkerman (num1-1, 1);
    else return Akkerman (num1-1, Akkerman(num1, num2-1));
}

int num1 = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите второе число: ");
System.Console.WriteLine($"Результат вычисления функции Аккермана равен {Akkerman(num1, num2)}");