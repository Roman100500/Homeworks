// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string ThirdNumber(int number)
{
    string result;
    int n = 10;
    while (number != number % n)
        n *= 10;

    if (n <= 100)
    {
        result = "третьей цифры нет у";
        return result;
    }
    else
    {
        n = n / 1000;
        int v1 = number / n;
        int v2 = (number / (n * 10)) * 10;
        n = v1 - v2;
        if (n < 0) 
            n = -n;
        result =  $"{n} - третья цифра";
        return result;
    }
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
string ans = ThirdNumber(a);
Console.WriteLine( ans +  " числа " + a);