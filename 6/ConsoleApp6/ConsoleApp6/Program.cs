using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки (x1 y1):");
        string[] input1 = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(input1[0]);
        double y1 = Convert.ToDouble(input1[1]);

        Console.WriteLine("Введите координаты второй точки (x2 y2):");
        string[] input2 = Console.ReadLine().Split(' ');
        double x2 = Convert.ToDouble(input2[0]);
        double y2 = Convert.ToDouble(input2[1]);

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"Расстояние между точками: {distance}");
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        // Используем теорему Пифагора для вычисления расстояния
        double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        return distance;
    }
}
