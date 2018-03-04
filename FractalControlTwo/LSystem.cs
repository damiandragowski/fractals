using System;

namespace FractalControlTwo
{
	/// <summary>
	/// 
	/// </summary>
	public class LSystem
	{
		private string m_axiom;
		private string m_production;
		private int m_iterations;

		public LSystem(string axiom, string production)
		{
			m_axiom = axiom;
			m_production = production;
			m_iterations = 0;
		}

		public string generate(int iterations)
		{
			string retVal = m_axiom;
			m_iterations = iterations;
	
			for(int i=0; i < m_iterations; i++)
				retVal = retVal.Replace(m_axiom, m_production);

			return retVal;
		}
	}
}
