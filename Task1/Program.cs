﻿/* Задача 19. Напишите программу, которая принимает на вход пятизначное число
   и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да */

Console.WriteLine("Введите пятизначное число");
int x = int.Parse(Console.ReadLine()!);
int pali = 0, P = x;
while (x > 0) 
{
    pali = pali * 10 + x % 10; x /= 10;
}
Console.WriteLine(P == pali ? "Палиндром" : "не Палиндром");