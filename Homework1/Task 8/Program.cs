// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;
while (b <= a)
{
    Console.Write(b + " ");
    b += 2;
}