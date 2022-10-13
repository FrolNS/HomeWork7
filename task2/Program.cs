/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] generate2DArray(int height, int width, int start, int end)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(start, end + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void printArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void getSumOfColumn(int[,] final2DArray)
{
    Console.Write("\t");
    for (int j = 0; j < final2DArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < final2DArray.GetLength(0); i++)
        {
        sum += final2DArray[i, j];
        }
        Console.Write($"{sum / final2DArray.GetLength(0)} \t");
    }
}


int[,] generetedArray = generate2DArray(5, 5, 1, 10);
printArray(generetedArray);
Console.WriteLine();
getSumOfColumn(generetedArray);