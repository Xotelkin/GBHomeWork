// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int[8];
FillAray(array);
Console.WriteLine("[{0}]", string.Join(", ", array));

void FillAray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-1000, 1000);
}