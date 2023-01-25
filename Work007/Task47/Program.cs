// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CreateArray(double[,] array, int m, int n)
{
  for (int i=0; i<m; i++)
  {
    for (int j=0; j<n; j++)
    {
      array[i,j] = Math.Round(new Random().Next(-10,10) + new Random().NextDouble(), 2);
    }
  }
}
void PrintArray (double[,] arr)
{
  for (int i=0; i<arr.GetLength(0); i++)
  {
    for (int j=0; j<arr.GetLength(1); j++) 
    {
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}
double[,] array = new double [3,4];
Console.WriteLine("Array: ");
CreateArray(array, array.GetLength(0), array.GetLength(1));
PrintArray(array);