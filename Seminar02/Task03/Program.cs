// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int div = num2 % num1;
if (div == 0)
{
    System.Console.WriteLine("Второе число кратно первому");
}
else
{
    System.Console.WriteLine("Второе число не кратно первому, остаток "+div);
}