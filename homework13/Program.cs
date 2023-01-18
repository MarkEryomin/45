// Напишите программу, которая задаёт массив из 8 элементов и
//  выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
{
    array[i]=new Random().Next(1,100);
    Console.Write(array[i]+" ");
}
return array;
}


int[]array1=new int [8];
array1=FillArray(array1);

