Console.WriteLine("Введите трёхзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=100 && a<1000)
{
Console.WriteLine("Последняя цифра");
Console.WriteLine(a%10);
}
else Console.WriteLine("Неверная цифра");
