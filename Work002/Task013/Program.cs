// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Please enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;

if (Math.Abs(num) > 99)
{
  int divider = 100;
  while (num1 / divider > 10)
  {
    num1 = num1 / 10;
  }
  Console.Write("The third digit from the left is ");
  Console.WriteLine(num1 % 10);
}
else
{
  Console.WriteLine("There is no third digit in this number");
}