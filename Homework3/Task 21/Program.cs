// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Three_d(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lenght;
    lenght = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 3);
    return lenght;
}

Console.Write("Input a x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double res = Three_d(x1, y1, z1, x2, y2, z2);
Console.WriteLine("lenght = " + res);