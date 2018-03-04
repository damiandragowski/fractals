using System;

namespace FractalControl
{
	/// <summary>
	/// Summary description for StackItem.
	/// </summary>
	[Serializable]
	public class StackItem
	{
		double m_acorner, m_bcorner, m_side;

		public StackItem()
		{
		}

		public StackItem(double acorner, double bcorner, double side)
		{
			m_acorner = acorner;
			m_bcorner = bcorner;
			m_side    = side;
		}

		public double acorner
		{
			get
			{
				return m_acorner;
			}
		}

		public double bcorner
		{
			get
			{
				return m_bcorner;
			}
		}

		public double side
		{
			get
			{
				return m_side;
			}
		}
	}
}
