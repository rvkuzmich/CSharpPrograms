// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите желаемое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 99)
{
    System.Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    int[] digits = new int[1 + (int)Math.Log10(num)];
    for (int index = digits.Length - 1; index >= 0; index--)
    {
        int digit;
        num = Math.DivRem(num, 10, out digit);
        digits[index] = digit;
    }
    digits.Reverse();
    System.Console.WriteLine($"Третья цифра вашего числа - {digits[2]}");

}