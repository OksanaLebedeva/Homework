// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void GenerateArray(int[] arr)
{
  for (int i=0; i<arr.Length; i++)
  {
    arr[i] = new Random().Next(-19,20);
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
int FindMax (int[] array)
{
  int maxElement = array[0];
  for (int i=1; i<array.Length; i++)
  {
    if (array[i]>maxElement) maxElement = array[i];
  }
  return maxElement;
}
int FindMin (int[] array)
{
  int minElement = array[0];
  for (int i=1; i<array.Length; i++)
  {
    if (array[i]<minElement) minElement = array[i];
  }
  return minElement;
}
int[] ourArray = new int[10];
GenerateArray(ourArray);
PrintArray(ourArray);
Console.WriteLine($"Difference between MAX element '{FindMax(ourArray)}' "
                    +$"and MIN element '{FindMin(ourArray)}' is: {FindMax(ourArray)-FindMin(ourArray)}");