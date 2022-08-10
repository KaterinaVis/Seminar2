//Программа , которая выводит случайное число отрезка [10, 99] и показывает наибольшую цифру этого числа.

int randomNumber = new Random ().Next (10,100); //метод рандом

Console.WriteLine(randomNumber); // вывести случайное число

int firstDigit = randomNumber / 10; // числа у нас двузначные, значит разделить на 10, первое число, остаток от деления на 10 - второе число
int secondDigit = randomNumber % 10;

if (firstDigit > secondDigit) // условие для вывода большего числа из двух
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}