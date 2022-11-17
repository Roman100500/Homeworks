// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minvalue, int maxvalue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[] CreateArrayColumnsArithmeticMean(int[,] array)
{
    double[] arrayArithmeticMean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];
        arrayArithmeticMean[i] = sum / (array.GetLength(0));
    }
    return arrayArithmeticMean;
}

void ShowArray(double[] array)
{
    string z = String.Empty;
    for (int i = 0; i < array.Length; i++)
        z += $"{Math.Round(array[i], 3)}, ";
    z = z.TrimEnd(new char[] { ' ', ',' });
    Console.Write($"[{z}]");
    Console.WriteLine();
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
double[] myArray2 = CreateArrayColumnsArithmeticMean(myArray);
Console.WriteLine();
ShowArray(myArray2);
