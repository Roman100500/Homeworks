// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Ghost(string x)
{
    x = x.Trim(new char[] { ' ', '-' });
    int l = 0;
    foreach (char a in x)
        l += Convert.ToInt32(Convert.ToString(a));
    return l;
}

Console.Write("Input a number: ");
string x = Console.ReadLine();
Console.WriteLine($"The sum of the numbers: {Ghost(x)}");