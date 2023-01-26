// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координату по X первой точки :");
int Xa=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y первой точки :");
int Ya=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по X второй точки :");
int Xb=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y второй точки :");
int Yb=Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2));

Console.WriteLine("Расстояние между точек : "+ Math.Round(result , 2 ));