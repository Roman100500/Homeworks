// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x, y;
    if (k1 == k2)
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают!");
            return;
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются!");
            return;
        }

    x = (b2 - b1) / (k1 - k2);
    y = (k1 * b2 - k2 * b1) / (k1 - k2);
    Console.WriteLine($"Точка пересечения  двух прямых: ({Math.Round(x, 3)}; {Math.Round(y, 3)})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoint(b1, k1, b2, k2);
