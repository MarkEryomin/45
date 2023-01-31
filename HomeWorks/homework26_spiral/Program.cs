
// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int col = 4;
int row = 4;
int[,] spiral = new int[row, col];
col = 0;
row = 0;

while (spiral[row, col] <= 16)
{
    int temp=1;
    
    while (row < 4)
    {
        
        while (col < 4)
        {
            spiral[row, col] = temp;
            col++;
            temp++;

        }
        row++;
    }
}




    // FillSpiral(row-1,col);
    // FillSpiral(row,col-1);
    // FillSpiral(row+1,col);
    // FillSpiral(row,col+1);






