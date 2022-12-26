// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по X первой точки :");
int Xa=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y первой точки :");
int Ya=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Z первой точки :");
int Za=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по X второй точки :");
int Xb=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y второй точки :");
int Yb=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Z второй точки :");
int Zb=Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2)+Math.Pow(Zb-Za,2));

Console.WriteLine("Расстояние между точек в 3D координатах : "+ Math.Round(result , 2 ));