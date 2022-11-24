// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNaturalNumbers(int n)
{
    if (n <= 0)
        Console.WriteLine($"{n} - no natural number!");
    if (n == 1)
        Console.WriteLine(n + " ");
    if (n > 1)
    {
        Console.Write(n + " ");
        ShowNaturalNumbers(n - 1);
    }
}
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(n);