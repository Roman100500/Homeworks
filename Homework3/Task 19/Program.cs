// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrome (int num)
{   
    bool z = true;
    double x, y;
    int i = 1;
    while (i < 3)
    {
        x = ((num % (100000 / Math.Pow(10, i-1))) - (num % (10000 / Math.Pow(10, i-1)))) / (10000 / Math.Pow(10, i-1)); 
        if (i == 1)
        {
            y = (num % (10 * Math.Pow(10, i-1)));
        }
        else
        {
            y = ((num % (10 * Math.Pow(10, i-1))) - (num % Math.Pow(10, i-1))) / Math.Pow(10, i-1);
        }
        if (x != y)
        {
            z = false;
            break;
        }
        i++;
    }
    return z;
}
Console.Write("Input a five-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
bool y = Palindrome(a);
Console.WriteLine(y);