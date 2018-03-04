using System;

namespace FractalControlTwo
{
	/// <summary>
	/// 
	/// </summary>

	public class KochsCurve
	{
		private int m_iterations;
		private System.Collections.ArrayList m_points;

		public KochsCurve(int iterations)
		{
			m_iterations = iterations;
		}

		public void paint(System.Drawing.Graphics gc, int x0, int y0, int x1, int y1, System.Drawing.Color color, int width)
		{
			LSystem ls = new LSystem(KochsPeanoCurveConstants.AXIOM, KochsPeanoCurveConstants.PRODUCTION);
			string ctr = ls.generate(m_iterations);

			int angle = 0;		//aktualne odchylenie od osi OX
			int delta = 60;		//zmiana k¹ta przy skrêcie
			double T = Math.PI/180;	//do skalowania na radiany
			int length;			//d³ugoœæ odcinka
			double x=(int)x0;	//punkt startowy od którego rozpoczyna siê rysowanie fraktala
			double y; 
			int oldx;
			int oldy;

			length = (int)((x1 - x0)/(Math.Pow(3, m_iterations))); //(x1-x0)=szerokoœæ okna
			if(length<3) length=3; 

			int totalWidth = (int)(length * Math.Pow(3, m_iterations)); //ca³kowita szerokoœæ
			int totalHeight = (int)(0.5 * totalWidth * Math.Sqrt(3.0) / 3) + 1; //ca³kowita wysokoœæ

			//wspó³czynniki skalowania krzywej
			double scaleX = (1.0 * totalWidth / (x1 - x0));
			if(scaleX < 1.0) scaleX = 1.0;
			double scaleY = (1.0 * totalHeight / (y1 - y0));
			if(scaleY < 1.0) scaleY = 1.0;

			//wycentrowanie w pionie
			if(totalHeight < (y1 - y0)) 
				y = (int)(y1 - (y1 - y0 - totalHeight) / 2);
			else y = y1;

			//tu skonczylem.

			m_points = new System.Collections.ArrayList();
			m_points.Add(new System.Drawing.Point((int)x,(int)y));

			//generowanie wspó³rzêdnych punktów wêz³owych krzywej
			for (int i=0; i<ctr.Length; i++)
			{
				string token = ctr[i].ToString();
				//System.Windows.Forms.MessageBox.Show(token);
				if(token==KochsPeanoCurveConstants.AXIOM)
				{
					oldx = (int)x;
					oldy = (int)y;
					x = (x + length*Math.Cos(angle*T));
					y = (y + length*Math.Sin(angle*T)); 
					
					if(x != oldx || y != oldy) //rysowanie tylko gdy wspó³rzêdne siê zmieni³y
						m_points.Add(new System.Drawing.Point((int)x,(int)y));
				}
				else if(token == KochsPeanoCurveConstants.RIGHT)
				{
					angle = (angle + delta) % 360;
				}
				else if(token == KochsPeanoCurveConstants.LEFT)
				{
					angle = (angle - delta) % 360;
				}
			}

			System.Collections.IEnumerator pt = m_points.GetEnumerator();
			System.Drawing.Point helpPoint = new System.Drawing.Point();
			int znacznik = 0;

			pt.Reset();

			while (pt.MoveNext())
			{
				oldx = (int)x;
				oldy = (int)y;
				helpPoint = (System.Drawing.Point)pt.Current;
				x = (int)(helpPoint.X / scaleX);
				y = (int)(y1 - (y1 - helpPoint.Y) / scaleY);
				if(x != oldx || y != oldy) //rysowanie tylko gdy wspó³rzêdne siê zmieni³y
				{
//					dc->LineTo((int)x, (int)y);
					if (znacznik == 0) znacznik++; else
					gc.DrawLine(new System.Drawing.Pen( new System.Drawing.SolidBrush(color), width), oldx, oldy, (int)x, (int)y);
					//					System.Windows.Forms.MessageBox.Show("oldx = "+((System.Drawing.Point)pt.Current).X.ToString()+", oldy= "+((System.Drawing.Point)pt.Current).Y.ToString());
//					System.Windows.Forms.MessageBox.Show("oldx = "+oldx.ToString()+", oldy= "+oldy.ToString()+"\nx = "+x.ToString()+", y= "+y.ToString());
				}
//				m_points.Remove((System.Drawing.Point)pt.Current);
			}
			m_points.Clear();
		}
	}
}
