// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
Console.Write("Please enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2==0)
  {
  Console.WriteLine("It is an EVEN number");
  }
else
{
  Console.WriteLine("It is an ODD number");
}