// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Maximum(int n1, int n2, int n3)
{
    int max = n1;
    if (max < n2)
        max = n2;
    if (max < n3)
        max = n3;
        return max;
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int res = Maximum(a, b, c);
Console.WriteLine(res + " - maximum number");
