// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Please enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("The biggest entered number is: ");
int max = num1;
if(num1>num2)
{
  max=num1;
}
else
{
  max=num2;
}
Console.WriteLine(max);