using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"A({m}, {n}) = {result}");

        Console.ReadLine();
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
