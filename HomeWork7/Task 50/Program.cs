// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int m = 4;
int n = 5;
int [, ] array = new int [m, n];
FillArray (array);
PrintArray (array);
FindElement (array);

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


void FindElement (int [, ] array)
{
     int pos1 = Promt("Введите номер строки: ") - 1;
     int pos2 = Promt("Введите номер элемента в строке: ") - 1;
     if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
        Console.WriteLine("Такого элемента нет");
    else
    {
        object c = array.GetValue(pos1, pos2);
        Console.WriteLine(c);
    }
}


int Promt (string message)
{ 
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}