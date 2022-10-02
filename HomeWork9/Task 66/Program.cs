// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = Promt ("Введите M: ");
int n = Promt ("Введите N: ");
CheckNumber (m, n);
CountNaturalSum (m, n);
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");


int CountNaturalSum (int m, int n)
{
    if (CheckNumber (m, n) == true)
    {
        int temp = m;
        m = n;
        n = temp;
    }

    if (m == n)
         return n;
    return n + CountNaturalSum(m, n - 1);
}

bool CheckNumber (int m, int n)
{
    if (m > n)
        return true;
    else
        return false;
}
    
int Promt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}