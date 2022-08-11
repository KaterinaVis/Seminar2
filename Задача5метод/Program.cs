// это задача 4 
/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

int number = ReadInt("Введите первое число: "); 
int firstDivider = 7;
int secondDivider = 23;

if(Multiple(number, firstDivider) && Multiple(number, secondDivider)) //вызов метода проверки кратности
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

bool Multiple(int a, int b) // метод определения кратности одного числа к другому
{
return a % b == 0;
}

int ReadInt(string message) // метод конвертации числа
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}