// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine()); // строки
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); // столбцы

double [,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);


//******************************************************************************
double[,] FillMatrix(int rowsCount, int columnsCount)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // цикл перебирает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // цикл перебирает столбцы на каждой строке
        {
            matrix[i, j] = rand.NextDouble() * 10; // диапозон от 0 до 1 по умолчанию(так сказал Иван), делаем от 1 до 10 
            //matrix[i, j] = rand.Next(-10, 100) / 10.0; // тут проще задать диапозон, для меня
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // цикл перебирает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // цикл перебирает столбцы на каждой строке
        {
            Console.Write(Math.Round(matrix[i, j], 1) + "  ");
        }
        Console.WriteLine();
    }
}
