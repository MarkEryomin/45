
string [] quarters ={"x>0;y>0" ,"x<0;y>0" ,"x<0;y<0" ,"x>0;y<0 " };
Console.WriteLine("Введите в какой четверти точка :");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater>=1 && quater<= 4)
{
    Console.WriteLine(quarters[quater-1]);
}
else Console.WriteLine(" Не верно указана четверть, введите цифру от 1 до 4");