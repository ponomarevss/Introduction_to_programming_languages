/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;
if (a / 100 > 0)
{
    while (a > 100)
    {
        thirdDigit = a % 10;
        a /= 10;  
    }
    Console.WriteLine($"The third digit is {thirdDigit}");
}
else
{
    Console.WriteLine("The number has no third digit.");
}