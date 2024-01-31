using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Упражнение_1
{
	public partial class Form1 : Form
	{
		private Color shapeColor = Color.Green;
		public Form1()
		{
			InitializeComponent();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = shapeColor;

			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				shapeColor = colorDialog.Color;
			}

			Graphics g = this.CreateGraphics();
			Pen pn = new Pen(shapeColor, 4);
			Brush br = new SolidBrush(shapeColor);
			g.Clear(SystemColors.Control);

			switch (listBox1.SelectedIndex)
			{
				case 0: g.DrawLine(pn, 450, 50, 350, 180); break;
				case 1: g.DrawRectangle(pn, 350, 50, 200, 150); break;
				case 2: g.FillRectangle(br, 350, 50, 250, 250); break;
				case 3: g.DrawEllipse(pn, 350, 50, 250, 150); break;
				case 4: g.FillEllipse(br, 350, 50, 250, 150); break;
				case 5: g.DrawPie(pn, 300, 50, 300, 200, 180, 225); break;
				case 6: g.FillPie(br, 350, 50, 150, 150, 0, 45); break;
			}
		}

	}
}
