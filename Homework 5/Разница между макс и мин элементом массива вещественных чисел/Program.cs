// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

void FillArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1,10);
    }
}
void PrintArray (double []array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    System.Console.WriteLine();
}

Console.Clear();
double [] mass = new double [5];
FillArray(mass);
PrintArray(mass);
double min = mass [0];
double max = mass [0];
for (int i = 1; i < mass.Length; i++)
{
if(mass[i]>max) max = mass [i];
if(mass[i]<min) min = mass [i];
}
System.Console.WriteLine($"Разница между максимальным элементом массива {max} и минимальным элементом массива {min} равна: {max-min} ");