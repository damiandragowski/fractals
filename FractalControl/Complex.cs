using System;

namespace FractalControl
{
	/// <summary>
	/// Summary description for Complex.
	/// </summary>
	public struct Complex
	{
		private double m_Real, m_Imaginary;

		public Complex(Complex c)
		{
			m_Real      = c.m_Real;
			m_Imaginary = c.m_Imaginary;
		}

		public Complex(double Real, double Imaginary)
		{
			m_Real      = Real;
			m_Imaginary = Imaginary;
		}

		public double Size()
		{
			return m_Real * m_Real + m_Imaginary * m_Imaginary;
		}

		public double Real
		{
			get
			{
				return m_Real;
			}

			set
			{
				m_Real = value;
			}
		}

		public double Imaginary
		{
			get
			{
				return m_Imaginary;
			}

			set
			{
				m_Imaginary = value;
			}
		}
	}
}
