// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] GetArray(int[] arraySizes, int minVal, int maxVal)
{
    int[,,] result = new int[arraySizes[0], arraySizes[1], arraySizes[2]];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = rnd.Next(minVal, maxVal);
                if (CompareElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool CompareElement(int[,,] inResult, int inElement)
{
    for (int i = 0; i < inResult.GetLength(0); i++)
    {
        for (int j = 0; j < inResult.GetLength(1); j++)
        {
            for (int k = 0; k < inResult.GetLength(2); k++)
            {
                if (inResult[i, j, k] == inElement) return true;
            }

        }
    }
    return false;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите три размера массива через пробел ");
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int minValue = 10;
int maxValue = 100;
int[] sizesArray = new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]) };
int[,,] threeSizeArray = GetArray(sizesArray, minValue, maxValue);

PrintArray(threeSizeArray);