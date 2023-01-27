// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный 
// словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int count0=0;
int count1=0;
int count2=0;
int count3=0;
int count4=0;
int count5=0;
int count6=0;
int count7=0;
int count8=0;
int count9=0; 

int[,] FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
            if (matrix[i,j]==0)
          {
            count0++;
          }
          else if (matrix[i,j]==1) 
          {
            count1++;
          } 
          else if (matrix[i,j]==2) 
          {
            count2++;
          } 
          else if (matrix[i,j]==3) 
          {
            count3++;
          } 
          else if (matrix[i,j]==4) 
          {
            count4++;
          } 
          else if (matrix[i,j]==5) 
          {
            count5++;
          } 
          else if (matrix[i,j]==6) 
          {
            count6++;
          } 
          else if (matrix[i,j]==7) 
          {
            count7++;
          } 
          else if (matrix[i,j]==8) 
          {
            count8++;
          } 
          else if (matrix[i,j]==9) 
          {
            count9++;
          } 
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



    Console.WriteLine($"0 встречается {count0} раз");
    Console.WriteLine($"1 встречается {count1} раз");
    Console.WriteLine($"2 встречается {count2} раз");
    Console.WriteLine($"3 встречается {count3} раз");
    Console.WriteLine($"4 встречается {count4} раз");
    Console.WriteLine($"5 встречается {count5} раз");
    Console.WriteLine($"6 встречается {count6} раз");
    Console.WriteLine($"7 встречается {count7} раз");
    Console.WriteLine($"8 встречается {count8} раз");
    Console.WriteLine($"9 встречается {count9} раз");
