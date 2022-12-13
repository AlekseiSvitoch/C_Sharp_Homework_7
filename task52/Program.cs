// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void AverageValue(int[,] matrix)
{ 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i, j];
        }
        Console.Write($"{Math.Round(average / matrix.GetLength(0), 1)}; ");
    }
}

Console.Clear();
Console.Write("Задайте размерность двумерного массива: ");
string[] numbers = Console.ReadLine().Split(", ");
int row = int.Parse(numbers[0]),
    col = int.Parse(numbers[1]);
int[,] matrix = new int[row, col];
InputMatrix(matrix);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
AverageValue(matrix);
