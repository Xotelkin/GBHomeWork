// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int size = 10;
double [] array = new double[size];
FillAray(array);
double Diff = FoundMax(array) - FoundMin(array);
Console.WriteLine("[{0}]", string.Join(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {Diff}");


void FillAray(double [] array)
{
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
}
       
double FoundMax(double [] array)
{
   double Max = array[0];
   for (int i = 0; i < size; i++)
   {
    if (array[i] > Max)
        Max = array[i];
   }
   return Max;
}

double FoundMin(double [] array)
{
   double Min = array[0];
   for (int i = 0; i < size; i++)
   {
    if (array[i] < Min)
        Min = array[i];
   }
   return Min;
}