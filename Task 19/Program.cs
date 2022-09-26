/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int oldValue = number;
int newValue = 0;

if (oldValue > 9999 && oldValue < 100000)
{
    while (number > 0)
    {
        int dig = number % 10;
        newValue = newValue * 10 + dig;
        number = number / 10;
    }
    if (newValue == oldValue)
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");
}
else
    Console.WriteLine("Число не является пятизначным.");