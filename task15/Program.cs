﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Input a week day number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 && a <= 7)
{
    if (a == 6 || a == 7) Console.WriteLine($"{a} is a holiday");
    else Console.WriteLine($"{a} is a workday");
}
else
{
    Console.WriteLine("Invalid argument");
}