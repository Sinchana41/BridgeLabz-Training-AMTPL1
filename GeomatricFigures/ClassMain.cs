using System;

namespace GeometricFigures;
public class Classmain
{
    public static void Main(string[] args)
    {
        Circle.CircleMain();

        Square square = new Square();
        square.SquareMain();
       
        Rectangle.RectangleMain();
       
        Triangle triangle = new Triangle();
        triangle.TriangleMain();
    }

}
