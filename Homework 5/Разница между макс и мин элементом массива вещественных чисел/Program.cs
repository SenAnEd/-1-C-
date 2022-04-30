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
void RasnMaxMinArray(double [] array)
{
double min = array [0];
double max = array [0];
for (int i = 1; i < array.Length; i++)
{
if(array[i]>max) max = array [i];
if(array[i]<min) min = array [i];
}
System.Console.WriteLine($"Разница между максимальным элементом массива {max} и минимальным элементом массива {min} равна: {max-min} ");
}

Console.Clear();
double [] mass = new double [5];
FillArray(mass);
PrintArray(mass);
RasnMaxMinArray(mass);

