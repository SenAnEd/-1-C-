// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
if (a/100==0)
{
    System.Console.WriteLine($"Третьей цифры в заданном числе нет");
}
else
{
 while(a/1000> 0)
 {
    a= a/10;
 }
System.Console.WriteLine($"Третья цифра в заданном числе: {a % 10}");
}



