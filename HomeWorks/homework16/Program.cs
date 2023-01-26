// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7


double[] FillArrayWithRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * new Random().Next(10, 50), 2);
    }
    return array;
}



double[] array = new double[4];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
double diff = 0;
double min = array[0];
double max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }

}
diff = max - min;

Console.WriteLine("Разница между минимальным и максимальним эл-том:" + diff);