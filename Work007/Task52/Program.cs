// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void FindPrintAverages(int[,] arr)
{
  double[] averages = new double [arr.GetLength(1)];
  for (int i=0; i<arr.GetLength(1); i++)
  {
    for (int j=0; j<arr.GetLength(0); j++)
    {
      averages [i] = averages [i] + arr [j,i];
    }
    Console.Write($"{Math.Round(averages[i]/arr.GetLength(0),2)}  ");
  }
}

int[,] array = new int[6, 6];
int[] averages = new int[array.GetLength(1)];
CreateArray(array);
PrintArray(array);
Console.WriteLine("The average numbers for each column:");
FindPrintAverages(array);