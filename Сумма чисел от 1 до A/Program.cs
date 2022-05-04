// Напишите программу которая принимает на вход число А и выдает сумму чисел от 1 до А

// Первый способ:
//Console.Clear();
// System.Console.Write("Введите число А: ");
// int A = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i < A; i++)
// {
//     sum += i;
//     System.Console.WriteLine((sum));
// }
// System.Console.WriteLine();

// Второй способ через функцию:
// Console.Clear();
int SumOfNumbers(int N)
{
    int sum = 0;
    for (int i = 1; i <= N; i++)
    {
        sum += i;
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
    return sum;
}

// System.Console.Write("Введите число А: ");
// int A = int.Parse(Console.ReadLine());
// int s = SumOfNumbers(A);
// System.Console.WriteLine(s);

// Третий способ через функции:

Console.Clear();
System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(SumOfNumbers(A));
