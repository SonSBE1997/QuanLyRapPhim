using QuanLyRapPhim.BLL;
using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class Form1 : Form
    {
        #region BLL
        RapBLL rap = new RapBLL();
        PhongChieuBLL phongchieu = new PhongChieuBLL();
        GioChieuBLL giochieu = new GioChieuBLL();
        #endregion

        #region BindingSource
        BindingSource sourceRap = new BindingSource();
        BindingSource sourcePhongChieu = new BindingSource();
        BindingSource sourceGioChieu = new BindingSource();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Chart
        private void button11_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Chart2 chart = new Chart2();
            chart.Show();
        }
        #endregion

        #region Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            EventChangeTabControl1();
            CenterButtonClick();
            LoadComboBox();
            QuanLyRap();
            QuanLyPhongChieu();
            QuanLyGioChieu();
        }

        void EventChangeTabControl1()
        {
            btnMain.Click += btnMain_Click;
            btnQuanLi.Click += btnQuanLi_Click;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            btnGioiThieu.Click += btnGioiThieu_Click;
            btnThoat.Click += btnGioiThieu_Click;
            tabControl1.SelectedIndexChanged += (sender, e) => {
                int i = tabControl1.SelectedIndex;
                if (i < 0) return;
                if (i == 0) ClickBtnMain();
                if (i == 1) ClickBtnQuanLi();
                if (i == 2) ClickBtnBaoCaoThongKe();
                if (i == 3) ClickBtnGioiThieu();
            };
        }

        void CenterButtonClick()
        {
            btnMRap.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 0;
            };

            btnMPhongChieu.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 1;
            };

            btnMGioChieu.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 2;
            };

            btnMPhim.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 3;
            };

            btnMNuocSX.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 4;
            };

            btnMHangSX.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 5;
            };

            btnMTheLoaiPhim.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 6;
            };

            btnMLichChieu.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 7;
            };

            btnMBanVe.Click += (sender, e) => {
                tabControl1.SelectedIndex = 1;
                tabControl2.SelectedIndex = 8;
            };
            btnMXemBaoCao.Click += (sender, e) => {
                tabControl1.SelectedIndex = 2;
            };
        }

        #endregion

        #region Left_Button

        private void btnMain_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            ClickBtnMain();
        }

        void ClickBtnMain()
        {
            btnMain.BackColor = Color.FromArgb(0, 116, 162);
            btnQuanLi.BackColor = Color.FromArgb(34, 34, 34);
            btnBaoCaoThongKe.BackColor = Color.FromArgb(34, 34, 34);
            btnGioiThieu.BackColor = Color.FromArgb(34, 34, 34);
        }

        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            ClickBtnQuanLi();
        }

        void ClickBtnQuanLi()
        {
            btnQuanLi.BackColor = Color.FromArgb(0, 116, 162);
            btnMain.BackColor = Color.FromArgb(34, 34, 34);
            btnBaoCaoThongKe.BackColor = Color.FromArgb(34, 34, 34);
            btnGioiThieu.BackColor = Color.FromArgb(34, 34, 34);
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            ClickBtnBaoCaoThongKe();
        }

        void ClickBtnBaoCaoThongKe()
        {
            btnBaoCaoThongKe.BackColor = Color.FromArgb(0, 116, 162);
            btnMain.BackColor = Color.FromArgb(34, 34, 34);
            btnQuanLi.BackColor = Color.FromArgb(34, 34, 34);
            btnGioiThieu.BackColor = Color.FromArgb(34, 34, 34);
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            ClickBtnGioiThieu();
        }

        void ClickBtnGioiThieu()
        {
            btnGioiThieu.BackColor = Color.FromArgb(0, 116, 162);
            btnMain.BackColor = Color.FromArgb(34, 34, 34);
            btnBaoCaoThongKe.BackColor = Color.FromArgb(34, 34, 34);
            btnQuanLi.BackColor = Color.FromArgb(34, 34, 34);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        #endregion

        #region Load ComboBox
        void LoadComboBox()
        {
            LoadCbRap();
        }

        void LoadCbRap()
        {
            cbPCTenRap.DataSource = rap.LayDanhSachTenRap();
        }

        void DuyetCBRap(string key)
        {
            foreach (string item in cbPCTenRap.Items)
            {
                if (key == item)
                {
                    cbPCTenRap.SelectedItem = item;
                    return;
                }
            }
        }
        #endregion

        #region QuanLiRap
        void QuanLyRap()
        {

            dtgvRap.DataSource = sourceRap;
            LoadDtgvRap();
            dtgvRap.CellClick += (s, e) => { ChonRap(); };
            //RapDataBinding();
            ChonRap();
            btnTaoRap.Click += (s, e) => { TaoRap(); };
            btnLuuRap.Click += (s, e) => { LuuRap(); };
            btnHuyRap.Click += (s, e) => { ChonRap(); };
            btnXoaRap.Click += (s, e) => { XoaRap(); };
        }

        void LoadDtgvRap()
        {
            sourceRap.DataSource = rap.LayDanhSachRapDataTable();
        }

        void RapDataBinding()
        {
            txbRMaRap.DataBindings.Add(new Binding("text", dtgvRap.DataSource, "Mã rạp", true, DataSourceUpdateMode.Never));
            txbRTenRap.DataBindings.Add(new Binding("text", dtgvRap.DataSource, "Tên rạp", true, DataSourceUpdateMode.Never));
            txbRDiaChi.DataBindings.Add(new Binding("text", dtgvRap.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));

            txbRDienThoai.DataBindings.Add(new Binding("text", dtgvRap.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            txbRSoPhong.DataBindings.Add(new Binding("text", dtgvRap.DataSource, "Số phòng", true, DataSourceUpdateMode.Never));
            txbRTongSoGhe.DataBindings.Add(new Binding("text", dtgvRap.DataSource, "Tổng số ghế", true, DataSourceUpdateMode.Never));
        }

        void TaoRap()
        {
            txbRMaRap.Text = "";
            txbRMaRap.Focus();
            txbRTenRap.Text = "";
            txbRDiaChi.Text = "";
            txbRDienThoai.Text = "";
            txbRSoPhong.Text = "0";
            txbRTongSoGhe.Text = "0";
        }

        void LuuRap()
        {
            if (txbRMaRap.Text == "") return;
            RapDAO ttRap = new RapDAO()
            {
                MaRap = txbRMaRap.Text,
                TenRap = txbRTenRap.Text,
                DiaChi = txbRDiaChi.Text,
                DienThoai = txbRDienThoai.Text
            };

            if (rap.KiemTraRap(ttRap.MaRap))
            {
                rap.SuaRap(ttRap);
            }
            else rap.ThemRap(ttRap);
            MessageBox.Show("Lưu rạp thành công!");
            LoadDtgvRap();
        }

        void ChonRap()
        {
            txbRMaRap.Text = dtgvRap.SelectedRows[0].Cells["Mã rạp"].Value.ToString();
            txbRTenRap.Text = dtgvRap.SelectedRows[0].Cells["Tên rạp"].Value.ToString();
            txbRDiaChi.Text = dtgvRap.SelectedRows[0].Cells["Địa chỉ"].Value.ToString();
            txbRDienThoai.Text = dtgvRap.SelectedRows[0].Cells["Số điện thoại"].Value.ToString();
            txbRSoPhong.Text = dtgvRap.SelectedRows[0].Cells["Số phòng"].Value.ToString();
            txbRTongSoGhe.Text = dtgvRap.SelectedRows[0].Cells["Tổng số ghế"].Value.ToString();
        }

        void XoaRap()
        {
            string marap = txbRMaRap.Text;
            if (MessageBox.Show("Bạn có chắc xóa rạp có mã " + marap + "không?", "Xóa rạp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rap.XoaRap(marap))
                {
                    MessageBox.Show("Xóa rạp thành công!");
                    LoadDtgvRap();
                }
                else MessageBox.Show("Xóa rạp không thành công!");
            }
        }
        #endregion

        #region QuanLyPhongChieu
        void QuanLyPhongChieu()
        {
            dtgvPhongChieu.DataSource = sourcePhongChieu;
            LoadDtgvPhongChieu();
            ChonPhongChieu();
            dtgvPhongChieu.CellClick += (s, e) => { ChonPhongChieu(); };
            btnTaoPhongChieu.Click += (s, e) => { TaoPhongChieu(); };
            btnHuyPhongChieu.Click += (s, e) => { ChonPhongChieu(); };
            btnLuuPhongChieu.Click += (s, e) => { LuuPhongChieu(); };
            btnXoaPhongChieu.Click += (s, e) => { XoaPhongChieu(); };
        }

        void LoadDtgvPhongChieu()
        {
            sourcePhongChieu.DataSource = phongchieu.LayDanhSachPhongChieu();
        }

        void ChonPhongChieu()
        {
            string tenrap = dtgvPhongChieu.SelectedRows[0].Cells["Tên rạp"].Value.ToString();
            DuyetCBRap(tenrap);
            txbPCMaPhong.Text = dtgvPhongChieu.SelectedRows[0].Cells["Mã phòng"].Value.ToString();
            txbPCTenPhong.Text = dtgvPhongChieu.SelectedRows[0].Cells["Tên phòng"].Value.ToString();
            txbPCSoGhe.Text = dtgvPhongChieu.SelectedRows[0].Cells["Số ghế"].Value.ToString();
        }

        void TaoPhongChieu()
        {
            cbPCTenRap.SelectedIndex = 0;
            txbPCMaPhong.Text = "";
            txbPCMaPhong.Focus();
            txbPCTenPhong.Text = "";
            txbPCSoGhe.Text = "";
        }

        void LuuPhongChieu()
        {
            if (txbPCMaPhong.Text == "") return;
            PhongChieuDAO ttphongchieu = new PhongChieuDAO()
            {
                TenRap = cbPCTenRap.SelectedItem.ToString(),
                MaPhong = txbPCMaPhong.Text,
                TenPhong = txbPCTenPhong.Text,
                SoGhe = Int32.Parse(txbPCSoGhe.Text)
            };

            if (phongchieu.KiemTraPhongChieu(ttphongchieu.MaPhong))
            {
                int soghecu = phongchieu.LaySoGheCuaPhongTheoMaPhong(ttphongchieu.MaPhong);
                phongchieu.SuaPhongChieu(ttphongchieu, soghecu);
            }
            else
            {
                phongchieu.ThemPhong(ttphongchieu);
            }
            MessageBox.Show("Lưu phòng chiéu thành công!");
            LoadDtgvPhongChieu();
            LoadDtgvRap();
        }

        void XoaPhongChieu()
        {
            PhongChieuDAO ttPhongChieu = new PhongChieuDAO()
            {
                MaPhong = txbPCMaPhong.Text,
                TenRap = cbPCTenRap.SelectedItem.ToString()
            };
            if (MessageBox.Show("Bạn có chắc xóa phòng có mã " + ttPhongChieu.MaPhong + "không?", "Xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (phongchieu.XoaPhong(ttPhongChieu))
                {
                    MessageBox.Show("Xóa phòng thành công!");
                    LoadDtgvPhongChieu();
                    LoadDtgvRap();
                }
                else MessageBox.Show("Xóa phòng không thành công!");
            }

        }

        #endregion

        #region QuanLyGioChieu
        void QuanLyGioChieu()
        {
            dtgvGioChieu.DataSource = sourceGioChieu;
            LoadDtgvGioChieu();
            ChonGioChieu();
            dtgvGioChieu.CellClick += (s, e) => { ChonGioChieu(); };
            btnTaoGioChieu.Click += (s, e) => { TaoGioChieu(); };
            btnHuyGioChieu.Click += (s, e) => { ChonGioChieu(); };
            btnLuuGioChieu.Click += (s, e) => { LuuGioChieu(); };
            btnXoaGioChieu.Click += (s, e) => { XoaGioChieu(); };
        }

        void LoadDtgvGioChieu()
        {
            sourceGioChieu.DataSource = giochieu.LayDanhSachGioChieu();
        }

        void ChonGioChieu()
        {
            txbGCMaGioChieu.Text = dtgvGioChieu.SelectedRows[0].Cells["Mã giờ chiếu"].Value.ToString();
            txbGCDonGia.Text = dtgvGioChieu.SelectedRows[0].Cells["Đơn giá"].Value.ToString();
        }

        void TaoGioChieu()
        {
            txbGCMaGioChieu.Text = "";
            txbGCMaGioChieu.Focus();
            txbGCDonGia.Text = "";
        }

        void LuuGioChieu()
        {
            if (txbGCMaGioChieu.Text == "") return;
            GioChieuDAO ttgiochieu = new GioChieuDAO()
            {
                MaGioChieu = txbGCMaGioChieu.Text,
                DonGia = Int32.Parse(txbGCDonGia.Text)
            };
            if (giochieu.KiemTraGioChieu(ttgiochieu.MaGioChieu))
            {
                giochieu.SuaGioChieu(ttgiochieu);
            }
            else giochieu.ThemGioChieu(ttgiochieu);
            MessageBox.Show("Lưu giờ chiếu thành công!");
            LoadDtgvGioChieu();
        }

        void XoaGioChieu()
        {
            string magiochieu = txbGCMaGioChieu.Text;
            if (MessageBox.Show("Bạn có chắc xóa giờ chiếu có mã " + magiochieu + "không?", "Xóa giờ chiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (giochieu.XoaGioChieu(magiochieu))
                {
                    MessageBox.Show("Xóa giờ chiếu thành công!");
                    LoadDtgvGioChieu();
                }
                else MessageBox.Show("Xóa giờ chiếu không thành công!");
            }
        }
        #endregion

        #region QuanLyNuocSanXuat

        #endregion
    }
}
