int a = 18;

int b = 150;

int max = a;

int min = b;

if (b > max) 
{
    max = b; min = a;
}
System.Console.WriteLine($"Максимальноe {max }  Минимальное {min }" );
