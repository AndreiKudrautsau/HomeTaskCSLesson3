// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное натуральное число");
int number = Convert.ToInt32 (Console.ReadLine());

int number1  = Round (number);
if (number1 == 0) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} НЕ является палиндромом");

int Round (int num)
{
    return (num % 10) *10000 + ((num / 10) % 10) * 1000 + (((num / 100) % 10) *100) + ((num / 1000) % 10) * 10 + num / 10000 - num;  
}