// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет


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

void SearchPosition (int[,] array, int row, int col)
{
    if (row > array.GetLength(0) || col > array.GetLength(1) || row <= 0 || col <= 0)
        Console.Write("Такого элемента нет");
    else
        Console.Write($"Искомое значение: {array[row - 1, col - 1]}");
}



Console.Clear();
Console.Write("Задайте размерность двумерного массива: ");
string[] numbers = Console.ReadLine().Split(", ");
int row = int.Parse(numbers[0]),
    col = int.Parse(numbers[1]);
int[,] matrix = new int[row, col];
InputMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Задайте координаты элемента в двумерном массиве: ");
Console.Write("Номер строки двумерного массива: ");
int showRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца двумерного массива: ");
int showCol = Convert.ToInt32(Console.ReadLine());
SearchPosition(matrix, showRow, showCol);


