using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
	public partial class Form1 : Form
	{
		double n1 = 0;
		double n2 = 0;
		string operacao = "";
		public Form1()
		{
			InitializeComponent();
		}
		private void button20_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "0";
		}
		private void button15_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "1";
		}
		private void button14_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "2";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "3";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "4";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "5";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "6";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "7";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "8";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + "9";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			tb1.Text = null;
			label1.Text = null;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			tb1.Text = tb1.Text + ".";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			n1 = double.Parse(tb1.Text);
			tb1.Text = "";
			operacao = "somar";
			label1.Text = "+";
		}
		private void button11_Click(object sender, EventArgs e)
		{
			n2 = double.Parse(tb1.Text);
			if (operacao == "somar")
			{
				label1.Text = "";
				tb1.Text = Convert.ToString(n1 + n2);
			}
			else if (operacao == "subtrair")
			{
				label1.Text = "";
				tb1.Text = Convert.ToString(n1 - n2);
			}
			else if (operacao == "multiplicar")
			{
				label1.Text = "";
				tb1.Text = Convert.ToString(n1 * n2);
			}
			else if (operacao == "dividir")
			{
				if(n2 <= 0)
				{
					tb1.Text = "";
				}
				else
				{
					label1.Text = "";
					tb1.Text = Convert.ToString(n1 / n2);
				}
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			n1 = double.Parse(tb1.Text);
			tb1.Text = "";
			operacao = "subtrair";
			label1.Text = "-";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			n1 = double.Parse(tb1.Text);
			tb1.Text = "";
			operacao = "multiplicar";
			label1.Text = "*";
		}

		private void button17_Click(object sender, EventArgs e)
		{
			n1 = double.Parse(tb1.Text);
			tb1.Text = "";
			operacao = "dividir";
			label1.Text = "/";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tb1_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
