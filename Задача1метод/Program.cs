// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int randomNumber = GetRandomNumber(10, 99); //вызов функции рандом
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;
int maxDigit = Max(firstDigit, secondDigit); //вызов функции определения наибольшей цифры в числе

Console.WriteLine(maxDigit);


int GetRandomNumber(int min, int max) // функция рандом
{
return new Random().Next(min, max + 1);
}

int Max(int a, int b) // функия определения наибольшей цифры в числе
{
int max = 0;
if(a > b)
{
max = a;
}
else
{
max = b;
}
return max;
}