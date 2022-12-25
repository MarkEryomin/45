// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите ваше число ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вариант 1 или 2");
int Var = Convert.ToInt32(Console.ReadLine());
switch(Var)
    {
        case 1:
            if (number<0)
    {
number= -number;
    }
if (number<100)
{
    Console.WriteLine("В вашем числе,третьей цифры нет!!! ");
}
else 
{
    while (number>1000)
    {
        number=number/10;
    }
Console.WriteLine("Третья цифра числа :"+(number%10));
}
break;

case 2:

    if (number<0)
        {
            number=-number;
        }
    if (number<100)
    {
        Console.WriteLine("В вашем числе,третьей цифры нет!!! ");
    } 
    else
    {
        string STR = Convert.ToString(number);
        Console.WriteLine("Третья цифра числа :"+(STR[2]));
    }
    break;

    }
    

