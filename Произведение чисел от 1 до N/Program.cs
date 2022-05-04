// Напишите программу которая на вход принимает число N и считает произведение чисел от 1 до N

// Первый способ через цикл while:
// Console.Clear();
// System.Console.Write("Введите число N: ");
// int N = int.Parse(System.Console.ReadLine());
// int comp = 1;
// int i = 1;

// while(i <= N)
// {
//     comp = i*comp;
//     Console.WriteLine($"{comp} ");
//     i++;
// }
// System.Console.WriteLine($"Произведение от 1 до N равно: {comp}");

// Второй способ через цикл for:

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int pN = 1;
for(int i = 1; i<=N; i++)
{
Console.WriteLine(i);
pN = pN*i;
}
Console.WriteLine(pN);