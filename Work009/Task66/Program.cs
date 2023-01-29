// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumBetweenNumbers (int a, int b)
{
    if (a == b) return b;
    else return a+SumBetweenNumbers(a+1, b);
} 
Console.Write("Please enter 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers between {num1} and {num2} = '{SumBetweenNumbers(num1, num2)}'");