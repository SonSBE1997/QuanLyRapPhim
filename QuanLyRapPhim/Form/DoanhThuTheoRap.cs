using QuanLyRapPhim.BLL;
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
    public partial class DoanhThuTheoRap : Form
    {
        public DoanhThuTheoRap()
        {
            InitializeComponent();
        }

        private void DoanhThuTheoRap_Load(object sender, EventArgs e)
        {
            ReportBLL report = new ReportBLL();
            DataTable dt = report.GetDoanhThuTheoRap();

            // Data arrays.
            List<string> arrays = new List<string>();
            List<int> values = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                arrays.Add(dt.Rows[i]["tenrap"].ToString());
                values.Add(Int32.Parse(dt.Rows[i]["TongTien"].ToString()));
            }

            string[] seriesArray = arrays.ToArray();
            int[] pointsArray = values.ToArray();


            this.chart1.Titles.Add("Doanh thu của từng rạp");
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);
                this.chart1.Series[seriesArray[i]].SmartLabelStyle.Enabled = true;
                this.chart1.Series[seriesArray[i]].AxisLabel = "Rạp";
                this.chart1.Series[seriesArray[i]].Label = pointsArray[i].ToString();
                this.chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                // Add point.

                //this.chart1.Series[seriesArray[i]].Label = seriesArray[i];
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}
