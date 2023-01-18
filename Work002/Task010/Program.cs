Console.Clear();
Console.Write("Please enter the 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((Math.Abs(num) < 100))
{
  Console.WriteLine("There are less then 3 digits in the number");
}
else if (Math.Abs(num)>999)
{
  Console.WriteLine("There are more then 3 digits in the number");
}
else
{
  int result = (Math.Abs(num) / 10) % 10;
  Console.WriteLine($"Result is {result}");
}