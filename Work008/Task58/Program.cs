// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
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
int[,] MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arr3[i, j] = arr3[i,j] + arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Important notice! Number of columns in matrix A should be equal");
Console.WriteLine($"to number of lines in matrix B. Only then they can be multiplied!");
int[,] array1 = new int[2, 3];
int[,] array2 = new int[3, 4];
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("1st matrix: ");
CreateArray(array1);
PrintArray(array1);
Console.WriteLine("2nd matrix: ");
CreateArray(array2);
PrintArray(array2);
if (array1.GetLength(1)==array2.GetLength(0))
{
    Console.WriteLine("Result of multiplication of these matrices is: ");
    PrintArray(MultiplyArrays(array1, array2));
}
else Console.WriteLine("Impossible to multiply matrices");