﻿/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

int PowAToB(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    return res;
}

Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result: {PowAToB(a, b)}");