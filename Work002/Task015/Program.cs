// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Please enter the number of the weekday: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num<1)||(num>7))
{
  Console.WriteLine("There is no such weekday");
}
else if ((num==6)||(num==7))
{
  Console.WriteLine("It is a WEEKEND!");
}
else
{
  Console.WriteLine("Still it is a working week");
}