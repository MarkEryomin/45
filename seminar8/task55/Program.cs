// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.


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

int[,] FillNewArray(int[,] newMatrix, int n, int m, int[,]matrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newMatrix[i, j] = matrix[j,i];
            Console.Write(newMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return newMatrix;
}

int m = new Random().Next(3, 7);
int n = new Random().Next(3, 7);
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);

int [,] newMatrix=new int [n,m];
FillNewArray( newMatrix, n, m, matrix);
