/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

Console.WriteLine("Введите число ");
String input = Console.ReadLine();
int number = Convert.ToInt32(input);
int a = 7;
int b = 23;

if (number % a ==0 && number % b ==0)
{
    Console.WriteLine("Кратно");
}
else

{
Console.WriteLine("Не кратно ");
}