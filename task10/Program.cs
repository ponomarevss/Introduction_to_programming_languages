using System;
/**
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int num = new Random().Next(100, 1000);
int secondDigit = num / 10 % 10;
Console.WriteLine($"Second digit of {num} is {secondDigit}");