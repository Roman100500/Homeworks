// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekends(int number, bool num)
{
    if (number % 7 == 0 || number % 7 == 6)
        num = true;
    return num;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
bool num = false;
bool result = Weekends(a, num);
Console.WriteLine(result);