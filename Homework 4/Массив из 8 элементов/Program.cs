// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(int.MinValue, int.MaxValue);
    System.Console.Write(mass[i] + " ");

}
