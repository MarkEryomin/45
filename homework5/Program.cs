// Задача 10: Напишите программу, которая принимает на вход
//  трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите какой использовать вариант");

int number = new Random().Next(100,1000);
Console.WriteLine(" Ваше случайное число : " +number);

int Var = Convert.ToInt32(Console.ReadLine());
int num2 =0;
switch (Var)
{
    case 1:
       
        int num23=number%100;
        num2=num23/10;
        Console.WriteLine("Второе число : "+num2);
        break;

    case 2:
    
        int num12=number/10;
        num2=num12%10;
        Console.WriteLine("Второе число : "+num2);
        break;

    case 3:
    
        string STR =Convert.ToString(number);
        Console.WriteLine("Второе число : "+ STR[1]);
        break;


}

