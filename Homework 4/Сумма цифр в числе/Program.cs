// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
int B = A % 10;
int C = 0;
int sum = 0;

while (A/10 > 0)
{
    A = A/10;
    C = A % 10;
    sum = sum+C;
}
System.Console.WriteLine($"{sum+B} ");

