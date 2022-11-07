// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree(int a, int b)
{
    int s = 1;
    for (int i = 0; i < b; i++)
        s *= a;
    return s;
}

Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number {a} to the power of {b} is: {Degree(a, b)}");