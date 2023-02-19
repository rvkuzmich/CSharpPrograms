// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordA = new int[3];
int[] coordB = new int[3];
System.Console.WriteLine("Введите координату x точки A");
coordA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки A");
coordA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки A");
coordA[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки B");
coordB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
coordB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
coordB[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(coordB[0] - coordA[0], 2) + Math.Pow(coordB[1]-coordA[1], 2) + Math.Pow(coordB[2]-coordA[2], 2)), 2);
System.Console.WriteLine($"Расстояние между точками в пространстве равно {distance}");