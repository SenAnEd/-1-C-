// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
Console.Clear ();

int a = new Random().Next(100,1000);

System.Console.WriteLine(a);

int b = a / 100;

int c = a % 10;

System.Console.WriteLine($"{b}{c}");

 
