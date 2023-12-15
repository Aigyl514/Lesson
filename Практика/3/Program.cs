using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        int minSumRow = FindMinSumRow(matrix);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow}");
    }

    static int FindMinSumRow(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numColumns = matrix.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < numRows; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < numColumns; j++)
            {
                currentSum += matrix[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        return minSumRow;
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
