using System;

namespace GeometricFigures;
public class Rectangle
{
    public static void RectangleMain()
    {
        Console.WriteLine("Enter the length of the Rectangle");
        int Length = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter the breadth of the Rectangle");
        int Breadth = Convert.ToInt32(Console.ReadLine());

        int Perimeter = 2 * (Length + Breadth);
        int Area = Length  * Breadth;
        Console.WriteLine("Perimeter : {0} Area : {1}", Perimeter, Area);
    }
}
