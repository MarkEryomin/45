// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray (int[] array)
{
    
    for (int i=0;i<array.Length;i++)
    {
        Console.WriteLine("Введите число "+(i+1));
        array[i]=Convert.ToInt32(Console.ReadLine());
       
    }
    return array;
} 

int positive =0;
Console.WriteLine("Введите количество чисел :");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
FillArray(array);
Console.WriteLine(string.Join(", ", array));
for (int i=0;i<array.Length;i++)
{
    if (array[i]>0) positive++;
}
Console.WriteLine("Положительных чисел : "+positive);