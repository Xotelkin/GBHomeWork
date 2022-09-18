// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
CountPositiveNumber(numbers);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {CountPositiveNumber(numbers)}");

int CountPositiveNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            count++;
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
            if(i != input.Length - 1)
            {
                temp += input [i].ToString();
                i++;
            }
            else
            {
                temp += input [i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}




void PrintArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}