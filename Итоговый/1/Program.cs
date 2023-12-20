using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        double m = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        double n = double.Parse(Console.ReadLine());

        NaturalNumbers(m, n);

        Console.ReadLine();
    }

    static void NaturalNumbers(double m, double n)
    {
        if (m <= n)
        {
            if (m % 1 == 0 && m > 0) 
            {
                Console.WriteLine((int)m);
            }

            NaturalNumbers(m + 1, n);
        }
    }
}
