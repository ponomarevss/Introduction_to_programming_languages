/* 
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
*/

int SumBetween(int m, int n)
{
    int min = Math.Min(m, n);
    int max = Math.Max(m, n);

    if (min == max) return min;
    return min + SumBetween(min + 1, max);
}

Console.Write("Input integer M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer N: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"SumBetween(M, N) = {SumBetween(a, b)}");