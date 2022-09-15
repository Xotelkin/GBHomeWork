// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int size = 10;
int [] array = new int[size];
FillAray(array);
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine("");
Console.WriteLine($"Сумма элементов с нечетным индексом равна: {SummNumberUnvenIndex(array)}");


void FillAray(int [] array)
{
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 10);
}

int SummNumberUnvenIndex (int [] array)
{
    int summ = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 0)
            summ += array[i];
    }
    return summ;
}