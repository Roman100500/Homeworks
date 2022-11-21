// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] arrayMultiplication = new int[array1.GetLength(0), array2.GetLength(1)];

    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Matrix multiplication is not possible!");
        return;
    }

    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    arrayMultiplication[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    Show2dArray(arrayMultiplication);
}



Console.Write("Input a number of rows first matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns first matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value first matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value first matrix: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Input a number of rows second matrix: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns second matrix: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value second matrix: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value second matrix: ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("First matrix:");
int[,] myArray = CreateRandom2dArray(m, n, x, max);
Show2dArray(myArray);

Console.WriteLine("Second matrix:");
int[,] myArray2 = CreateRandom2dArray(m1, n1, x1, max1);
Show2dArray(myArray2);

Console.WriteLine("Multiplication of the first matrix by the second matrix:");
MatrixMultiplication(myArray, myArray2);

