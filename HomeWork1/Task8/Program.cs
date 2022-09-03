// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < numberN + 1)
    {
        if (i%2 == 0)
            {
                Console.WriteLine(i);
            }
        i++;
    }