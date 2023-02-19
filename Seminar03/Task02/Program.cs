// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.Write("Введите номер четверти координатной плоскости ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    System.Console.WriteLine("Диапазон возможных координат точек x > 0, y > 0");    
}
else if (num == 2)
{
    System.Console.WriteLine("Диапазон возможных координат точек x < 0, y > 0");
}
else if (num == 3)
{
    System.Console.WriteLine("Диапазон возможных координат точек x < 0, y < 0");
}
else if (num == 4)
{
    System.Console.WriteLine("Диапазон возможных координат точек x > 0, y < 0");
}
else System.Console.WriteLine("Четверти всего 4!");



// System.Console.Write("Введите номер четверти ");
// int number = Convert.ToInt32(Console.ReadLine());
// string[] strArray = {"x > 0 && y > 0", "x < 0 && y > 0", "x < 0 && y < 0","x > 0 && y < 0", "Такой четверти нет"};

// if(number > 0 && number < 5)
// {
//   System.Console.WriteLine(strArray[number-1]);
// }
// else
// {
//   System.Console.WriteLine("Такой четверти не существует");
// }