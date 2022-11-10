// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray()
{
    int[] array = new int[8];

    for (int i = 0; i < 8; i++)
        array[i] = new Random().Next(-9, 10);

    return array;
}

void ShowArray(int[] array)
{
    string m = String.Empty;
    for (int i = 0; i < array.Length; i++)
        m += $"{array[i]}, ";
    m = m.TrimEnd(new char[] { ' ', ',' });
    Console.Write($"[{m}]");
    Console.WriteLine();
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);