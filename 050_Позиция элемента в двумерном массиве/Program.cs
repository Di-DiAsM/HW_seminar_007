// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();

Console.WriteLine("Задаем двумерный массив.");
int quantityRows  = ReadInt("введите количество строк в массиве: ");
int quantityColumns = ReadInt("введите количество столбцов в массиве: ");

int[,] matr = FillMatrix(quantityRows, quantityColumns);
PrintMatrix(matr);

Console.WriteLine("Ищем число по строке и столбцу в массиве");
int numberRow = ReadInt("введите строку: ");
int numberColumn = ReadInt("введите столбец: ");

if (numberRow >= quantityRows || numberColumn >= quantityColumns)
{
    Console.Write("Такого элемента нет");
}

else
{
    Console.WriteLine($"это число: {matr[numberRow, numberColumn]} ");
}


//***********************************************************************
int ReadInt(string msg)
{
    Console.Write(msg);
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

void PrintMatrix(int [,] matrix)
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