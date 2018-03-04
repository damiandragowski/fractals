using System;

namespace FractalControl
{
	/// <summary>
	/// Summary description for Mandelbrot.
	/// </summary>
	[Serializable]
	public class Mandelbrot : Fractal
	{
		public Mandelbrot()
		{
			complex.Real = complex.Imaginary = 0;
		}

		public override StackItem GetInitialStackItem()
		{
			return new StackItem(-2.0, -1.25, 2.5);
		}

		public override double DistanceFromSet(int x, int y, double Gap, Complex Origin, out int nIterations)
		{
			double Size;
			nIterations = 0;

			// Convert x, y Cartesian point to a complex number.
			Complex ComplexPoint = new Complex(x * Gap + Origin.Real, y * Gap + Origin.Imaginary);

			Complex Zero = new Complex(complex);

			do
			{
				// Zero = Zero ^ 2 + ComplexPoint
				double Tmp = (Zero.Real + Zero.Real) * Zero.Imaginary + ComplexPoint.Imaginary;
		
				Zero.Real = (Zero.Real * Zero.Real - Zero.Imaginary * Zero.Imaginary + ComplexPoint.Real);
		
				Zero.Imaginary = Tmp;
		
				Size = Zero.Size();
			} while (Size < MinimumDistance && ++nIterations < nMaxIterations);
	
			return Size;
		}
	}
}
