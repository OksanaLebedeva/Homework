// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
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
int MinSumByLine(int[,] arr)
{
    int result = 0;
    int minimum = 0;
    int[] sum = new int[arr.GetLength(1)];
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            sum[i] = sum[i] + arr[i,j];
        }
        if (i==0) minimum = sum[i];
        else
        {
            if (sum[i]<minimum)
            {
                result = i;
                minimum = sum[i];
            }
        }
        Console.WriteLine($"Sum of {i+1} line elements is {sum[i]}");
    }
    return result;
}

int[,] array = new int[4, 4];
Console.WriteLine("Array: ");
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Minimum sum of elements is in the {MinSumByLine(array)+1} line of the array");