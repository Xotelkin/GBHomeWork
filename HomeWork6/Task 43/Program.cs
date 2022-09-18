// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double b1 = Promt("b1 = ");
double k1 = Promt("k1 = ");
double b2 = Promt("b2 = ");
double k2 = Promt("k2 = ");
Console.WriteLine(SearchPoint(b1, b2, k1, k2));

string SearchPoint (double b1, double b2, double k1, double k2)
{
    string result = "";
    if ((k1 == k2) && (b1 == b2))
        result = "Прямые совпадают";
    else 
    {
        if (k1==k2)
            result = "Прямые параллельны";
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            result = $"Две прямые пересекутся в точке с координатами: ({x}; {y})";
        }
    }
    return result;

}




double Promt (string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}