// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] PositiveThreeDigitArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

void ShowArray(int[] array)
{
    string m = String.Empty;
    for (int i = 0; i < array.Length; i++)
        m += $"{array[i]}, ";
    m = m.TrimEnd(new char[] {' ', ','});
    Console.Write($"[{m}] - array");
    Console.WriteLine();
}

int CountEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 ==0)
            count++;
    return count;
}

Console.Write("Input the length of the array: ");
int[] myArray = PositiveThreeDigitArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(myArray);
int positiveCount = CountEvenNumbers(myArray);
Console.WriteLine($"The number of even numbers in the array: " + positiveCount);