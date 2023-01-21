// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDigits (int number)
{
  int result = 0;
  int additional = 0;
  while (number > 0)
  {
    additional = number % 10;
    result = result + additional;
    number = number / 10;
  }
  return result;
}
Console.Clear();
Console.Write("Please enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in '{num}' is {SumDigits(num)}");