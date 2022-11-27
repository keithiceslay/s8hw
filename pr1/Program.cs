// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random rnd = new Random();
Console.WriteLine("Введите количество строк в массиве");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int[lines, columns];
FillArray(numbers);
SortArray(numbers);
PrintArray(numbers);

void FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next();
        }
    }
}

void SortArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
           for (int l = 0; l < array.GetLength(1)-1; l++)
           {
            if (array[i,j-1] < array[i,j]) 
            {
                int x = array[i, j-1];
                array [i, j-1] = array [i, j];
                array [i, j] = x;
            }
           }
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