using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace convertidor2
{
	public partial class MainForm : Form
	{
		double pesos;
		double dolares;
		double tipcamb;
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(double.TryParse(textBox1.Text, out pesos) && double.TryParse(textBox3.Text, out tipcamb)
					&& pesos!=0 && tipcamb!=0){

					dolares = pesos/tipcamb;

					textBox2.Text = dolares.ToString();
		}

			else{
			MessageBox.Show("¡Error!!!!!!!! no llenaste los espacios\no ingresaste una letra");
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
	}
}