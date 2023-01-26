Console.WriteLine("Введите в какой четверти точка :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Диапазон этой четверти :");
if (a==1)
{
  Console.WriteLine(" x>0;y>0 ");  
}
else if ( a==2)
{
   Console.WriteLine(" x<0;y>0 ");
  
}
else if ( a==3)
{
   Console.WriteLine(" x<0;y<0 ");
  
}
else if ( a==4)
{
   Console.WriteLine(" x>0;y<0  ");
  
}
else Console.WriteLine("Не верно указана четверть, введите цифру от 1 до 4");
