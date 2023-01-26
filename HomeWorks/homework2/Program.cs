// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write(" Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите третье число: ");
int d = Convert.ToInt32(Console.ReadLine());
if (a>b && a>d)
{
    Console.WriteLine(a + " максимальное число");
}
else
if (b>d)
{
   Console.WriteLine(b + " максимальное число"); 
}
else Console.WriteLine(d + " максимальное число");