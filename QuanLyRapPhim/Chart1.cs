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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            // Data arrays.
            string[] seriesArray = { "Quý 1", "Quý 2", "Quý 3", "Quý 4"};
            int[] pointsArray = { 11, 22, 10, 21};

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Doanh thu từng quý");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}
