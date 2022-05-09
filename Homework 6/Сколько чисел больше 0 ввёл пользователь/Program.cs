//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите числа через запятую: ");
string a = Console.ReadLine()!;
string[] arr = a.Split(",");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int some = int.Parse(arr[i]);
    if(some > 0) count++;
}
System.Console.WriteLine($"Количество чисел больше 0 = {count}");



