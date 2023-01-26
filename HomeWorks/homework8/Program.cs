// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine(" Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите какой использовать вариант");
int Var = Convert.ToInt32(Console.ReadLine());

switch (Var)
{
    case 1:
        if (number<0)
        {
            number=-number;
        }
       if (number>=10000 && number<100000)
       {
        int first = number/10000;
        int second= (number/1000)%10;
        int fourth=(number%100)/10;
        int fifth=number%10;
        if (first==fifth && second==fourth)
        {
            Console.WriteLine(" Ура, это ПАЛИНДРОМ !!!");
        }
        else Console.WriteLine(" Нет,обычное число");
       }
       else Console.WriteLine("!!!Не верно введено число!!!");
        break;

        case 2:

       if (number<0)
        {
            number=-number;
        }
       if (number>=10000 && number<100000)
       {
        int [] massive= {0,0,0,0,0};
        
        for (int i=4; i>=0;i--)
        {
            massive[i]=number%10;
            number=number/10;
        }
        if (massive[0]==massive[4] && massive[1]==massive[3])
        {
           Console.WriteLine(" Ура, это ПАЛИНДРОМ !!!"); 
        }
        else Console.WriteLine(" Нет,обычное число");
       }
       else Console.WriteLine("!!!Не верно введено число!!!");
       
       break;
        
       

}