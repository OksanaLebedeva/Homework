// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
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
void SelectionReverse(int[,] array)
{
    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[index,j] > array[index,maxPosition]) maxPosition = j;
            }
            int temporary = array[index, i];
            array[index, i] = array[index, maxPosition];
            array[index, maxPosition] = temporary;
        }
    }
}

int[,] array = new int[3, 4];
Console.WriteLine("Array: ");
CreateArray(array);
PrintArray(array);
Console.WriteLine("New array: ");
SelectionReverse(array);
PrintArray(array);