// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.Clear();

Console.WriteLine("Задаем двумерный массив.");
int quantityRows = ReadInt("введите количество строк в массиве: ");
int quantityColumns = ReadInt("введите количество столбцов в массиве: ");

int[,] matr = FillMatrix(quantityRows, quantityColumns);
PrintMatrix(matr);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");
ColumnAverage(matr);


//************************************************************************************************
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double averageColumn = 0;
        double sumColumn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumColumn += matrix[j, i];
        }
        averageColumn = sumColumn / quantityRows;
        Console.Write(Math.Round(averageColumn, 1) + "  ");
    }

}