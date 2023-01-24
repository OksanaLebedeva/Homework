// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
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