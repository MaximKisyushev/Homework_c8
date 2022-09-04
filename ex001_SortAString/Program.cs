// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

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

int[,] resultMatrix = FillArray(rows, columns);

void PrintArray(int[,] inputMatrix)
{
    for (int k = 0; k < inputMatrix.GetLength(0); k++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[k, m] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(resultMatrix);

void SortRows(int[,] inputMatrix)
{
     for (int i = 0; i < inputMatrix.GetLength(0); i++)
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                    for (int k = 0; k < inputMatrix.GetLength(1); k++)
                    {
                        if (inputMatrix[i, j] <= inputMatrix[i, k]) continue;
                        int temp = inputMatrix[i, j];
                        inputMatrix[i, j] = inputMatrix[i, k];
                        inputMatrix[i, k] = temp;
                    }
}

SortRows(resultMatrix);
Console.WriteLine("Сортированная по убыванию в строке матрица:");
PrintArray(resultMatrix);