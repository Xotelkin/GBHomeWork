// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int size = 20;
int [] array = new int[size];
FillAray(array);
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("");
Console.WriteLine($"Количество четных чисел: {CountEven(array)}");

void FillAray(int [] array)
{
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
}

int CountEven (int [] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}