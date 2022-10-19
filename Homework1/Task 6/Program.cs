// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

bool Multi(int n)
{
    if (n % 2 == 0)
        return true;
    else
        return false;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
bool result = Multi(a);
Console.WriteLine(result);