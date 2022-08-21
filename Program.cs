/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество чисел M ");
int m = int.Parse(Console.ReadLine());
int[] arr = new int[m];
InputNumbers(m);
Console.WriteLine("Количество чисел больше 0 равно " + CheckArr(arr));

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
}

int CheckArr(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            res++;
        }
    }
    return res;
}

