// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
Random rnd = new Random();
int [, ] array = new int [rnd.Next(3, 8), rnd.Next(3, 8)];
FillArray (array);
PrintArray(array);






void FillArray (int [, ] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1)];
  int  number;
  for (int i = 0; i < temp.Length; i++)
  {
    temp[i] = rnd.Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = rnd.Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
      {
        array[x, y] = temp[count];
        count++;
      }
  }
}

void PrintArray(int [, ] array)
{
    int [] buf = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            buf[j] = array[i, j];
        }
        Console.WriteLine("[{0}]", string.Join(" ", buf));
    }
}