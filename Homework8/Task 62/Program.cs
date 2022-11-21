// Задача 62. Напишите программу, которая заполнит спирально массив m на n.

int[,] CreateSpiral2dArray(int rows, int columns)
{
    int count = 1;
    int[,] array = new int[rows, columns];
    for (int m = 0; m < (array.GetLength(0) + 1) / 2; m++)
    {
        for (int j = 0 + m; j < array.GetLength(1) - m; j++)
        {
            if (count > rows * columns)
                break;
            array[0 + m, j] = count;
            count++;
        }
        for (int i = 1 + m; i < array.GetLength(0) - m; i++)
        {
            if (count > rows * columns)
                break;
            array[i, array.GetLength(1) - 1 - m] = count;
            count++;

        }
        for (int j = array.GetLength(1) - 1 - m; j > 0 + m; j--)
        {
            if (count > rows * columns)
                break;
            array[array.GetLength(0) - 1 - m, j - 1] = count;
            count++;

        }
        for (int i = array.GetLength(0) - 2 - m; i > 0 + m; i--)
        {
            if (count > rows * columns)
                break;
            array[i, 0 + m] = count;
            count++;

        }
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

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiral2dArray(m, n);
Show2dArray(myArray);
