
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kalkulator2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		
		void Button24Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("explorer.exe", "Q:\\ALL\\WYSYŁKA");
			}
			catch
			{
				MessageBox.Show("Brak poprawnej ścieżki do folderu!");
			}
		}
		
//////////////////////////////////////////////////////////////////////////////////////////////		

		void Button23Click(object sender, EventArgs e)
		{
			Note notatnik = new Note();
			notatnik.Show();
		}
		
		void WynikBtAClick(object sender, EventArgs e)
		{
			A_bufor.Text = wynik.Text;
		}
		
		void WynikBtBClick(object sender, EventArgs e)
		{
			B_bufor.Text = wynik.Text;
		}
		
		void WynikBtCClick(object sender, EventArgs e)
		{
			C_bufor.Text = wynik.Text;
		}
		
		void WynikBtDClick(object sender, EventArgs e)
		{
			D_bufor.Text = wynik.Text;
		}
		
//////////////////////////////////////////////////////////////////////////////////////////////		


		void A_bt1Click(object sender, EventArgs e)
		{
			A_bufor.Text = x_wartosc.Text;
		}
		
		void B_bt1Click(object sender, EventArgs e)
		{
			B_bufor.Text = x_wartosc.Text;
		}
		
		void C_bt1Click(object sender, EventArgs e)
		{
			C_bufor.Text = x_wartosc.Text;
		}

		void D_bt1Click(object sender, EventArgs e)
		{
			D_bufor.Text = x_wartosc.Text;
		}

//---------------------------------------------------------------
		
		void A_bt2Click(object sender, EventArgs e)
		{
			A_bufor.Text = y_wartosc.Text;
		}
		
		void B_bt2Click(object sender, EventArgs e)
		{
			B_bufor.Text = y_wartosc.Text;
		}
		
		void C_bt2Click(object sender, EventArgs e)
		{
			C_bufor.Text = y_wartosc.Text;
		}
		
		void D_bt2Click(object sender, EventArgs e)
		{
			D_bufor.Text = y_wartosc.Text;
		}
		
// --------------------------------------------------------------
		
		void X_wynikClick(object sender, EventArgs e)
		{
			x_wartosc.Text = wynik.Text;
		}
		
		void Y_wynikClick(object sender, EventArgs e)
		{
			y_wartosc.Text = wynik.Text;
		}
		
// ---------------------------------------------------------------		

		void CzyscAllClick(object sender, EventArgs e)
		{
			wynik.Text = x_wartosc.Text = y_wartosc.Text = A_bufor.Text = B_bufor.Text = C_bufor.Text = D_bufor.Text = "";
		}
		
		void CzyscBuforClick(object sender, EventArgs e)
		{
			 A_bufor.Text = B_bufor.Text = C_bufor.Text = D_bufor.Text = "";
		}
			
		void CzyscWynikClick(object sender, EventArgs e)
		{
			wynik.Text = "";
		}
		
		void LbXClick(object sender, EventArgs e)
		{
			x_wartosc.Text = "";
		}
		
		void LbYClick(object sender, EventArgs e)
		{
			y_wartosc.Text = "";
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			string zm;
			zm = x_wartosc.Text;
			x_wartosc.Text = y_wartosc.Text;
			y_wartosc.Text = zm;	
		}
		
// ---------------------------------------------------------------
		
		void X_bufor_AClick(object sender, EventArgs e)
		{
			x_wartosc.Text = A_bufor.Text;
		}
		
		void Y_bufor_AClick(object sender, EventArgs e)
		{
			y_wartosc.Text = A_bufor.Text;
		}
		
		void X_bufor_BClick(object sender, EventArgs e)
		{
			x_wartosc.Text = B_bufor.Text;
		}
		
		void Y_bufor_BClick(object sender, EventArgs e)
		{
			y_wartosc.Text = B_bufor.Text;
		}
		
		void C_bufor_AClick(object sender, EventArgs e)
		{
			x_wartosc.Text = C_bufor.Text;
		}
		
		void Y_bufor_CClick(object sender, EventArgs e)
		{
			y_wartosc.Text = C_bufor.Text;
		}
		
		void D_bufor_AClick(object sender, EventArgs e)
		{
			x_wartosc.Text = D_bufor.Text;
		}
		
		void Y_bufor_DClick(object sender, EventArgs e)
		{
			y_wartosc.Text = D_bufor.Text;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			ClientSize = new System.Drawing.Size(353, 543);
		}
		
