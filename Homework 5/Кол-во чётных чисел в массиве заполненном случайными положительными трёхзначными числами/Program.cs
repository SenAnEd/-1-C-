// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100,1000);
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
void CountPosNumbersArray(int [] array)
{
int count=0;
for (int i = 0; i < array.Length; i++)
{
  if(array[i]%2==0) count++;
}
System.Console.WriteLine($"Количество четных чисел в массиве {count}");
}

Console.Clear();
int [] mass = new int [5];
FillArray(mass);
PrintArray(mass);
CountPosNumbersArray(mass);


