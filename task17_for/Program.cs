// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<0)
{
    a=-a;
}
for (int index=1; index<=a; index++)
{
    Console.WriteLine(Math.Pow(index,2));
}
