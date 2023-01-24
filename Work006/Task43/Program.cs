// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("There are two lines given by equations: ");
Console.WriteLine("1) y = k1 * x + b1");
Console.WriteLine("2) y = k2 * x + b2");
double[,] num = new double [2,2];
for (int i=0; i<num.GetLength(0); i++)
{
  string coeff = "k";
  for (int j=0; j<num.GetLength(1); j++)
  {
    Console.Write($"Please enter {coeff}{i+1}: ");
    num[i,j] = Convert.ToInt32(Console.ReadLine());
    coeff = "b";
  }
}
if (num[0,0]==num[1,0]) Console.WriteLine("Lines are not crossing");
else
{
  double x = Math.Round((num[1,1]-num[0,1])/(num[0,0]-num[1,0]),2);
  double y = Math.Round(num[0,0]*x+num[0,1],2);
  Console.WriteLine($"Lines are crossing in ({x}, {y})");  
}
