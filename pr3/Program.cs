// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Random rnd = new Random();
int n1 = MatrixSizeLines(1);
int m1 = MatrixSizeColumns(1);
int [,] matrixA = new int [n1, m1];
int n2 = MatrixSizeLines(2);
int m2 = MatrixSizeColumns(2);
int [,] matrixB = new int [n2, m2];
FillArray(matrixA);
FillArray(matrixB);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
MatrixCheck(n1, n2, m1, m2);


int MatrixSizeLines (int matrixNumber)
{
    Console.WriteLine($"Введите размер матрицы {matrixNumber} (строчки х стобцы)");
    Console.WriteLine("Строчки: ");
    return Convert.ToInt32(Console.ReadLine());
}
int MatrixSizeColumns (int matrixNumber)
{
    Console.WriteLine("Столбцы: "); 
    return Convert.ToInt32(Console.ReadLine());
}

void MatrixCheck (int n1, int n2, int m1, int m2)
{
    if (m1 == n2)
    {
        int [,] matrixC = new int [n1, m2];
        MatrixMultiply(matrixA, matrixB, matrixC);
    }
    else Console.WriteLine ("Нельзя перемножить матрицы");
}

void MatrixMultiply (int [,] matrixA, int [,] matrixB, int [,] matrixC)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        int n = 0;
        int m = 0;
        int tempLine = 0;
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            tempLine += matrixA[i,j]*matrixB[n,m];
            if (i+1 == matrixC.GetLength(1)) 
            {
                matrixC[i,j] = tempLine;
                Console.Write(matrixC[i,j] + "  ");
            }
            n++;
        }
    }
}

void FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(1, 3);
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