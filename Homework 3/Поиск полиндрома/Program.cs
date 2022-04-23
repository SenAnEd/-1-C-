// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a / 10000 == a % 10)
{
    if (a / 1000 % 10 == a / 10 % 10)
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}
