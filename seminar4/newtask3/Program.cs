// Задача 28: Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Met(int number)
{
int met = 1;
for(int i = 1; i <= number; i++)
{
met*=i;
}
return met;
}

// Console.WriteLine("Enter number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int umn = 1;
// for(int i = 1; i <= a; i++)
// {
// umn *= i;
// }
// Console.WriteLine(umn);