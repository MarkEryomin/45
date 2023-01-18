// Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B. 
// (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write(" Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите степень для возведения: ");
int b = Convert.ToInt32(Console.ReadLine());
int pov=1;
for (int i =1;i<=b;i++)
{
pov=pov*a;
}
Console.WriteLine(pov);