// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string PrintNumber (int a)
{
    if (a == 1) return "1";
    else return $"{a}, " + $"{PrintNumber(a-1)}";
} 
Console.Write("Please enter number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Numbers between {x} and 1 = '{PrintNumber(x)}'");