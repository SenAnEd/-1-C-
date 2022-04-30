void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next();
    }
}
