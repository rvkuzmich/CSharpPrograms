// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] DigitsArray(int n)
{
int[] digits = new int[1 + (int)Math.Log10(n)];
    for (int index = digits.Length - 1; index >= 0; index--)
    {
        int digit;
        n = Math.DivRem(n, 10, out digit);
        digits[index] = digit;
    }
    digits.Reverse();
    return digits;
}

int DigitSum(int[] digit)
{
    int sum = 0;
    for (int i = 0; i < digit.Length; i++)
    {
        sum = sum + digit[i];
    }
    return sum;
}
System.Console.WriteLine($"Сумма цифр вашего числа - {DigitSum(DigitsArray(ReadInt("Введите желаемое число ")))}");
