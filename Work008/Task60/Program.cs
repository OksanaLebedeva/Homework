// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void CreatePlainArray(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        num = new Random().Next(0,10);
        if (ContainCheck(arr, num)==0) arr[i] = num;
        else i--;
    }
}
int ContainCheck (int[] arr, int number)
{
    int result = -1;
    for (int j=0; j<arr.Length; j++)
    {
        if (arr[j] != number) result = 0;
        else
        {
            result = 1;
            break;
        }
    } 
    return result;
}
void ModifyArray(int[]arr, int[,,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k=0; k<array.GetLength(2); k++)
            {
                array[i, j, k] = arr [count++];
            }       
        }
    }
}
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k=0; k<arr.GetLength(2); k++)
            {
                Console.Write($"{arr[j, k, i]} ({j},{k},{i}) ");
            }       
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = new int[2, 2, 2];
int[] arrayPlain = new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
Console.WriteLine("Array: ");
CreatePlainArray(arrayPlain);
ModifyArray(arrayPlain, array);
PrintArray(array);