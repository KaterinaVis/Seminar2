﻿/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

int firstNumber = ReadInt("Введите первое число: "); // вызываем метод конвертации числа
int secondNumber = ReadInt("Введите второе число: ");

if(SqrNumber(firstNumber) == secondNumber || SqrNumber(secondNumber) == firstNumber) // вызываем метод квадрата числа
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}

int SqrNumber(int number) //  метод квадрата числа

{
return number * number;
}

int ReadInt(string message) //  метод конвертации числа
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}