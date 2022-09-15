// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number = Proverka(num);
int Summa = Calculation(ProvOtric(number));
Console.WriteLine(Summa);

int Proverka(int a)
{
    if (num < 0)
        num *= -1;
    return num;
}

int Calculation(int number)
{
    if (num < 11)
        return num;
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10; 
    }
    return sum;
}

