// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();
Console.WriteLine("Введите ширину масива");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int[lines, columns];
int [] sum = new int[lines];
FillArray(numbers);
PrintArray(numbers);
SumInRows(numbers, sum);
CheckSum(sum);


void FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(1, 10);
        }
    }
}

void SumInRows (int [,] numbers, int [] sum)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum[i] = sum[i] + numbers[i,j];
        }
    }
}

void PrintArray(int [,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

void CheckSum (int [] array)
{
    int minValue = sum[0];
    int minSum = 0;
    for (int i = 1; i<sum.GetLength(0); i++)
    {
        if (sum[i-1] > sum[i] && minValue > sum[i])
        {
           minSum = i+1;
           minValue = sum[i];
        }
    }
    Console.WriteLine($"Строка с минимальной суммой: {minSum}");
}