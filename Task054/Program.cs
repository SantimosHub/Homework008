// // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandomArray(int inRows, int inColumns, int minVal, int maxVal)
{
    int[,] inArray = new int[inRows, inColumns];
    Random rnd = new Random();
    for (int i = 0; i < inArray.GetLength(0); i++)
        for (int j = 0; j < inArray.GetLength(1); j++)
            inArray[i, j] = rnd.Next(minVal, maxVal + 1);
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] forArray)
{
    for (int i = 0; i < forArray.GetLength(0); i++)
    {
        for (int j = 0; j < forArray.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < forArray.GetLength(1); k++)
            {
                if (forArray[i, k] > forArray[i, j])
                {
                    int temp = forArray[i, j];
                    forArray[i, j] = forArray[i, k];
                    forArray[i, k] = temp;
                }

            }

        }
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minValue = 0;
int maxValue = 100;
int[,] array = CreateRandomArray(rows, columns, minValue, maxValue);

PrintArray(array);

SortArray(array);

Console.WriteLine();
PrintArray(array);