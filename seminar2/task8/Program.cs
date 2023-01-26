
int number = new Random().Next(10,100);
Console.WriteLine(" Ваше случайное число : " +number);
int digit1= number/10;
int digit2= number%10;
if (digit1==digit2)
{
  Console.WriteLine($"Первая цифра {digit1}, равна второй {digit2}");  
}
if (digit1>digit2)
{
    Console.WriteLine($"Первая цифра {digit1}, больше второй");

}
else Console.WriteLine($"Вторая цифра {digit2}, больше первой");
