// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

Console.Write(" Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int b = 2;
if (b<=N)
{
while (b<=N) 
    
{
    Console.Write(b+" ");
    b=b+2;
}
}
else Console.Write(" Неверное число ");