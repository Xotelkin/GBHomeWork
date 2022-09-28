// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = Promt ("Введите количество строк в массиве: ");
int n = Promt ("Введите количество столбцов в массиве: ");
int[,] array = new int[m, n];
Random rnd = new Random();
FillArray (array);
PrintArray (array);
MinSummLine (array);
int minLineSumm = MinSummLine (array) + 1;
Console.WriteLine($"Строка с минимальной суммой элементов - {minLineSumm}");

void FillArray (int [, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(10, 100);
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


int MinSummLine (int [, ] array)
{
    int index = 0;
    int minsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minsum = minsum + array[0,j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          index = i;
        }
      }
      return index;
}

int Promt (string message)
{ 
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}