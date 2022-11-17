// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//            или же указание, что такого элемента нет.

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

void ShowElement(int[,] array, int rows, int columns)
{
    if (rows < array.GetLength(0)
        && columns < array.GetLength(1)
        && rows >= 0
        && columns >= 0)
        Console.WriteLine($"array[{rows}, {columns}] = " + array[rows, columns]);
    else
        Console.WriteLine($"array[{rows}, {columns}] - не существует!");
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

Console.Write("Input x (array[x, y]): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y (array[x, y]): ");
int y = Convert.ToInt32(Console.ReadLine());
ShowElement(myArray, x, y);
