// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void GenerateArray(int[] arr)
{
  for (int i=0; i<arr.Length; i++)
  {
    arr[i] = new Random().Next(-9,10);
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
int SumOddPosition(int[] array)
{
  int sum = 0;
  for (int i=0; i<array.Length; i++)
  {
    if ((i+1)%2==1) sum = sum + array[i];
  }
  return sum;
}

int[] ourarray = new int[10];
GenerateArray(ourarray);
PrintArray(ourarray);
Console.WriteLine($"Sum of elements on odd positions is: {SumOddPosition(ourarray)}");