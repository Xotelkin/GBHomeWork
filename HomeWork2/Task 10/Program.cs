// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num / 100 >= 1 && num / 100 < 10)
{
    int result = num / 10 - (num / 100 * 10);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Введено не трёхзначное число");