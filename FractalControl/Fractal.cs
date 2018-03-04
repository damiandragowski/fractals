using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FractalControl
{
	/// <summary>
	/// Summary description for Fractal.
	/// </summary>
	[Serializable]
	public abstract class Fractal
	{
		public Complex complex=new Complex(0.0, 0.0);
		public double ComplexReal
		{
			get
			{
				return complex.Real;
			}
			set
			{
				complex.Real = ComplexReal;
			}
		}
		public double ComplexImg
		{
			get
			{
				return complex.Imaginary;
			}
			set
			{
				complex.Imaginary = ComplexImg;
			}
		}


		public Fractal()
		{
			m_Stack.Push(GetInitialStackItem());
		}

		protected const int    nMaxIterations  = 100;
		protected const double MinimumDistance = 4.0;
		public Stack		   m_Stack         = new Stack();

		public abstract double DistanceFromSet(int x, int y, double Gap, Complex Origin, out int nIterations);

		public abstract StackItem GetInitialStackItem();

		public void Plot(Bitmap B, StackItem SI)
		{
			Cursor.Current = Cursors.WaitCursor;

			double Gap = SI.side / B.Width;

			Complex Origin = new Complex(SI.acorner, SI.bcorner);

			for (int x = 0; x < B.Width; x++)
			{
				for (int y = 0; y < B.Height; y++)
				{
					int nColor, nIterations;

					double Distance = DistanceFromSet(x, y, Gap, Origin, out nIterations);

					if (Distance <= MinimumDistance)
					{
						nColor = 0;
					}
					else
					{
						nColor = (int) (((double) (nMaxIterations - nIterations) / (double) nMaxIterations) * (double) (ColorMap.nColors - 1));
					
						if (nColor < 0 || nColor > ColorMap.nColors - 1)
						{
							nColor = ColorMap.nColors - 1;
						}
					}
				
					B.SetPixel(x, y, ColorMap.crColors[nColor]);
				}
			}
			
			Cursor.Current = Cursors.Arrow;
		}

		public static void ReadFromFile(ref Fractal NewFractal, string FileName)
		{
			Stream Read = null;

			try
			{
				Read = File.OpenRead(FileName);

				BinaryFormatter BF = new BinaryFormatter();

				Fractal Tmp = (Fractal) BF.Deserialize(Read);

				NewFractal = Tmp;
			}
			catch(Exception)
			{
				MessageBox.Show("Cannot read file " + FileName, "Fractal Viewer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
				if (Read != null)
				{
					Read.Close();
				}
			}
		}

		public void WriteToFile(string FileName)
		{
			FileStream Write = null;

			try
			{
				Write = File.OpenWrite(FileName);

				BinaryFormatter BF = new BinaryFormatter();

				BF.Serialize(Write, this);
			}
			catch(Exception)
			{
				MessageBox.Show("Cannot save file " + FileName, "Fractal Viewer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{
				if (Write != null)
				{
					Write.Close();
				}
			}
		}

		// This is a seperate class so we don't serialize the 
		// color table when we serialize Fractal objects.
		private class ColorMap
		{
			private const int nBasis  = 8;
			public const  int nColors = nBasis * nBasis * nBasis;
	
			static public readonly Color[] crColors;

			static ColorMap()
			{
				const int nFactor = 255;

				crColors = new Color[nColors];

				int nIndex = 0;

				for (int i = 0; i < nBasis; i++)
				{
					for (int j = 0; j < nBasis; j++)
					{
						for (int k = 0; k < nBasis; k++)
						{
							crColors[nIndex++] = Color.FromArgb(i * nFactor / (nBasis - 1), j * nFactor / (nBasis - 1), k * nFactor / (nBasis - 1));
						}
					}
				}
			}
		}


	}
}
