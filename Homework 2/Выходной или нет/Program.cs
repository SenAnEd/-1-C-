// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();

int a = new Random().Next(1, 8);

System.Console.WriteLine(a);

if (a == 6 | a == 7)
{
    System.Console.WriteLine("Выходной день");
}
else
    System.Console.WriteLine("Не выходной день");

