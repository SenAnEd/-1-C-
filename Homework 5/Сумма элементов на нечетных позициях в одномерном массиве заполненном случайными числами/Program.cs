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
void SummNegArray( int [] array)
{
int summ=0;
for (int i = 1; i < array.Length; i=i+2)
{
  summ += array [i];
}
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {summ} ");
}

Console.Clear();
int [] mass = new int [5];
FillArray(mass);
PrintArray(mass);
SummNegArray(mass);