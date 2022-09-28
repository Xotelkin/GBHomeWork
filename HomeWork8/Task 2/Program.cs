// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
int size = Promt ("Введите размер квадратной матрицы: ");
int [, ] arrayA = new int [size, size];
int [, ] arrayB = new int [size, size];
Random rnd = new Random();
FillArray (arrayA);
FillArray (arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(MultiplicationMatrix(arrayA, arrayB));


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

int [,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
    }
    return arrayC;
}

int Promt (string message)
{ 
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}