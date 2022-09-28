// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = Promt ("Введите положительное число: ");
NaturalNumber(n);
Console.WriteLine(NaturalNumber(n));


string NaturalNumber(int num)
{
    if (num == 1)
        return num.ToString();
    return num.ToString() + ", " + NaturalNumber(num - 1);
}

int Promt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
