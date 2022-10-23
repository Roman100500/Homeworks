// Задача 19. Напишите программу, которая принимает на вход n-значное число и проверяет, является ли оно палиндромом.

bool ArrayPalindrome(int y, string z)
{
    int[] array = new int[y];
    string k;
    bool m = true;
    for (int i = 0; i < y; i++)
    {
        k = Convert.ToString(z[i]);
        array[i] = Convert.ToInt32(k);
        Console.Write(array[i] + " ");
    }
    Console.Write(" - array ");
    Console.WriteLine();
    for (int j = 0; j < y + 1 / 2; j++)
    {
        if(array[j] != array[y - 1 - j])
        {
            m = false;
            break;
        }
    }
    return m;
}

Console.Write("Input a natural number: ");
string c = Console.ReadLine();
int b =  c.Length;
bool res = ArrayPalindrome(b, c);
Console.WriteLine(res);