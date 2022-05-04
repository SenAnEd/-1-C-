// Напишите цикл, который принимает на вход два числа A и B, и возводит число A в натуральную степень B

Console.Clear();
System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
int N = A;
for (int i = 1; i < B; i++)
{
    N = A*N;
}
Console.WriteLine($"Число {A} в степени {B} равно {N}");