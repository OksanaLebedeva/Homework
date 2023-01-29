// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akkerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return -1;
}
Console.Write("Please enter 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int check = Akkerman(num1, num2);
if (check==-1) Console.WriteLine("Numbers should be positive"); 
else Console.WriteLine($"Value of Akkerman function with {num1} and {num2} = '{check}'");