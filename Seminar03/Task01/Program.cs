System.Console.Write("Введите координату x ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if (x<0 && y>0)
{
    System.Console.WriteLine("Точка находится во второй четверти");
}
else if (x<0 && y<0)
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}
else if (x>0 && y<0)
{
    System.Console.WriteLine("Точка находится в четвертой четверти");
}
else
{
    System.Console.WriteLine("Точка лежит на координатных осях");
}


// int[] coords = new int[2];
// System.Console.Write("Введите X: ");
// coords[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("\nВведите Y: ");
// coords[1] = Convert.ToInt32(Console.ReadLine());

// if (coords[0] > 0 && coords[1] > 0)
// {
//     System.Console.WriteLine("Мы находимся в первой четверти");
// }
// else if (coords[0] < 0 && coords[1] > 0)
// {
//     System.Console.WriteLine("Мы находимся во второй четверти");
// }
// else if (coords[0] < 0 && coords[1] < 0)
// {
//     System.Console.WriteLine("Мы находимся в третьей четверти");
// }
// else if (coords[0] > 0 && coords[1] < 0)
// {
//     System.Console.WriteLine("Мы находимся в четвертой четверти");
// }
// else
// {
//     System.Console.WriteLine("Координата лежит на осях");
// }