// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. Напишите программу, которая будет построчно
//   выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillArrayWithRandom(int[,,] matrix, int[] sort, out int[] sort)
{
    int temp = 0;


    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                sort[temp] = matrix[i, j, k];
                Console.Write("-" + sort[temp]);
                temp++;
            }

        }
    }
    Console.WriteLine();


    return matrix;
}


int[,,] Sort(int[,,] matrix, int[] sort)
{
    int sizenew = (matrix.GetLength(2) + 1) * (matrix.GetLength(0) + 1) * (matrix.GetLength(1) + 1);
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temporary = matrix[i, j, k];
                for (int y = 0; y < sizenew; y++)
                    if (matrix[i, j, k] == sort[y])
                    {
                        matrix[i, j, k] = new Random().Next(10, 100);
                    }
            }

        }
    }
    return matrix;
}

void PrintArrayWithRandom(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]} ( {i} , {j} , {k} ) \t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}


Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z:");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[m, n, z];
int size = (matrix.GetLength(2) + 1) * (matrix.GetLength(0) + 1) * (matrix.GetLength(1) + 1);
int[] sort = new int[size];

FillArrayWithRandom(matrix, sort, out int[] sort);

Sort(matrix, sort);
PrintArrayWithRandom(matrix);




