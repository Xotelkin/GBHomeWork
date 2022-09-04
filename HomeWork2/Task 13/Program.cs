// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99)
    Console.WriteLine(num.ToString()[2]);
else
    if(num < -99)
        Console.WriteLine(num.ToString()[3]);
    else
        Console.WriteLine("Третьей цифры нет");