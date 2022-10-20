// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrome (int num)
{   
    bool z = true;
    double x, y;
    int a = 1;
    int i = 1;
    while (i < 3)
    {
        x = ((num % (100000 / a)) - (num % (10000 / a))) / (10000 / a);
        if (i == 1)
        {
            y = (num % (10 * a));
        }
        else
        {
            y = ((num % (10 * a)) - (num % a)) / a;
        }
        if (x != y)
        {
            z = false;
            break;
        }
        i++;
        a *= 10;
    }
    return z;
}
Console.Write("Input a five-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
bool y = Palindrome(a);
Console.WriteLine(y);