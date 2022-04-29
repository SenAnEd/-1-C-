// Напишите программу которая на вход принимает число N и считает произведение чисел от 1 до N
Console.Clear();
System.Console.Write("Введите число N: ");
int N = int.Parse(System.Console.ReadLine());
int comp = 1;
int i = 1;

while(i <= N)
{
    comp = i*comp;
    Console.WriteLine($"{comp} ");
    i++;
}
System.Console.WriteLine($"Произведение от 1 до N равно: {comp}");
