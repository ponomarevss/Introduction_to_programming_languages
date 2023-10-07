/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

int InitFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArrayFromConsole(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        string message = $"Init array[{i}]: ";
        array[i] = InitFromConsole(message);
    }
    return array;
}

int CountPositives(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) 
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]\n");
}

Console.Write("Input a new array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayFromConsole(size);
Console.WriteLine($"An array with size {size}:");
PrintArray(array);
Console.WriteLine($"The array has {CountPositives(array)} positive elements");