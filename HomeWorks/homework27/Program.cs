// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от
//   N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string NumbersRecRew(int a, int b)
{
    if (a <= b) return NumbersRecRew(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumbersRecRew(1, N));