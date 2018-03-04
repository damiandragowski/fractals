using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using FractalControl;

namespace Fraktale
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private FractalControl.FractalControl fractalControl1;
		private FractalControlTwo.ArtControl artControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.fractalControl1 = new FractalControl.FractalControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.artControl1 = new FractalControlTwo.ArtControl();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(656, 435);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.fractalControl1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(648, 409);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mandelbrot & Julia";
			// 
			// fractalControl1
			// 
			this.fractalControl1.AutoScroll = true;
			this.fractalControl1.AutoScrollMinSize = new System.Drawing.Size(400, 400);
			this.fractalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fractalControl1.Location = new System.Drawing.Point(0, 0);
			this.fractalControl1.Name = "fractalControl1";
			this.fractalControl1.Size = new System.Drawing.Size(648, 409);
			this.fractalControl1.TabIndex = 0;
			this.fractalControl1.Load += new System.EventHandler(this.fractalControl1_Load);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.artControl1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(648, 409);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Artur";
			// 
			// artControl1
			// 
			this.artControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.artControl1.Location = new System.Drawing.Point(0, 0);
			this.artControl1.Name = "artControl1";
			this.artControl1.Size = new System.Drawing.Size(648, 409);
			this.artControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 435);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Fraktale";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void fractalControl1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
