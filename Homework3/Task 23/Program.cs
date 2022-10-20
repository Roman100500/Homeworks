// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int n)
{
    int x = 1;
    while(x <= n)
    {
        Console.Write(Math.Pow(x, 3) + " ");
        x++;
    }
}

Console.Write("Input a natural number: ");
int y = Convert.ToInt32(Console.ReadLine());
Cube(y);
