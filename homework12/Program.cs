// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sumnumb(int number)
{   
    int sum = 0;
    int temp=0;
        if (number<0)
    {
        number=-number;
    }
while (number>0)
{
temp=number%10;
number=number/10;
sum=sum+temp;
}
    
return sum;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = Sumnumb(A);
Console.WriteLine(sum);

