using System;

namespace GeometricFigures;
public class Triangle
{
    public  void TriangleMain()
    {
        Console.WriteLine("Enter the one side  length of the Triangle");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Second side  length of the Triangle");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the base  length of the Triangle");
        int C = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the heigth of the Triangle");
        int H = Convert.ToInt32(Console.ReadLine());

        int Perimeter = A + B + C; ;
        double Area = (0.5) * C * H;
        Console.WriteLine("Perimeter : {0} Area : {1}", Perimeter, Area);
    }
}
