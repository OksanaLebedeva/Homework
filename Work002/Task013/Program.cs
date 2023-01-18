Console.Clear();
Console.Write("Please enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = -1;
if (Math.Abs(num)>99)
{
  if (Math.Abs(num)<1000) result = Math.Abs(num) % 10;
  else if (Math.Abs(num)<10000) result = (Math.Abs(num) /10) % 10;
  else if (Math.Abs(num)<100000) result = (Math.Abs(num) /100) % 10;
  else if (Math.Abs(num)<1000000) result = (Math.Abs(num) /1000) % 10;
  else if (Math.Abs(num)<10000000) result = (Math.Abs(num) /10000) % 10;
  Console.Write("The third digit from the left is ");
  Console.WriteLine(result);
} 
else
{
  Console.WriteLine("There is no third digit in this number");
}