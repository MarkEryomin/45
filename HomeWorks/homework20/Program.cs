// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или
//  же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

int[,] FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}



int m = new Random().Next(3, 7);
int n = new Random().Next(3, 7);
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);

Console.WriteLine("Введите индекс строчки:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows>0 && columns>0)
{
    if (rows<=m&&columns<=n)
    {
        Console.WriteLine("Искомое значение : "+matrix[rows,columns]);
    }
    else Console.WriteLine("Такой ячейки нет!!!");
}
else Console.WriteLine("Такой ячейки нет!!!");