// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Cub (int n)
{
    return n * n * n;
}

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int[] InputCoords(int n)
{
    int[] coord = new int[3];
    coord[0] = Prompt($"введите x {n} точки: ");
    coord[1] = Prompt($"введите y {n} точки: ");
    coord[2] = Prompt($"введите z {n} точки: ");
    return coord;
}

int[]coord1=InputCoords(1);
int[]coord2=InputCoords(2);

double result = Math.Sqrt(Cub(coord2[0] - coord1[0]) + Cub(coord2[1] - coord1[1]) + Cub(coord2[2] - coord1[2]));
Console.WriteLine(result);