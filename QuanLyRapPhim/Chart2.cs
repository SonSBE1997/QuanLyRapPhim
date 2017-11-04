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

namespace QuanLyRapPhim
{
    public partial class Chart2 : Form
    {
        public Chart2()
        {
            InitializeComponent();
        }

        private void Chart2_Load(object sender, EventArgs e)
        {
            this.chartControl.Series.Clear();

            this.chartControl.Titles.Add("Total Income");

            Series series = this.chartControl.Series.Add("Total Income");
            series.ChartType = SeriesChartType.Spline;
            series.Points.AddXY("September", 100);
            series.Points.AddXY("Obtober", 300);
            series.Points.AddXY("November", 800);
            series.Points.AddXY("December", 200);
            series.Points.AddXY("January", 600);
            series.Points.AddXY("February", 400);
        }
    }
}
