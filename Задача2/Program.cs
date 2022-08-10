/*  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98   */

int randomNumber = GetRandomNumber(100, 999); //вызов функции рандом
Console.WriteLine(randomNumber);

Console.Write(randomNumber / 100); // находим первое число, выводим
Console.Write(randomNumber % 10); // находим последнее число, выводим


int GetRandomNumber(int min, int max) // функция рандом
{
return new Random().Next(min, max + 1);
}

