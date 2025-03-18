using System;

class Program
{
    static double DistanceFromPointToLine(double x1, double y1, double A, double B, double C)
    {
        return Math.Abs(A * x1 + B * y1 + C) / Math.Sqrt(A * A + B * B);
    }

    static void Main()
    {
        Console.Write("Введите x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите B: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите C: ");
        double C = Convert.ToDouble(Console.ReadLine());
        
        double distance = DistanceFromPointToLine(x1, y1, A, B, C);
        Console.WriteLine($"Расстояние от точки до прямой: {distance:F4}");
    }
}
