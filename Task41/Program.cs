﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int[] ReadInt()
{
    int i = 0;
    int[] array = new int[10];
    for(int j = 0; j != -111;)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        j = num;
        if(j != -111) array[i] = num;
        i++;
    }
    return array;
}

int PositivNumberInArray(int[] arr)
{
    int positivNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) positivNumber++;
    }
    return positivNumber;
}

Console.WriteLine("Введите числа (для того, чтобы закончить ввод чисел, введите -111): ");
int[] array = ReadInt();
Console.WriteLine();

int positivNumber = PositivNumberInArray(array);
Console.WriteLine($"Количество введеных положительных чисел -> {positivNumber} ");