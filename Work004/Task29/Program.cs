// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void GenerateArray(int[] arr)
{
  for (int i=0; i<arr.Length; i++)
  {
    arr[i] = new Random().Next(0,100);
  }
}
void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i=0; i<array.Length; i++)
  {
    Console.Write($"{array[i]}");
    if (i<array.Length-1) Console.Write(", ");
    else Console.Write("");
  }
  Console.Write("]");
}
int[] ourarray = new int[8];
Console.WriteLine($"Please choose 'Y' or 'y' to enter array manually or anything else to generate it randomly: ");
string answer = Console.ReadLine(); 
if (answer == "Y"||answer=="y")
{
  for (int i=0; i<ourarray.Length; i++)
  {
    Console.WriteLine($"Number {i+1} is: ");
    ourarray[i]=Convert.ToInt32(Console.ReadLine());
  }
}
else GenerateArray(ourarray);
Console.Write($"Our array is: ");
PrintArray(ourarray);