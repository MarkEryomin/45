// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }

    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[a, b];
if (matrix1.GetLength(0) != matrix2.GetLength(1)) Console.WriteLine("Перемножение не возможно!!!");
else
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    FillArrayWithRandom(matrix1);
    // matrix1[0,0]=2;
    // matrix1[0,1]=4;
    // matrix1[1,0]=3;
    // matrix1[1,1]=2;
    PrintArray(matrix1);
    FillArrayWithRandom(matrix2);
    // matrix2[0,0]=3;
    // matrix2[0,1]=4;
    // matrix2[1,0]=3;
    // matrix2[1,1]=3;
    PrintArray(matrix2);

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    PrintArray(resMatrix);
}