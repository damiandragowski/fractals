using System;

namespace FractalControl
{
	/// <summary>
	/// Summary description for Julia.
	/// </summary>
	[Serializable]
	public class Julia : Fractal
	{
		public Julia()
		{
			complex.Real = -0.629578;
			complex.Imaginary = -0.41524;
		}

		public override StackItem GetInitialStackItem()
		{
			return new StackItem(-1.5, -1.5, 3.0);
		}

		public override double DistanceFromSet(int x, int y, double Gap, Complex Origin, out int nIterations)
		{
			double Size;
			nIterations = 0;

			Complex C = new Complex(complex);

			// Convert x, y Cartesian point to a complex number.
			Complex ComplexPoint = new Complex(x * Gap + Origin.Real, y * Gap + Origin.Imaginary);

			Complex Zero = ComplexPoint;

			do
			{
				// Zero = Zero ^ 2 + ComplexPoint
				double Tmp = (Zero.Real + Zero.Real) * Zero.Imaginary + C.Imaginary;
		
				Zero.Real = (Zero.Real * Zero.Real - Zero.Imaginary * Zero.Imaginary + C.Real);
		
				Zero.Imaginary = Tmp;
		
				Size = Zero.Size();
			} while (Size < MinimumDistance && ++nIterations < nMaxIterations);
	
			return Size;
		}
	}
}
