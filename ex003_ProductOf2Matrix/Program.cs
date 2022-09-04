// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputMatrix)
{
    for (int k = 0; k < inputMatrix.GetLength(0); k++)
    {
        Console.Write("|");
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {

            Console.Write(inputMatrix[k, m] + "\t");

        }
        Console.Write("|");
        Console.WriteLine();
    }
}

Console.WriteLine("____________________________________Программа умножения двух матриц_______________________________________________");
Console.WriteLine("!чтобы умножить две матрицы, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.Write("Введите количество строк матрицы 1: ");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int firstColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы 2: ");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = FillArray(firstRows, firstColumns);
int[,] secondMatrix = FillArray(secondRows, secondColumns);

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы");
else
{
    PrintArray(firstMatrix);
    Console.WriteLine("x");
    PrintArray(secondMatrix);
}




int[,] resultMatrix(int m, int n)
{
    int[,] Matrix = new int[m, n];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                Matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }

        }

    }

    return Matrix;
}

int[,] resMatrix = resultMatrix(firstRows, secondColumns);
Console.WriteLine("=");
PrintArray(resMatrix);