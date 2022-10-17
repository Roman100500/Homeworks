// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int number)
{
    int ed = number % 10;
    int des = number % 100;
    number = (des - ed) / 10;
    if (number < 0)
        number = - number;
    return number;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = CutNumber(a);
Console.WriteLine(result + " - вторая цифра числа " + a);