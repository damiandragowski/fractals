using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FractalControlTwo
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class ArtControl : System.Windows.Forms.UserControl
	{
		private int FractalType;
		private int LineSize;
		private int IterCounter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Drawing.Color color;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ArtControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			FractalType = 1;
			IterCounter = 4;
			color = Color.FromArgb(255,0,0);
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call

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
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(464, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 168);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fraktale";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(16, 104);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "Zbiór Cantora";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 80);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "trójk¹t Sierpiñskiego";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Krzywa Peano";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(16, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Krzywa Kocha";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 400);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// textBox1
			// 
			this.errorProvider1.SetError(this.textBox1, "Musisz podaæ liczbê z zakresu 1-10");
			this.textBox1.Location = new System.Drawing.Point(472, 224);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "1";
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(472, 304);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Kolor Linii";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// colorDialog1
			// 
			this.colorDialog1.Color = System.Drawing.Color.White;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// textBox2
			// 
			this.errorProvider1.SetError(this.textBox2, "Podaj liczbe 1-10");
			this.textBox2.Location = new System.Drawing.Point(472, 272);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "4";
			this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(472, 200);
			this.label1.Name = "label1";
			this.label1.TabIndex = 4;
			this.label1.Text = "Gruboœæ linii:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(472, 248);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "Iloœæ iteracji:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(472, 344);
			this.button2.Name = "button2";
			this.button2.TabIndex = 7;
			this.button2.Text = "Odœwierz";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ArtControl
			// 
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "ArtControl";
			this.Size = new System.Drawing.Size(624, 424);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			int dimX, dimY;
			dimX = panel1.Width;
			dimY = panel1.Height;
			switch (FractalType)
			{
				case 1: 
					KochsCurveFractal(Graphics.FromHwnd(panel1.Handle),0,0,dimX-1,dimY-1,IterCounter,color,LineSize);
					break;
				case 2: 
					PeanoCurveFractal(Graphics.FromHwnd(panel1.Handle),0,0,dimX-1,dimY-1,IterCounter,color,LineSize);
					break;
				case 3: 
					SierpinskiFractal(Graphics.FromHwnd(panel1.Handle),0,dimY-1,(dimX-1)/2,0,dimX-1,dimY-1,IterCounter,color,LineSize);
					break;
				case 4: 
					CantorFractal(Graphics.FromHwnd(panel1.Handle),0,0,dimX-1,dimY-1,IterCounter,color,LineSize);
					break;
			}
		}

		/// <summary>
		/// Metoda rysujaca krzywa Kocha.
		/// </summary>
		/// <param name="gc">okresla, na czym ma sie odbywac rosyowanie.</param>
		/// <param name="x0">punkt startowy rysowania (skladowa x).</param>
		/// <param name="y0">punkt startowy rysowania (skladowa y).</param>
		/// <param name="x1">punkt koncowy rysowania (skladowa x).</param>
		/// <param name="y1">punkt koncowy rysowania (skladowa y).</param>
		/// <param name="deep">glebokosc - zlozonosc fraktala.</param>
		/// <param name="color">kolor, jakim ma sie odbywac rysowanie.</param>
		/// <param name="width">grubosc linii, jaka ma sie odbywac rysowanie.</param>
		void KochsCurveFractal(Graphics gc, int x0, int y0, int x1, int y1, int deep, Color color, int width)
		{
			KochsCurve k = new KochsCurve(deep);
			k.paint(gc, x0, y0, x1, y1, color, width);
		}

		/// <summary>
		/// Metoda rysujaca krzywa Peano.
		/// </summary>
		/// <param name="gc">okresla, na czym ma sie odbywac rosyowanie.</param>
		/// <param name="x0">punkt startowy rysowania (skladowa x).</param>
		/// <param name="y0">punkt startowy rysowania (skladowa y).</param>
		/// <param name="x1">punkt koncowy rysowania (skladowa x).</param>
		/// <param name="y1">punkt koncowy rysowania (skladowa y).</param>
		/// <param name="deep">glebokosc - zlozonosc fraktala.</param>
		/// <param name="color">kolor, jakim ma sie odbywac rysowanie.</param>
		/// <param name="width">grubosc linii, jaka ma sie odbywac rysowanie.</param>
		void PeanoCurveFractal(Graphics gc, int x0, int y0, int x1, int y1, int deep, Color color, int width)
		{
			PeanoCurve p = new PeanoCurve(deep);
			p.paint(gc, x0, y0, x1, y1, color, width);
		}

		/// <summary>
		/// Metoda rysujaca trojkat Sierpinskiego.
		/// </summary>
		/// <param name="gc">okresla, na czym ma sie odbywac rosyowanie.</param>
		/// <param name="x0">lewy dolny wierzcholek rysowania (skladowa x).</param>
		/// <param name="y0">lewy dolny wierzcholek rysowania (skladowa y).</param>
		/// <param name="x1">gorny wierzcholek rysowania (skladowa x).</param>
		/// <param name="y1">gorny wierzcholek rysowania (skladowa y).</param>
		/// <param name="x2">prawy dolny wierzcholek rysowania (skladowa x).</param>
		/// <param name="y2">prawy dolny wierzcholek rysowania (skladowa y).</param>
		/// <param name="deep">glebokosc - zlozonosc fraktala.</param>
		/// <param name="color">kolor, jakim ma sie odbywac rysowanie.</param>
		/// <param name="width">grubosc linii, jaka ma sie odbywac rysowanie.</param>
		void SierpinskiFractal(Graphics gc, int x0, int y0, int x1, int y1, int x2, int y2, int deep, Color color, int width)
		{
			if (deep > 0)
			{
				SierpinskiFractal(gc, x0, y0, x0 + (x1 - x0)/2, y0 + (y1 - y0)/2, x0 + (x2 - x0)/2, y2, --deep, color, width);
				SierpinskiFractal(gc, x0 + (x1 - x0)/2, y0 + (y1 - y0)/2, x1, y1, x1 + (x2 - x1)/2, y1 + (y2 - y1)/2, deep, color, width);
				SierpinskiFractal(gc, x0 + (x2 - x0)/2, y2, x1 + (x2 - x1)/2 , y1 + (y2 - y1)/2, x2 ,y2, deep, color, width);
			}
			gc.DrawLine(new Pen( new SolidBrush(color), width), x0, y0, x1, y1);
			gc.DrawLine(new Pen( new SolidBrush(color), width), x0, y0, x2, y2);
			gc.DrawLine(new Pen( new SolidBrush(color), width), x1, y1, x2, y2);
		}

		/// <summary>
		/// Metoda rysujaca zbior Cantora.
		/// </summary>
		/// <param name="gc">okresla, na czym ma sie odbywac rosyowanie.</param>
		/// <param name="x0">punkt startowy rysowania (skladowa x).</param>
		/// <param name="y0">punkt startowy rysowania (skladowa y).</param>
		/// <param name="x1">punkt koncowy rysowania (skladowa x).</param>
		/// <param name="y1">punkt koncowy rysowania (skladowa y).</param>
		/// <param name="deep">glebokosc - zlozonosc fraktala.</param>
		/// <param name="color">kolor, jakim ma sie odbywac rysowanie.</param>
		/// <param name="width">grubosc linii, jaka ma sie odbywac rysowanie.</param>
		void CantorFractal(Graphics gc, int x0, int y0, int x1, int y1, int deep, Color color, int width)
		{
			if (deep > 0)
			{
				CantorFractal(gc,				x0,					y0,	x0 + (x1-x0)/3, y0 + (y1-y0)/3, --deep, color, width);
				CantorFractal(gc,				x0,	 y0 +2*((y1-y0)/3), x0 + (x1-x0)/3,				y1, deep, color, width);
				CantorFractal(gc, x0 + 2*((x1-x0)/3),				y0,				x1,	y0 + (y1-y0)/3, deep, color, width);
				CantorFractal(gc, x0 + 2*((x1-x0)/3), y0 +2*((y1-y0)/3),			x1,				y1, deep, color, width);
			}
			gc.DrawLine(new Pen( new SolidBrush(color), width), x0, y0, x0, y1);
			gc.DrawLine(new Pen( new SolidBrush(color), width), x0, y0, x1, y0);
			gc.DrawLine(new Pen( new SolidBrush(color), width), x0, y1, x1, y1);
			gc.DrawLine(new Pen( new SolidBrush(color), width), x1, y0, x1, y1);
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( radioButton1.Checked == true ) 
			{
				FractalType = 1;
				panel1.Invalidate();
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( radioButton2.Checked == true ) 
			{
				FractalType = 2;
				panel1.Invalidate();
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( radioButton3.Checked == true ) 
			{
				FractalType = 3;
				panel1.Invalidate();
			}
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( radioButton4.Checked == true ) 
			{
				FractalType = 4;
				panel1.Invalidate();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if ( colorDialog1.ShowDialog(this) == DialogResult.OK ) 
			{
				color = colorDialog1.Color;
				panel1.Invalidate();
			}			
		}

		private bool IsNumeric(string strText)
		{
			try 
			{
				int test = int.Parse(strText);
				return true;
			}
			catch (Exception ) 
			{
				return false;
			}
		}



		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(IsNumeric(textBox1.Text) || textBox1.Text.Length==0)  
			{
				LineSize=int.Parse(textBox1.Text);
				errorProvider1.SetError(textBox1, "");
			}
			else 
			{
				errorProvider1.SetError(textBox1, "Nie prawid³owa liczba !!!");
			}
		}

		private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(IsNumeric(textBox2.Text) || textBox2.Text.Length==0)  
			{
				IterCounter=int.Parse(textBox2.Text);
				errorProvider1.SetError(textBox2, "");
			}
			else 
			{
				errorProvider1.SetError(textBox2, "Nie prawid³owa liczba !!! ( przedzia³ 1-10 ) ");
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			panel1.Invalidate();
		}



	}
}
