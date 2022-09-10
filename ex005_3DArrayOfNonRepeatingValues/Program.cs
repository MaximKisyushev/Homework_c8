// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите размер трёхмерного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
bool repeat;
int[,,] FillUniqValueArray(int m, int n, int l)
{
    int[,,] matrix = new int[m, n, l];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2);)
            {
                repeat = false;
                int RandomValue = new Random().Next(10, 99);
                
                for (int e = 0; e < matrix.GetLength(0); e++)
                {
                    for (int r = 0; r < matrix.GetLength(1); r++)
                    {
                        for (int t = 0; t < matrix.GetLength(2); t++)
                        {
                            if (matrix[e, r, t] == RandomValue)
                            {
                                repeat = true;
                                break;
                            }
                        }
                    }
                }
                if (!repeat)
                {
                    matrix[i, j, k] = RandomValue;
                    k++;
                }
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] inputMatrix)
{
    for (int z = 0; z < inputMatrix.GetLength(0); z++)
    {
        for (int g = 0; g < inputMatrix.GetLength(1); g++)
        {
            for (int v = 0; v < inputMatrix.GetLength(2); v++)
            {
                Console.Write(inputMatrix[z, g, v] + "(" + z + ", " + g + ", " + v + ")" + "\t");
            }
            Console.WriteLine();
        }

    }
}

int[,,] Matrix = FillUniqValueArray(size, size, size);
Console.WriteLine("-----x-----     -----x-----");
PrintArray(Matrix);
Console.WriteLine("-----x-----     -----x-----");