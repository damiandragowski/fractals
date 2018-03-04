using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FractalControl
{
	/// <summary>
	/// Summary description for ZoomRegion.
	/// </summary>
	public class ZoomRegion
	{
		private Rectangle m_Rectangle;

		public Rectangle Rect
		{
			get 
			{ 
				return m_Rectangle;
			}
		}

		public ZoomRegion()
		{
		}

		public void DrawFocusRect(Graphics G)
		{
			Pen P = new Pen(Color.Gray);

			G.DrawRectangle(P, m_Rectangle);
		}

		public void Create(Point P)
		{
			m_Rectangle = new Rectangle(P, new Size(1, 1));
		}

		public void Update(Point P)
		{
			int MaxXY = SettingForm.Resolution - 1;

			int MinX = Math.Min(Math.Min(m_Rectangle.Left, P.X), MaxXY);
			int MaxX = Math.Min(Math.Max(m_Rectangle.Left, P.X), MaxXY);

			int MinY = Math.Min(Math.Min(m_Rectangle.Top, P.Y), MaxXY);
			int MaxY = Math.Min(Math.Max(m_Rectangle.Top, P.Y), MaxXY);

			int nSide = Math.Min(MaxX - MinX, MaxY - MinY);

			m_Rectangle = new Rectangle(m_Rectangle.Left, m_Rectangle.Top, nSide, nSide);

			if (m_Rectangle.Right >= SettingForm.Resolution)
			{
				int w = SettingForm.Resolution - m_Rectangle.Left;
				m_Rectangle = new Rectangle(m_Rectangle.X, m_Rectangle.Y, w, w);
			}

			if (m_Rectangle.Bottom >= SettingForm.Resolution)
			{
				int h = SettingForm.Resolution - m_Rectangle.Top;
				m_Rectangle = new Rectangle(m_Rectangle.X, m_Rectangle.Y, h, h);
			}
		}

		public void MakeUndefined()
		{
			m_Rectangle = new Rectangle(0, 0, 0, 0);
		}

		public bool IsUndefined()
		{
			return m_Rectangle.IsEmpty;
		}
	}
}
