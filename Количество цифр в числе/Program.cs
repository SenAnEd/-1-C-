// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

// Первый способ

// Console.Clear();
// System.Console.Write("Введите число А: ");
// int A = int.Parse(Console.ReadLine());
// int count = 0;
// while(A>0)
// {
//     A=A/10;
//     count ++;
// }
// System.Console.WriteLine($"Количество цифр в заданном числе {count}: ");

// Второй способ через функцию:

Console.Clear();
System.Console.Write("Введите число А: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(A.ToString().Length);
