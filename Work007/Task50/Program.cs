// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CreateArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(-10, 11);
    }
  }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}
int CheckElement(int[,] arr, int num)
{
  int position = -1;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] == num)
      {
        position = i*arr.GetLength(1)+j+1;
      }
    }
  }
  return position;
}
int[,] array = new int[3, 4];
CreateArray(array);
Console.Write("Please enter the number between -10 and 10: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
int pos = CheckElement(array, number);
if (pos==-1) Console.Write("There is no such element in the array");
else Console.Write($"The position of the element {number} in array is {pos} or [ {pos/array.GetLength(0)-1} , {(pos-1)%4} ]");