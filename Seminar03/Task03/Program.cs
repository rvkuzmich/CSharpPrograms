// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int[] coordsA = new int[2];
int[] coordsB = new int[2];
System.Console.WriteLine("Введите координату x точки A");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки A");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки B");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
double distance = Math.Round(Math.Sqrt(Math.Pow(coordsB[0] - coordsA[0], 2) + Math.Pow(coordsB[1]-coordsA[1], 2)), 2);
System.Console.WriteLine($"Расстояние между точками в плоскости равно {distance}");