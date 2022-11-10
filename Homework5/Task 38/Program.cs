// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] PositiveThreeDigitArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 3);

    return array;
}

void ShowArray(double[] array)
{
    string m = String.Empty;
    for (int i = 0; i < array.Length; i++)
        m += $"{array[i]}, ";
    m = m.TrimEnd(new char[] {' ', ','});
    Console.Write($"[{m}] - array");
    Console.WriteLine();
}

double DifferenceOfNumbers (double[] array)
{
    double dif, min, max;
    min = max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }    
        dif = max - min;
    return dif;
}

Console.Write("Input the length of the array: ");
double[] myArray = PositiveThreeDigitArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(myArray);
Console.WriteLine($"Difference between maximum and minimum array elements: {Math.Round(DifferenceOfNumbers(myArray), 3)}");