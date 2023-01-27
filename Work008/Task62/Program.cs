// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void CreatePlainArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
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
void FillArraySpiral(int[] arr, int[,] array)
{
    int numX = array.GetLength(1);
    int numY = array.GetLength(0);
    int col = 0;
    int leg = 0;
    while (col < arr.Length)
    {
        for (int j = 0 + leg; j < numX - 1 - leg; j++) // top row to the right
        {
            array[leg, j] = arr[col];
            col++;
        }
        for (int i = 0 + leg; i < (numY - 1 - leg); i++) // right column down
        {
            array[i, numX - 1 - leg] = arr[col];
            col++;
        }
        for (int j = numX - 1 - leg; j > 0 + leg; j--) // bottom row to the left
        {
            array[numY - 1 - leg, j] = arr[col];
            col++;
        }
        for (int i = numY - 1 - leg; i > 0 + leg; i--) // left column up
        {
            array[i, leg] = arr[col];
            col++;
        }
        if (col == arr.Length-1)
        {
            array[leg+1, leg+1] = arr[col];
            break;
        } 
        leg++;
    }
}

int[,] array = new int[5, 5];
int[] arrayPlain = new int[array.GetLength(0) * array.GetLength(1)];
Console.WriteLine("Plain array:");
CreatePlainArray(arrayPlain);
FillArraySpiral(arrayPlain, array);
Console.WriteLine("Spirally filled array:");
PrintArray(array);