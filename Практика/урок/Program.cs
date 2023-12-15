using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введите позиции элемента в матрице:");

        Console.Write("Строка: ");
        if (int.TryParse(Console.ReadLine(), out int row) && row >= 0 && row < matrix.GetLength(0))
        {
            Console.Write("Столбец: ");
            if (int.TryParse(Console.ReadLine(), out int column) && column >= 0 && column < matrix.GetLength(1))
            {
                int result = GetMatrixElement(matrix, row, column);
                if (result != int.MinValue)
                {
                    Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {result}");
                }
                else
                {
                    Console.WriteLine("Элемента с указанными позициями нет в матрице.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод для столбца.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для строки.");
        }
    }

    static int GetMatrixElement(int[,] matrix, int row, int column)
    {
        if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
        {
            return matrix[row, column];
        }
        else
        {
            return int.MinValue;
        }
    }
}
