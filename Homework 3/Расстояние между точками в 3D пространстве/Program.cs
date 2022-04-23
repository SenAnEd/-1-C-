// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
System.Console.Clear ();

int x1 = 4;
int y1 = 6;
int c1 = 9;
int x2 = 5;
int y2 = 9;
int c2 = 8;

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2));

System.Console.WriteLine(length);