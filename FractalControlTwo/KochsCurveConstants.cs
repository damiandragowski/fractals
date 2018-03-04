using System;

namespace FractalControlTwo
{
	/// <summary>
	/// 
	/// </summary>
	abstract class KochsPeanoCurveConstants
	{
		//Koch section
		public const string AXIOM		= "F";
		public const string PRODUCTION	= "F-F++F-F";
		public const string RIGHT		= "+";
		public const string LEFT		= "-";
		//Peano section
		public const string PAXIOM		= "F";
		public const string PPRODUCTION	= "F-F+F+F+F-F-F-F+F";
		public const string PRIGHT		= "+";
		public const string PLEFT		= "-";
	}
}
