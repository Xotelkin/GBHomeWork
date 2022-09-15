// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
int summ = 1;
for(int i = 0; i < numberB; i++)
    summ *= numberA;

Console.WriteLine($"Число {numberA} в степени {numberB} равно {summ}");