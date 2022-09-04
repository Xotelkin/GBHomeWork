// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <= 7)
{
    if(num > 5)
         Console.WriteLine("Ура, выходной");
    else
        Console.WriteLine("Работать, солнце ещё высоко!"); 
}
else
    Console.WriteLine("Ошибка ввода");