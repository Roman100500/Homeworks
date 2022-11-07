// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int a)
{
    int s = 0;
    while (a != 0)
    {
        s += a % 10;
        a /= 10;
    }
    if (s < 0)
        s = -s;
    return s;
}

Console.Write("Input a number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of the numbers: {Sum(x)}");