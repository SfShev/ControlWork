﻿Console.Write("Введите длину массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите наибольшее количество символов строк,которые хотите увидеть: ");
int numberofcharacters = Convert.ToInt32(Console.ReadLine());

string[] mainarray = new string[arraysize];
string[] resultarray = new string[arraysize];


string[] Collection(int elements)
{
    Console.WriteLine("Заполните массив: ");
    for (int i = 0; i < elements; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите элемент массива # {i + 1}: ");
        mainarray[i] = Console.ReadLine()!;
    }
    return mainarray;
}