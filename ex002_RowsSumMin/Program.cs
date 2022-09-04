// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int index = -1;
int rowsSum = int.MaxValue;
int[,] resultMatrix = FillArray(rows, columns);

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
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[k, m] + "\t");
        }
        Console.WriteLine();
    }
}

int IndexOfMinSumRow(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int temp = 0;

        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            temp = temp + inputMatrix[i, j];
        }
        if (temp < rowsSum)
            {
                rowsSum = temp;
                index = i;
            } 
    }
    return index;    
}

PrintArray(resultMatrix);
IndexOfMinSumRow(resultMatrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов - {index+1}");