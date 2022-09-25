// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int m = new Random().Next(3, 7);
int n = new Random().Next(3, 7);
int [, ] array = new int [m, n];
FillArray (array);
PrintArray (array);
ArithmeticMeanColumn (array);

void FillArray (int [, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10, 100);
    }
}


void PrintArray(int [, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void ArithmeticMeanColumn (int [, ] array)
{
    for (int j = 0; j < array.GetLength(1); j++) 
            {
                float summ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    summ += array[i, j];
                }
                Console.WriteLine($"Cреднее арифметическое элементов {j + 1} столбца = {Math.Round(summ / array.GetLength(0), 1)}");
            }
}