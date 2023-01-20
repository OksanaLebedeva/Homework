// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int amount = 5;
Console.Write($"Please enter {amount}-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] digit = new int[amount];
if ((num>9999)&&(num<100000))
{
  digit[amount-1] = num % 10;
  int numAdd = num;
  for (int i=amount-2; i>=0; i--)
  {
    numAdd = numAdd / 10;
    digit[i] = numAdd % 10;
  }
    if (digit[0]==digit[4]&&digit[1]==digit[3]) Console.WriteLine($"{num} is a palindrome!");
  else Console.WriteLine($"{num} is NOT a palindrome...");
}
else
{
  Console.WriteLine("Please try again");
}