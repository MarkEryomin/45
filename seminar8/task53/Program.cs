// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

void FillArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
        
    }
}

void PrintArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);


int temp = 0;

for(int i = 0; i < matrix.GetLength(1); i++)
{
    temp = matrix[0,i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = temp;
}
Console.WriteLine();
PrintArrayWithRandom(matrix);







// // Задача 55: Задайте двумерный массив. 
// // Напишите программу, которая заменяет строки на столбцы.






// int[,] FillArrayWithRandom(int[,] matrix, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 11);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return matrix;
// }

// int[,] FillNewArray(int[,] newMatrix, int n, int m, int[,]matrix)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             newMatrix[i, j] = matrix[i,j];
//             Console.Write(newMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return newMatrix;
// }

// int m = new Random().Next(3, 7);
// int n = new Random().Next(3, 7);
// int[,] matrix = new int[m, n];
// FillArrayWithRandom(matrix, m, n);

// int [,] newMatrix=new int [m,n];
// FillNewArray( newMatrix, n, m, matrix);


