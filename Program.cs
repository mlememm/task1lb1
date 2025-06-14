using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблиця квадратів чисел від 1 до 10:");
        Console.WriteLine("-----------------------------------");
        for (int i = 1; i <= 10; i++)
        {
            int square = i * i;
            Console.WriteLine($"Число: {i,-5} Квадрат: {square}");
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Натисніть будь-яку клавішу, щоб вийти...");
        Console.ReadKey();
    }
}
