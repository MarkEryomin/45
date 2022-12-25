Console.WriteLine("Введите координату по X :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y :");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
  Console.WriteLine("Точка находится в первой четверти ");  
}
else if ( x<0 && y>0)
{
   Console.WriteLine("Точка находится во второй четверти ");
  
}
else if ( x<0 && y<0)
{
   Console.WriteLine("Точка находится в третьей четверти ");
  
}
else if ( x>0 && y<0)
{
   Console.WriteLine("Точка находится в четвёртой четверти ");
  
}