// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("Среда");
}
else if (day == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (day == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (day == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}

switch (day){
    case 1:{
        System.Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        System.Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        System.Console.WriteLine("Среда");
        break;
    }
    default:
    {
        System.Console.WriteLine("Такого дня недели не существует");
        break;
    }
}