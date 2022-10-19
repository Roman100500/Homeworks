// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

void Algprog(int a)
{
    int b = 2;
    while (b <= a)
    {
        Console.Write(b + " ");
        b += 2;
    }

}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Algprog(a);