/*  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98     С МЕТОДАМИ */

int randomNumber = GetRandomNumber(100, 999);  // вызов метода рандома
Console.WriteLine(randomNumber);
Console.WriteLine(DeleteSecondNumber(randomNumber)); // вызов метода удаления второго числа

int DeleteSecondNumber(int number)  // метод для удаления второго числа
{
int firstDigit = randomNumber / 100;
int lastDigit = randomNumber % 10;
return firstDigit * 10 + lastDigit;
}

int GetRandomNumber(int min, int max)  // метод рандома
{
return new Random().Next(min, max + 1);
}