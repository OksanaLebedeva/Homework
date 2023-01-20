// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Please enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<1) Console.WriteLine("Please try again, the number should be above 1.");
else 
{
  Console.Write($"{n} -> ");
  for (int i=1; i<=n; i++)
  { 
    Console.Write($"{Math.Pow(i,3)} ");
  }
}
