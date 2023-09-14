using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину окружности:");
        double circumference = Convert.ToDouble(Console.ReadLine());

        double radius = circumference / (2 * Math.PI);
        double area = (Math.PI * Math.Pow(radius, 2));

        Console.WriteLine($"Площадь круга: {area}");
    }
}
