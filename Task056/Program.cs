// // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetMinRowSum(int[,] forArray)
{
    int minSum = 0;
    int rowNumber = 0;
    Console.Write("Сумма элементов в строках ");
    for (int i = 0; i < forArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < forArray.GetLength(1); j++)
        {
            sum += forArray[i, j];
        }
        Console.Write($"{sum} ");
        if (i == 0)
        {
            minSum = sum;
            rowNumber = i + 1;
        }
        if (sum < minSum)
        {
            minSum = sum;
            rowNumber = i + 1;
        }
    }
    Console.WriteLine();
    return rowNumber;
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minValue = 0;
int maxValue = 10;
int[,] array = CreateRandomArray(rows, columns, minValue, maxValue);

PrintArray(array);

Console.WriteLine($"Наименьшая сумма элементов в {GetMinRowSum(array)} строке");
