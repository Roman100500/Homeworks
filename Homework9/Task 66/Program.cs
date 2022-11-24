// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNaturalElements(int m, int n)
{
    if (m < n)
        return SumNaturalElements(m + 1, n) + m;
    if (m > n)
        return SumNaturalElements(m, n + 1) + n;
    return m;
}

Console.Write("Input natural number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input natural number N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m <= 0 || n <= 0)
    Console.WriteLine("Incorrect values!");
else
    Console.WriteLine($"The sum of natural numbers: {SumNaturalElements(m, n)}");