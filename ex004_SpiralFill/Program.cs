// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int number = 0;
    int[,] matrix = new int[m, n];
    
    for (int i = 0; i <= size / 2; i++)
    {
        for (int j = i; j < size - i; j++)  //fill first row
        {
            number++;
            matrix[i, j] = number;
        }
        for (int k = i + 1; k < size - i; k++)  //fill first column
        {
            number++;
            matrix[k, size - 1 - i] = number;
        }
        for (int l = size - i - 2; l >= i; l--)  //fill second row
        {
            number++;
            matrix[size - i - 1, l] = number;
        }
        for (int f = size - i - 2; f > i; f--)  //fill second column
        {
            number++;
            matrix[f, i] = number;
        }
    }

    return matrix;
}

void PrintArray(int[,] inputMatrix)
{
    for (int z = 0; z < inputMatrix.GetLength(0); z++)
    {
        Console.Write("|");
        for (int g = 0; g < inputMatrix.GetLength(1); g++)
        {

            Console.Write(inputMatrix[z, g] + "\t");

        }
        Console.Write("|");
        Console.WriteLine();
    }
}


int[,] firstMatrix = FillArray(size, size);

PrintArray(firstMatrix);
Console.WriteLine("x");