// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
Console.Clear();
int[] mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 2);
    System.Console.Write(mass[i] + " ");

}
