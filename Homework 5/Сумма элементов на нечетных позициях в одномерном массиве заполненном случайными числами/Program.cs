// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1,10);
    }
}
void PrintArray (int []array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    System.Console.WriteLine();
}

Console.Clear();
int [] mass = new int [5];
FillArray(mass);
PrintArray(mass);
int summ=0;
for (int i = 1; i < mass.Length; i=i+2)
{
  summ += mass [i];
}
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {summ} ");