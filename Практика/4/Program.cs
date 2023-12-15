using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[,] matrix = {
            {3, 7, 2, 9},
            {8, 5, 1, 4},
            {6, 12, 11, 10},
            {15, 14, 13, 16}
        };

        Console.WriteLine("Исходный массив:");
        DisplayMatrix(matrix);

        int minElementRow, minElementColumn;
        FindMinElementPosition(matrix, out minElementRow, out minElementColumn);

        int[,] modifiedMatrix = RemoveRowAndColumn(matrix, minElementRow, minElementColumn);

        Console.WriteLine("\nМассив после удаления строки и столбца с наименьшим элементом:");
        DisplayMatrix(modifiedMatrix);
    }

    static void FindMinElementPosition(int[,] matrix, out int minElementRow, out int minElementColumn)
    {
        int numRows = matrix.GetLength(0);
        int numColumns = matrix.GetLength(1);

        int minElement = matrix[0, 0];
        minElementRow = 0;
        minElementColumn = 0;

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numColumns; j++)
            {
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                    minElementRow = i;
                    minElementColumn = j;
                }
            }
        }
    }

    static int[,] RemoveRowAndColumn(int[,] matrix, int rowToRemove, int columnToRemove)
    {
        int numRows = matrix.GetLength(0);
        int numColumns = matrix.GetLength(1);

        int[,] resultMatrix = new int[numRows - 1, numColumns - 1];

        int resultRow = 0;
        for (int i = 0; i < numRows; i++)
        {
            if (i == rowToRemove)
                continue;

            int resultColumn = 0;
            for (int j = 0; j < numColumns; j++)
            {
                if (j == columnToRemove)
                    continue;

                resultMatrix[resultRow, resultColumn] = matrix[i, j];
                resultColumn++;
            }

            resultRow++;
        }

        return resultMatrix;
    }

    static void DisplayMatrix(int[,] matrix)
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
