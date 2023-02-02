// // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] GetMultiplMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] resultArray = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int rowFirst = 0; rowFirst < matrixFirst.GetLength(0); rowFirst++)
    {
        for (int columnSecond = 0; columnSecond < matrixSecond.GetLength(1); columnSecond++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                resultArray[rowFirst, columnSecond] += matrixFirst[rowFirst, k] * matrixSecond[k, columnSecond];
            }

        }
    }
    return resultArray;
}


Console.Write("Введите количество строк 1 массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsFirsMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2 массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

if (columnsFirsMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Такие матрицы нельзя перемножить.");
    return;
}

int minValue = 0;
int maxValue = 10;
int[,] firstMatrix = CreateRandomArray(rowsFirstMatrix, columnsFirsMatrix, minValue, maxValue);
int[,] secondMatrix = CreateRandomArray(rowsSecondMatrix, columnsSecondMatrix, minValue, maxValue);

PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();

PrintArray(GetMultiplMatrix(firstMatrix, secondMatrix));
