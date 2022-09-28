// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты первой точки через запятую: ");
string str_point1 = Console.ReadLine();
string[] point1 = str_point1.Split(",");

Console.Write("Введите координаты второй точки через запятую: ");
string str_point2 = Console.ReadLine();
string[] point2 = str_point2.Split(",");

double diff_x = Convert.ToInt32(point2[0]) - Convert.ToInt32(point1[0]);
double diff_y = Convert.ToInt32(point2[1]) - Convert.ToInt32(point1[1]);
double diff_z = Convert.ToInt32(point2[2]) - Convert.ToInt32(point1[2]);

double dist = Math.Sqrt(Math.Pow(diff_x, 2) + Math.Pow(diff_y, 2) + Math.Pow(diff_z, 2));

Console.WriteLine($"Расстояние между точками: {Math.Round(dist, 2)}");