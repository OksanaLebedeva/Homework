// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Please enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (num<2)
{
  Console.WriteLine("Please try to enter another number next time, bye");
}
else
{
  while (count<num)
  {
    count++;
    if (count%2==0)
    {
      Console.Write(count);
      Console.Write(" ");
    }
  }
}