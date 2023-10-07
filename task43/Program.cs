/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
*/

double InitFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[] CalculateIntersection(double k1, double b1, double k2, double b2)
{
    double[] point = new double[2];
    /* k1 * x + b1 = k2 * x + b2 */
    /* (k1 - k2) * x = b2 - b1 */
    point[0]= (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
}

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write("\b\b)\n");
}

double k1 = InitFromConsole("k1 = ");
double b1 = InitFromConsole("b1 = ");
double k2 = InitFromConsole("k2 = ");
double b2 = InitFromConsole("b2 = ");
double[] point = CalculateIntersection(k1, b1, k2, b2);
Console.Write("The intersection point is: ");
PrintArray(point);