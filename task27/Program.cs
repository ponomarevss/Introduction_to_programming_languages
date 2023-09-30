/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 
*/

int DigitsSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A sum of number {number} digits is {DigitsSum(number)}");