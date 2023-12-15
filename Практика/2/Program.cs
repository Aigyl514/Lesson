using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        SwapFirstAndLastRows(matrix);

        Console.WriteLine("\nМассив после обмена строк:");
        PrintMatrix(matrix);
    }

    static void SwapFirstAndLastRows(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);

        if (numRows >= 2)
        {
            int[] tempRow = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                tempRow[i] = matrix[0, i];
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[0, i] = matrix[numRows - 1, i];
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[numRows - 1, i] = tempRow[i];
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numColumns = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numColumns; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
