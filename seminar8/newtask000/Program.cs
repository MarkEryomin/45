// Задача 53: Задайте двумерный массив. Напишите
//  программу, которая поменяет
//  местами первую и последнюю строку массива.

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

void PrintArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int m = new Random().Next(3, 7);
int n = new Random().Next(3, 7);
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
int temp = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    temp = matrix[0, i];
    matrix[0, i] = matrix[m - 1, i];
    matrix[m - 1, i] = temp;
}

PrintArray(matrix, m, n);
