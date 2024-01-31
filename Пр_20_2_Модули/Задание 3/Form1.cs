using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
	public partial class Form1 : Form
	{

		private double XMin;
		private double XMax;
		private double Step;

		private double[] x;

		private double[] y1;
		private double[] y2;

		private void CalcFunction()
		{
			int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;

			x = new double[count];
			y1 = new double[count];
			y2 = new double[count];

			for (int i = 0; i < count; i++)
			{
				x[i] = XMin + Step * i;

				y1[i] = Math.Sin(x[i]);
				y2[i] = Math.Cos(x[i]);
			}
		}
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			XMin = double.Parse(textBox1.Text);
			XMax = double.Parse(textBox2.Text);
			Step = double.Parse(textBox3.Text);
			CalcFunction();

			chart1.Series[0].Points.DataBindXY(x, y1);
			chart1.Series[1].Points.DataBindXY(x, y2);
		}
	}
}
