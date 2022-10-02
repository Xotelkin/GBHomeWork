// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите два положительных числа: M и N.");
int m = Promt ("Введите M: ");
int n = Promt ("Введите N: ");
int akkermanFunction = Akkerman(m, n);
Console.WriteLine($"m = {m}, n = {n}  ==> {akkermanFunction}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman (m - 1, 1);
    else
        return Akkerman (m - 1, Akkerman (m, n - 1));
}

int Promt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}