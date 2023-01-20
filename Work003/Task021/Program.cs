// Задача 21
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int[] A = new int [3];
int[] B = new int [3];
Console.WriteLine("Please enter coordinates of the 1st point:");
Console.Write("X: ");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
A[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
A[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter coordinates of the 2nd point:");
Console.Write("X: ");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
B[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
B[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow((B[0]-A[0]),2)+Math.Pow((B[1]-A[1]),2)+Math.Pow((B[2]-A[2]),2)),3);
Console.WriteLine($"The distance between two dots "
                   +$"with coordinates ({A[0]},{A[1]},{A[2]}) and "
                   +$"({B[0]},{B[1]},{B[2]}) is {distance}");
