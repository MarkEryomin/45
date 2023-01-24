// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void Treug(int A, int B, int C)
{
if(A < B + C && B < A + C && C < A + B)
{
Console.WriteLine("Треугольник существует");
}
else
{
Console.WriteLine("Треугольник не существует");
}
}

Console.WriteLine("Введите длину первой стороны");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int C = Convert.ToInt32(Console.ReadLine());

Treug(A, B, C);
