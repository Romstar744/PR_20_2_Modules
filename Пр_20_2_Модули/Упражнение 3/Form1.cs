using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Упражнение_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			string[] subjects = { "ОАиП", "ТРПП", "Мат. метод", "Граф. Диз", "ОБЖ"};
			double[] marks = { 3.5, 3.8, 3.8, 3.1, 2.5};

			chart1.Palette = ChartColorPalette.SeaGreen;

			for (int i = 0; i < subjects.Length; i++)
			{
				Series series = chart1.Series.Add(subjects[i]);

				series.Points.Add(marks[i]);

				series.ChartType = SeriesChartType.RangeColumn;

				series["PointWidth"] = "1";
			}
		}
	}
}
