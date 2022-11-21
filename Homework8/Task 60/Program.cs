// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//            Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 

int[,,] CreateRandom3dArray(int rows, int columns, int count, int[] array)
{
    int n = 0;
    int z = 0;
    int[,,] array2 = new int[rows, columns, count];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < count; k++)
            {
                array2[i, j, k] = array[n = new Random().Next(0, 180 - z)];
                array[n] = array[180 - z - 1];
                z++;
            }
        }

    }
    return array2;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }

    }
}

int[] CreateRandomArray()
{
    int[] array = new int[180];
    for (int i = 0; i < 180; i++)
    {
        if (i < 90)
            array[i] = -99 + i;
        else
            array[i] = i - 80;
    }
    return array;
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of count: ");
int k = Convert.ToInt32(Console.ReadLine());
if (m * n * k > 180)
    Console.WriteLine("It is not possible to create an array with non-repeating numbers!");
else
{
    int[] myArray2 = CreateRandomArray();
    int[,,] myArray = CreateRandom3dArray(m, n, k, myArray2);
    Show3dArray(myArray);
}