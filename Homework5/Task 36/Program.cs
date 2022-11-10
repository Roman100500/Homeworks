// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);

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

int SumOfOddElements (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
            sum += array[i];
    return sum;
}

Console.Write("Input the length of the array: ");
int[] myArray = RandomArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(myArray);
int sum = SumOfOddElements(myArray);
Console.WriteLine($"Sum of odd elements in the array: " + sum);
