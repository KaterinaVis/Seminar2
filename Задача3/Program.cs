/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно  */

Console.WriteLine("Введите первое число ");
String input = Console.ReadLine();
int numberA = Convert.ToInt32(input);
Console.WriteLine("Введите второе число ");
String input2 = Console.ReadLine();
int numberB = Convert.ToInt32(input2);

double div = numberA / numberB;

if (numberA % numberB ==0)
{
    Console.WriteLine("Кратно");
}
else

{
Console.WriteLine("Не кратно, остаток " + div);
}