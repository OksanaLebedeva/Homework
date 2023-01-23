// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void GenerateArray(int[] arr)
{
  for (int i=0; i<arr.Length; i++)
  {
    arr[i] = new Random().Next(99,1000);
  }
}
void PrintArray(int[] array)
{
  Console.Write($"Our array: [");
  for (int i=0; i<array.Length; i++)
  {
    Console.Write($"{array[i]}");
    if (i<array.Length-1) Console.Write(", ");
    else Console.Write("");
  }
  Console.WriteLine("]");
}
int CountEven(int[] array)
{
  int count = 0;
  for (int i=0; i<array.Length; i++)
  {
    if (array[i]%2==0) count++;
  }
  return count;
}
int[] ourarray = new int[10];
GenerateArray(ourarray);
PrintArray(ourarray);
Console.WriteLine($"Count of even elements is: {CountEven(ourarray)}");