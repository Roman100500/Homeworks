// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int m, int n)
{
    if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return n + 1;
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
    Console.WriteLine("Incorrect values!");
else
    Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");