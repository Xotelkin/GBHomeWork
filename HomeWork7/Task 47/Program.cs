// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = Promt("Введите количество строк: ");
int n = Promt("Введите количество столбцов: ");
double [, ] array = new double [m, n];
FillArray (array);
PrintArray (array);


void FillArray (double [, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().Next(10, 100) + new Random().NextDouble(), 1);
    }
}


void PrintArray(double [, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}


int Promt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
