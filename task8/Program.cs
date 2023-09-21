/**
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
int counter = 1;
if (a > counter)
{
    Console.Write("Result: ");
    while (counter <= a)
    {
        if (counter % 2 == 0)
        {
            Console.Write($"{counter} ");
        }
        counter++;
    }
}