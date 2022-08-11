/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.WriteLine("Введите первое число ");
String input = Console.ReadLine();
int numberA = Convert.ToInt32(input);
Console.WriteLine("Введите число ");
input = Console.ReadLine();
int numberB = Convert.ToInt32(input);

if (numberA % numberB ==0 | numberB % numberA ==0)
{
    Console.WriteLine ("Одно число является квадратом другого");
}
else
{
Console.WriteLine ("Условие не соблюдается");
}