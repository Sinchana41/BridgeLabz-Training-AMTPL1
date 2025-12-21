using System;

namespace GeometricFigures;
class Circle
{
    public static void CircleMain()
    {
        Console.WriteLine("Enter the radius : ");
        double Radius = Convert.ToDouble(Console.ReadLine());
        const double Pie = 3.14;
        double Area = 2 * Radius * Radius * Pie;
        double Perimeter = 2 * Radius * Pie;
        Console.WriteLine("Area : {0}",Area);
        Console.WriteLine("Perimeter : {0}", Perimeter);
    }
}