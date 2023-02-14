// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// First option - array is entered by user
Console.Write("How many numbers? ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] arr = new int[num];
for (int i=0; i<num; i++)
{
  Console.Write($"Please enter {i+1} number: ");
  arr[i] = Convert.ToInt32(Console.ReadLine());
  if (arr[i]>0) count++;
}
Console.WriteLine($"There are {count} positive numbers");

// Second option - array was pre-entered
void Pr 
}
int[] arr2 = {-1, 0, 5, 7, -10, 18, -34, 55};
Console.WriteLine();
Console.Write("Initial array: [");
PrintArray(arr2);

int count2 = 0;
for (int i=0; i<arr2.Length; i++)
{
  if (arr2[i]>0) count2++;
}
Console.WriteLine($"There are {count2} positive numbers");