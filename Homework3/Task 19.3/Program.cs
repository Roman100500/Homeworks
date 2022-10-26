// Задача 19. Напишите программу, которая принимает на вход n-значное число и проверяет, является ли оно палиндромом.

/* 1 способ
bool PalindromeInt(string a)
{
    int i = 0;
    bool m = true;
    int c = Convert.ToInt32(a);
    if (c < 0)
        c = -c;
    a = Convert.ToString(c);
    int b = a.Length;
    while (i < b + 1 / 2)
    {
        if (a[i] != a[b - 1 - i])
        {
            m = false;
            break;
        }
        i++;
    }

    return m;
}

Console.Write("Input a number: ");
string x = Console.ReadLine();
bool y = PalindromeInt(x);
Console.WriteLine(y);
*/

// 2 способ

bool PalindromeString(string a)
{
    bool m = true;
    a = a.Trim(new Char[] { ' ', '-' });
    int b = a.Length;
    for (int i = 0; i < (b + 1) / 2; i++)
    {
        if (a[i] != a[b - 1 - i])
        {
            m = false;
            break;
        }
    }
    return m;
}

Console.Write("Input a number: ");
string x = Console.ReadLine();
bool y = PalindromeString(x);
Console.WriteLine(y);