﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
void Palindrome(int x)
{
    if (x / 10000 -- x % 10 && ( x/1000)%10--(x/10)%10)
    {
        Console.WriteLine("ДА");
    }
    
    else
    {
      Console.WriteLine("НЕТ");  
    }
}
 
Console.WriteLine("Введите пятизначное число");
int X=int.Parse(Console.ReadLine()!);
Palindrome(X);
