// Задача 65: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// void PrintNumber(int n, int m)
// {
//     if (n==m-1) return;
//     else 
//     {
//         PrintNumber(m-1,n);
//         Console.Write(m+" ");
//     }
// }

// Console.WriteLine("Введите число N : ");
// int N=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число M : ");
// int M=Convert.ToInt32(Console.ReadLine());
// PrintNumber(N,M);

void MNArray( int numbers1, int numbers2)
{
    if( numbers1 == numbers2 -1)
    {
    return; 
    }
MNArray(numbers1 -1, numbers2);
Console.Write(numbers1 + " ");
}
Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// if(n > m) printMToN(n, m);
// else if(n == m) Console.Write(n);
// else printMToN(m, n);
int n = Convert.ToInt32(Console.ReadLine());
MNArray(m,n);