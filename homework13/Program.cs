// Напишите программу, которая задаёт массив из 8 элементов и
//  выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] FillArrayRandom(int[] array)
// {
//     for(int i=0;i<array.Length;i++)
// {
//     array[i]=new Random().Next(1,100);
//     Console.Write(array[i]+" ");
// }
// return array;
// }


int[] FillArrayHand(int[] array)
{
    for(int i=0;i<array.Length;i++)
{
    int temp = i+1;
    Console.WriteLine("Введите "+ temp +" элемент массива");
    array[i]=Convert.ToInt32(Console.ReadLine());
    
}
return array;
}

void PrintArrayHand(int[] array)
{
    for(int i=0;i<array.Length;i++)
{
    Console.Write(" "+array[i]);
       
}
}

int[]array1=new int [8];
// array1=FillArrayRandom(array1);

array1=FillArrayHand(array1);
PrintArrayHand(array1);