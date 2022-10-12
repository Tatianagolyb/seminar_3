﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cube(int n)
{
    for (int i=1; i<= n; i++)
        {
            Console.WriteLine($"{Math.Pow(i,3)}");
           
        }
}
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Cube(N);
