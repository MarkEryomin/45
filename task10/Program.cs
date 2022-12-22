Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
if (a%b==0)
{
 Console.WriteLine($"Число {a} , кратное {b}");   
}
else Console.WriteLine("Не кратно, остаток : "+a%b);
}
else Console.WriteLine("Ошибка: второе число больше первого");
