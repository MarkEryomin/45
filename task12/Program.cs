﻿Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a*a==b || b*b==a)
{
    Console.WriteLine("Одно из чисел является квадратом второго");
}
else Console.WriteLine("Числа не являются квадратами друг друга");
 
