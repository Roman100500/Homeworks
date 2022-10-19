// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int More(int n1, int n2)
{
    if (n1 > n2)
        return n1;
    else
        return n2;
}


Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = More(a, b);
Console.WriteLine(result + " - наибольшее число");