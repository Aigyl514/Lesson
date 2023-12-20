using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int[] myArray = RandomNUM(10, random);

        Console.WriteLine("Элементы обычного массива:");
        PrintArray(myArray);

        Console.WriteLine("\nЭлементы массива, начиная с конца:");
        ArrayReversed(myArray, myArray.Length - 1);

        Console.ReadLine();
    }

    static int[] RandomNUM(int length, Random random)
    {
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 100); // Генерация случайных чисел от 1 до 100
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void ArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            ArrayReversed(array, index - 1);
        }
    }
}
