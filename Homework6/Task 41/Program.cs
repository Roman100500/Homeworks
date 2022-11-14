// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountNumbers(int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {(i + 1)}-е число: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество цифр: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр > 0: {CountNumbers(m)}");