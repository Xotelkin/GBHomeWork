// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int N = Prompt("Введите число : ");
for (int count = 1; count <= N; count++)
{
    int result = count * count * count;
    Console.WriteLine(result);
}