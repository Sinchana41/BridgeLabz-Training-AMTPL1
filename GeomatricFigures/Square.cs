using System;

namespace GeometricFigures;
public class Square
{
	public void SquareMain()
	{
		Console.WriteLine("Enter the length of the Square");
		int Length = Convert.ToInt32(Console.ReadLine());
		
		int Perimeter = 4 * Length;
		int Area = Length * Length;
		Console.WriteLine("Perimeter : {0} Area : {1}",Perimeter, Area);
	}
}