// ---------------------------------------------------------------
		
		void DodajBtClick(object sender, EventArgs e)
		{
			if(x_wartosc.Text == "" || y_wartosc.Text == "")
			{
				MessageBox.Show("Uzupełnij warości pól X i Y");
				return;
			}
			
			try
			{
				wynik.Text = Convert.ToString((Double.Parse(x_wartosc.Text) + (Double.Parse(y_wartosc.Text))));
			}
			catch
			{
				MessageBox.Show("Błędne dane!");
				return;
			}
		}
		
		void OdejmijBtClick(object sender, EventArgs e)
		{
			if(x_wartosc.Text == "" || y_wartosc.Text == "")
			{
				MessageBox.Show("Uzupełnij warości pól X i Y");
				return;
			}
			
			try
			{
				wynik.Text = Convert.ToString((Double.Parse(x_wartosc.Text) - (Double.Parse(y_wartosc.Text))));
			}
			catch
			{
				MessageBox.Show("Błędne dane!");
				return;
			}
		}
		
		void PomnozBtClick(object sender, EventArgs e)
		{
			if(x_wartosc.Text == "" || y_wartosc.Text == "")
			{
				MessageBox.Show("Uzupełnij warości pól X i Y");
				return;
			}
			
			try
			{
				wynik.Text = Convert.ToString((Double.Parse(x_wartosc.Text) * (Double.Parse(y_wartosc.Text))));
			}
			catch
			{
				MessageBox.Show("Błędne dane!");
				return;
			}
		}
		
		void PodzielBtClick(object sender, EventArgs e)
		{
			if(x_wartosc.Text == "" || y_wartosc.Text == "")
			{
				MessageBox.Show("Uzupełnij warości pól X i Y");
				return;
			}
			
			try
			{
				wynik.Text = Convert.ToString((Double.Parse(x_wartosc.Text) / (Double.Parse(y_wartosc.Text))));
			}
			catch
			{
				MessageBox.Show("Błędne dane!");
				return;
			}	
		}
		
		
		void BruttoPlusClick(object sender, EventArgs e)
		{
			string wynikZm;
			
			if(y_wartosc.Text == "")
			{
				try
				{
					wynikZm = Convert.ToString(Double.Parse(x_wartosc.Text) * 0.23);
	           		wynik.Text = Convert.ToString(Double.Parse(x_wartosc.Text) + Double.Parse(wynikZm));
				}
				catch
				{
					MessageBox.Show("Błędne dane!");
					return;
				}	             
			}
			else
			{
				try
				{
					wynikZm = Convert.ToString(Double.Parse(x_wartosc.Text) * (Double.Parse(y_wartosc.Text) / 100));
	           		wynik.Text = Convert.ToString(Double.Parse(x_wartosc.Text) + Double.Parse(wynikZm));
				}
				catch
				{
					MessageBox.Show("Błędne dane!");
					return;
				}
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string wynikZm;
			
			if(y_wartosc.Text == "")
			{
				try
				{
					wynikZm = Convert.ToString(Double.Parse(x_wartosc.Text) * 0.23);
	           		wynik.Text = Convert.ToString(Double.Parse(x_wartosc.Text) - Double.Parse(wynikZm));
				}
				catch
				{
					MessageBox.Show("Błędne dane!");
					return;
				}	             
			}
			else
			{
				try
				{
					wynikZm = Convert.ToString(Double.Parse(x_wartosc.Text) * (Double.Parse(y_wartosc.Text) / 100));
	           		wynik.Text = Convert.ToString(Double.Parse(x_wartosc.Text) - Double.Parse(wynikZm));
				}
				catch
				{
					MessageBox.Show("Błędne dane!");
					return;
				}
			}
		}
	}
}