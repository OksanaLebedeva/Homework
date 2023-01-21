// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double Stepen(int a, int b)
{
  double result = Math.Pow(a,b);
  return result;
}
Console.Clear();
Console.Write("Please enter number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number '{numA}' in degree of '{numB}' will be {Stepen(numA, numB)}");