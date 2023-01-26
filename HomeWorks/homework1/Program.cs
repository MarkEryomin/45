// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

Console.Write(" Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a + " больше чем " + b);
    Console.WriteLine("а " + b + " меньше чем " + a);
}
else
{
    Console.WriteLine(b + " больше чем " + a);
    Console.WriteLine("а " + a + " меньше чем " + b);
}

