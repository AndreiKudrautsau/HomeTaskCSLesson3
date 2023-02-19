// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для вывода таблицы кубов чисел от 1 до заданного числа");
int number = Convert.ToInt32(Console.ReadLine());

void Multiply3 (int num)
{
    Console.WriteLine("Число       Куб числа");
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count, 7} {Math.Pow (count, 3), 7}");
    }
}

Multiply3 (number);