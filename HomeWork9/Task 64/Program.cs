// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = Promt ("Введите число больше нуля: ");
NaturalNumber(n);
CheckNumber (n);
Console.WriteLine(NaturalNumber(n));


string NaturalNumber(int num)
{
    if (CheckNumber (num) == false)
        return "Введено отрицательное число или ноль";
    else
    {
        if (num == 1)
            return num.ToString();
        else
            return num.ToString() + ", " + NaturalNumber(num - 1);
    }
}


bool CheckNumber (int number)
{
    if (number < 1)
        return false;
    else
        return true;
}

int Promt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
