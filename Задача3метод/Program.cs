/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно     С ИСПОЛЬЗОВАНИЕМ МЕТОДА */

int firstNumber = ReadInt("Первое число: "); // вызываем метод
int secondNumber = ReadInt("Второе число: "); // вызываем метод

int remainderOfDivision = firstNumber % secondNumber;
if (remainderOfDivision == 0)
{
Console.WriteLine("Числа кратны");
}
else
{
Console.WriteLine("Числа не кратны, остаток от деления - " + remainderOfDivision);
}

int ReadInt(string message)  // метод конвертации из ввода в число
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}