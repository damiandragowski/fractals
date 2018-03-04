using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FractalControl
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class FractalControl : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public Bitmap     m_Bitmap = new Bitmap(SettingForm.Resolution, SettingForm.Resolution);
		public ZoomRegion m_ZoomRegion = new ZoomRegion();
		public bool       m_bUserIsZooming;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		public Fractal m_Fractal;
		private bool m_bFrac=false;


		public FractalControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call
			AutoScrollMinSize = new Size(SettingForm.Resolution, SettingForm.Resolution);
			m_Fractal = new Julia();
			textBox1.Text = "" + m_Fractal.ComplexReal;
			textBox2.Text = "" + m_Fractal.ComplexImg;
			m_Fractal.Plot(this.m_Bitmap, (StackItem) m_Fractal.m_Stack.Peek());
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(448, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 104);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Zbiory";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Julie";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(24, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Mandelbrot";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(448, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(136, 144);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Zespolona";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "rzeczywista";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "urojona";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(16, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(472, 304);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "przerysuj";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FractalControl
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FractalControl";
			this.Size = new System.Drawing.Size(616, 392);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FractalControl_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalControl_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FractalControl_MouseMove);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FractalControl_MouseDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void DrawReversibleFrame()
		{
			ControlPaint.DrawReversibleFrame(RectangleToScreen(m_ZoomRegion.Rect), Color.Black, FrameStyle.Dashed);
		}

		private void FractalControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Point P = new Point(AutoScrollPosition.X, AutoScrollPosition.Y); 

			e.Graphics.DrawImage(m_Bitmap, P);

			if (!m_ZoomRegion.IsUndefined())
			{
				DrawReversibleFrame();
			}
		
		}

		private void Recalc()
		{
			m_Fractal.Plot(this.m_Bitmap, (StackItem) m_Fractal.m_Stack.Peek());
			Invalidate();
		}


		private void FractalControl_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				m_bUserIsZooming = false;
				if (!this.m_ZoomRegion.IsUndefined())
				{
					StackItem PrevItem = (StackItem) m_Fractal.m_Stack.Peek();

					int Left = this.m_ZoomRegion.Rect.Left - this.AutoScrollPosition.X;
					int Top  = this.m_ZoomRegion.Rect.Top  - this.AutoScrollPosition.Y;

					double acorner = PrevItem.acorner + PrevItem.side * (double) Left / (double) SettingForm.Resolution;
					double bcorner = PrevItem.bcorner + PrevItem.side * (double) Top  / (double) SettingForm.Resolution;
					double side    = PrevItem.side * (double) this.m_ZoomRegion.Rect.Width / (double) SettingForm.Resolution;

					m_Fractal.m_Stack.Push(new StackItem(acorner, bcorner, side));
					this.m_ZoomRegion.MakeUndefined();

					Recalc();
				}

			}
			if (e.Button == MouseButtons.Right)
			{
				if (m_Fractal.m_Stack.Count > 1)
				{
					m_Fractal.m_Stack.Pop();
					Recalc();
				}
			}
		}

		private void FractalControl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (m_bUserIsZooming && e.Button == MouseButtons.Left)
			{
				ControlPaint.DrawReversibleFrame(RectangleToScreen(m_ZoomRegion.Rect), Color.Black, FrameStyle.Dashed);

				m_ZoomRegion.Update(new Point(e.X, e.Y));

				DrawReversibleFrame();
			}		
		}

		private void FractalControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.X < SettingForm.Resolution && e.Y < SettingForm.Resolution)
			{
				DrawReversibleFrame();

				m_ZoomRegion.Create(new Point(e.X, e.Y));

				m_bUserIsZooming = true;
			}		
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( m_bFrac ) 
			{
				m_bFrac = false;
				m_Fractal = null;
				m_Fractal = new Julia();
				textBox1.Text = "" + m_Fractal.ComplexReal;
				textBox2.Text = "" + m_Fractal.ComplexImg;
				Recalc();
			}
			else
			{
				m_bFrac = true;
				m_Fractal = null;
				m_Fractal = new Mandelbrot();
				textBox1.Text = "" + m_Fractal.ComplexReal;
				textBox2.Text = "" + m_Fractal.ComplexImg;
				Recalc();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				double real = Double.Parse(textBox1.Text);
				double img = Double.Parse(textBox2.Text);
				m_Fractal.complex.Imaginary = img;
				m_Fractal.complex.Real = real;
				Recalc();
			}
			catch ( Exception err )
			{
				MessageBox.Show(this, "Wartosc musi byæ liczba reczywista");
			}
		}


	}
}
