// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Если числа случайные(сделал так, что каждое число принадлежит отрезку [-9, 9]):

void ArrayElements()
{
    int a = 8;
    string s = string.Empty;
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(-9, 10);
        s += $"{array[i]}, ";
    }
    s = s.TrimEnd(new Char[] { ',', ' ' });
    Console.WriteLine($"[{s}]");
}
ArrayElements();

// Если числа задает пользователь:

/*

void ArrayElements()
{
    int a = 8;
    string s = string.Empty;
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        Console.Write($"Input array[{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        s += $"{array[i]}, ";
    }
    s = s.TrimEnd(new Char[] { ',', ' ' });
    Console.WriteLine($"[{s}]");
}
ArrayElements();

*/