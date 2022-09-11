// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string Palindrome(int num)
{ 
    string result = "";
    if (num > 9999 && num < 100000)
    {
        if (num / 10000 == num % 10)
        {
            if (num / 1000 - (num / 10000 * 10) == num / 10 % 10)
                result = "Это палиндром";   
        }
        else
            result = "Это не палиндром";
    }
    else
        result = "Это не пятизначное число";
    return result;
}

System.Console.WriteLine(Palindrome(number));
