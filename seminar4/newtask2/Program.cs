// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int K(int number)
// {
// int k = 0;
// while (number > 0)
// {
// k ++;
// number = number/10;
// }
// return k;
// }

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int k = K(N);
// Console.WriteLine(k);


// Console.WriteLine("Enter number: ");
// string A = Convert.ToString(Console.ReadLine());
// int sum = 0;
// int b = A.Length;

// for(int i = 0; i < b; i++)
// {
// if(A[i] == '0' || A[i] == '1' || A[i]== '2' || A[i]== '3' || A[i]== '4' || A[i] == '5' || A[i] == '6' || A[i] == '7' || A[i] == '8' || A[i] == '9')
// {
// sum ++;
// }
// else
// {
// Console.Write("Так низя. Ошибка ");
// sum = 0;
// break;
// }
// }
// Console.WriteLine(sum);




// Console.WriteLine("Enter number: ");
// string a = Console.ReadLine();
// if(int.TryParse(a, out int A))
//  {
// Console.WriteLine(a.Length);
// } else 
// Console.WriteLine("Ошибка");


Алексей Свищев: // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// // for(int i = 0; A != 0; i++)
// // {
// // A/=10;
// // count++;
// // }

// // while(A > 0)
// // {
// // A/=10; // == A = A /10;
// // count++;
// // }
// Console.WriteLine(count);
Алексей Свищев: // Console.WriteLine("Enter number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int b = numb.ToString().Length;
// Console.WriteLine(b);

// Console.WriteLine("Enter number: ");
// string number = Console.ReadLine();
// int count = 0;
// bool ok = int.TryParse(number, out int A);
// Console.WriteLine(ok);
// if(int.TryParse(number, out int A))
// {
// while(A > 0)
// {
// A/=10; // == A = A /10;
// count++;
// }
// Console.WriteLine(count);
// }
// else
// Console.WriteLine("Ошибка");
Алексей Свищев: // string a = Console.ReadLine();
// if(int.TryParse(a, out int number)) {
// Console.WriteLine(a.Length);
// } else {
// Console.WriteLine("Ошибка");
// }