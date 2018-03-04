using System;

namespace FractalControlTwo
{
	/// <summary>
	/// 
	/// </summary>
	public class PeanoCurve
	{
		private int m_iterations;

		public PeanoCurve(int iterations)
		{
			this.m_iterations = iterations;
		}

		public void paint(System.Drawing.Graphics gc, int x0, int y0, int x1, int y1, System.Drawing.Color color, int width)
		{
			LSystem ls = new LSystem(KochsPeanoCurveConstants.PAXIOM, KochsPeanoCurveConstants.PPRODUCTION);
			string ctr = ls.generate(m_iterations);

			int angle = 0;		//aktualne odchylenie od osi OX
			int delta = 90;		//zmiana k¹ta przy skrêcie
			double T = Math.PI/180;	//do skalowania na radiany
			int length;			//d³ugoœæ odcinka
			double x=(int)x0;	
			double y=0.5*(y1-y0); //œrodek osi OY
			int oldx;
			int oldy;

			length = (int)((y1 - y0)/(Math.Pow(3, m_iterations))); //(y1-y0)=wysokoœæ okna
			if(length<3)
			{
				length=3;
				x=0;
			} 
			else x=(x1-x0)/2-(y1-y0)/2;

//			gc->MoveTo((int)x, (int)y);
//			System.Windows.Forms.MessageBox.Show(ctr);
//			System.Windows.Forms.MessageBox.Show(m_iterations.ToString());

			for (int i=0; i<ctr.Length; i++)
			{
				string token = ctr[i].ToString();

				if(token==KochsPeanoCurveConstants.PAXIOM)
				{
					oldx = (int)x;
					oldy = (int)y;
					x = (x + length*Math.Cos(angle*T));
					y = (y + length*Math.Sin(angle*T)); 
					if(x != oldx || y != oldy) //rysowanie tylko gdy wspó³rzêdne siê zmieni³y
					{
						gc.DrawLine(new System.Drawing.Pen( new System.Drawing.SolidBrush(color), width), oldx, oldy, (int)x, (int)y);
//						dc->LineTo((int)x, (int)y);
//						dc->MoveTo((int)x, (int)y);
					}
				}
				else if(token == KochsPeanoCurveConstants.PRIGHT)
				{
					angle = (angle + delta) % 360;
				}
				else if(token == KochsPeanoCurveConstants.PLEFT)
				{
					angle = (angle - delta) % 360;
				}
			}
			
		}
	}
}
