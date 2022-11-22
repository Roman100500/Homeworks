// Задача 62.1 Напишите программу, которая заполнит спирально массив m на n, но идущая не внутрь, а наружу.

int[,] CreateSpiral2dArray(int rows, int columns)
{
    int count = 1;
    int[,] array = new int[rows, columns];
    for (int m = 0; ; m++)
    {
        for (int j = m; j < array.GetLength(1) - m; j++)
        {
            if (count > rows * columns)
                break;
            array[m, j] = count;
            count++;
        }
        for (int i = 1 + m; i < array.GetLength(0) - m; i++)
        {
            if (count > rows * columns)
                break;
            array[i, array.GetLength(1) - 1 - m] = count;
            count++;

        }
        for (int j = array.GetLength(1) - 1 - m; j > m; j--)
        {
            if (count > rows * columns)
                break;
            array[array.GetLength(0) - 1 - m, j - 1] = count;
            count++;

        }
        for (int i = array.GetLength(0) - 2 - m; i > m; i--)
        {
            if (count > rows * columns)
                break;
            array[i, m] = count;
            count++;

        }
        if (count > rows * columns)
            break;
    }
    return array;
}

void Array2dReplacement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z <= (array.GetLength(0) * array.GetLength(1)) - 1; z++)
            {
                if (array[i, j] == z + 1)
                {
                    array[i, j] = array.GetLength(0) * array.GetLength(1) - z;
                    break;
                }


            }
        }
    }

}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (Convert.ToString(array.GetLength(0) * array.GetLength(1)).Length > Convert.ToString(array[i, j]).Length)
            {
                for (int k = 0;
                     k < Convert.ToString(array.GetLength(0) * array.GetLength(1)).Length - Convert.ToString(array[i, j]).Length;
                     k++)
                    System.Console.Write("0");
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiral2dArray(m, n);
Array2dReplacement(myArray);
Show2dArray(myArray);