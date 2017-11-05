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
        Common common = new Common();
        RapBLL rap = new RapBLL();
        PhongChieuBLL phongchieu = new PhongChieuBLL();
        GioChieuBLL giochieu = new GioChieuBLL();
        NuocSanXuatBLL nuocsanxuat = new NuocSanXuatBLL();
        HangSanXuatBLL hangsanxuat = new HangSanXuatBLL();
        TheLoaiBLL theloai = new TheLoaiBLL();
        PhimBLL phim = new PhimBLL();
        BuoiChieuBLL buoichieu = new BuoiChieuBLL();
        VeBLL ve = new VeBLL();
        #endregion

        #region BindingSource
        BindingSource sourceRap = new BindingSource();
        BindingSource sourcePhongChieu = new BindingSource();
        BindingSource sourceGioChieu = new BindingSource();
        BindingSource sourceNuocSanXuat = new BindingSource();
        BindingSource sourceHangSanXuat = new BindingSource();
        BindingSource sourceTheLoai = new BindingSource();
        BindingSource sourcePhim = new BindingSource();
        BindingSource sourceBuoiChieu = new BindingSource();
        BindingSource sourceVe = new BindingSource();
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

        #region Common
        private void Form1_Load(object sender, EventArgs e)
        {
            EventChangeTabControl1();
            CenterButtonClick();
            QuanLyRap();
            EventChangeTabControl2();
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

        void EventChangeTabControl2()
        {
            tabControl2.SelectedIndexChanged += (sender, e) => {
                int i = tabControl2.SelectedIndex;
                if (i < 0) return;
                if (i == 0) { QuanLyRap(); }
                if (i == 1) { QuanLyPhongChieu(); LoadCBPhongChieu(); }
                if (i == 2) { QuanLyGioChieu(); }
                if (i == 3) { QuanLyPhim(); LoadCbPhim(); }
                if (i == 4) { QuanLyNuocSanXuat(); }
                if (i == 5) { QuanLyHangSanXuat(); }
                if (i == 6) { QuanLyTheLoai(); }
                if (i == 7) { QuanLyBuoiChieu(); LoadCbLichChieu(); }
                if (i == 8) { QuanLyBanVe(); }
            };
        }

        void KeyPressEvent(KeyPressEventArgs e, string mess)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                MessageBox.Show(mess);
                e.Handled = true;
            }
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
        void LoadCBPhongChieu()
        {
            cbPCTenRap.DataSource = rap.LayDanhSachTenRap();
        }

        void LoadCbPhim()
        {
            cbPTheLoai.DataSource = theloai.LayDanhSachTenTheLoai();
            cbPHangSX.DataSource = hangsanxuat.LayDanhSachTenHangSX();
            cbPNuocSX.DataSource = nuocsanxuat.LayDanhSachTenNuocSX();
        }

        void LoadCbLichChieu()
        {
            cbLCPhim.DataSource = phim.LayDanhSachTenPhim();
            cbLCRap.DataSource = rap.LayDanhSachTenRap();
            cbLCGIoChieu.DataSource = giochieu.LayDanhSachMaGioChieu();
            cbLCPhongChieu.DataSource = phongchieu.LayDanhSachTenPhongChieuTheoTenRap(cbLCRap.SelectedItem.ToString());
            cbLCRap.SelectedIndexChanged += (s, e) => {
                cbLCPhongChieu.DataSource = phongchieu.LayDanhSachTenPhongChieuTheoTenRap(cbLCRap.SelectedItem.ToString());
            };
        }

        void DuyetComboBox(ComboBox c, string key)
        {
            foreach (string item in c.Items)
            {
                if (key == item)
                {
                    c.SelectedItem = item;
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
            ChonRap();
            dtgvRap.CellClick += (s, e) => { ChonRap(); };
            btnTaoRap.Click += (s, e) => { TaoRap(); };
            btnLuuRap.Click += (s, e) => { LuuRap(); };
            btnHuyRap.Click += (s, e) => { ChonRap(); };
            btnXoaRap.Click += (s, e) => { XoaRap(); };

            btnRFirst.Click += (s, e) => { common.First(dtgvRap); ChonRap(); };
            btnRPrevious.Click += (s, e) => { common.Previous(dtgvRap); ChonRap(); };
            btnRNext.Click += (s, e) => { common.Next(dtgvRap); ChonRap(); };
            btnRLast.Click += (s, e) => { common.Last(dtgvRap); ChonRap(); };

            txbTimKiemRap.TextChanged += (s, e) => { TimKiemRap(); };
        }

        void LoadDtgvRap()
        {
            sourceRap.DataSource = rap.LayDanhSachRapDataTable();
        }

        void TimKiemRap()
        {
            DataTable table = rap.LayDanhSachRapDataTable();
            sourceRap.DataSource = common.TimKiem(table, txbTimKiemRap.Text.Trim());
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

        void XoaRap()
        {
            string marap = dtgvRap.SelectedRows[0].Cells["Mã rạp"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa rạp có mã " + marap + " không?", "Xóa rạp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            txbPCSoGhe.KeyPress += (s, e) => { KeyPressEvent(e, "Bạn phải nhập số ghế là số"); };

            btnPCFirst.Click += (s, e) => { common.First(dtgvPhongChieu); ChonPhongChieu(); };
            btnPCPrevious.Click += (s, e) => { common.Previous(dtgvPhongChieu); ChonPhongChieu(); };
            btnPCNext.Click += (s, e) => { common.Next(dtgvPhongChieu); ChonPhongChieu(); };
            btnPCLast.Click += (s, e) => { common.Last(dtgvPhongChieu); ChonPhongChieu(); };
        }

        void LoadDtgvPhongChieu()
        {
            sourcePhongChieu.DataSource = phongchieu.LayDanhSachPhongChieu();
        }

        void ChonPhongChieu()
        {
            string tenrap = dtgvPhongChieu.SelectedRows[0].Cells["Tên rạp"].Value.ToString();
            DuyetComboBox(cbPCTenRap, tenrap);
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
            MessageBox.Show("Lưu phòng chiếu thành công!");
            LoadDtgvPhongChieu();
        }

        void XoaPhongChieu()
        {
            PhongChieuDAO ttPhongChieu = new PhongChieuDAO()
            {
                MaPhong = dtgvPhongChieu.SelectedRows[0].Cells["Mã phòng"].Value.ToString(),
                TenRap = dtgvPhongChieu.SelectedRows[0].Cells["Tên rạp"].Value.ToString()
            };
            if (MessageBox.Show("Bạn có chắc xóa phòng có mã " + ttPhongChieu.MaPhong + " không?", "Xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (phongchieu.XoaPhong(ttPhongChieu))
                {
                    MessageBox.Show("Xóa phòng thành công!");
                    LoadDtgvPhongChieu();
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
            txbGCDonGia.KeyPress += (s, e) => { KeyPressEvent(e, "Bạn phải nhập đơn giá là một số"); };

            btnGCFirst.Click += (s, e) => { common.First(dtgvGioChieu); ChonGioChieu(); };
            btnGCPrevious.Click += (s, e) => { common.Previous(dtgvGioChieu); ChonGioChieu(); };
            btnGCNext.Click += (s, e) => { common.Next(dtgvGioChieu); ChonGioChieu(); };
            btnGCLast.Click += (s, e) => { common.Last(dtgvGioChieu); ChonGioChieu(); };
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
            string magiochieu = dtgvGioChieu.SelectedRows[0].Cells["Mã giờ chiếu"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa giờ chiếu có mã " + magiochieu + " không?", "Xóa giờ chiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        void QuanLyNuocSanXuat()
        {
            dtgvNuocSanXuat.DataSource = sourceNuocSanXuat;
            LoadDtgvNuocSanXuat();
            ChonNuocSanXuat();
            dtgvNuocSanXuat.CellClick += (s, e) => { ChonNuocSanXuat(); };
            btnTaoNuocSanXuat.Click += (s, e) => { TaoNuocSanXuat(); };
            btnLuuNuocSanXuat.Click += (s, e) => { LuuNuocSanXuat(); };
            btnHuyNuocSanXuat.Click += (s, e) => { ChonNuocSanXuat(); };
            btnXoaNuocSanXuat.Click += (s, e) => { XoaNuocSanXuat(); };

            btnNFirst.Click += (s, e) => { common.First(dtgvNuocSanXuat); ChonNuocSanXuat(); };
            btnNPrevious.Click += (s, e) => { common.Previous(dtgvNuocSanXuat); ChonNuocSanXuat(); };
            btnNNext.Click += (s, e) => { common.Next(dtgvNuocSanXuat); ChonNuocSanXuat(); };
            btnNLast.Click += (s, e) => { common.Last(dtgvNuocSanXuat); ChonNuocSanXuat(); };
        }

        void LoadDtgvNuocSanXuat()
        {
            sourceNuocSanXuat.DataSource = nuocsanxuat.LayDanhSachNuocSanXuat();
        }

        void ChonNuocSanXuat()
        {
            txbNSXMaNuocSX.Text = dtgvNuocSanXuat.SelectedRows[0].Cells["Mã nước sản xuất"].Value.ToString();
            txbNSXTenNuocSX.Text = dtgvNuocSanXuat.SelectedRows[0].Cells["Tên nước sản xuất"].Value.ToString();
        }

        void TaoNuocSanXuat()
        {
            txbNSXMaNuocSX.Text = "";
            txbNSXMaNuocSX.Focus();
            txbNSXTenNuocSX.Text = "";
        }

        void LuuNuocSanXuat()
        {
            if (txbNSXMaNuocSX.Text == "") return;
            NuocSanXuatDAO ttnuocsx = new NuocSanXuatDAO()
            {
                MaNuoc = txbNSXMaNuocSX.Text,
                TenNuoc = txbNSXTenNuocSX.Text
            };
            if (nuocsanxuat.KiemTraNuocSanXuat(ttnuocsx.MaNuoc))
            {
                nuocsanxuat.SuaNuocSanXuat(ttnuocsx);
            }
            else nuocsanxuat.ThemNuocSanXuat(ttnuocsx);
            MessageBox.Show("Lưu nước sản xuất thành công!");
            LoadDtgvNuocSanXuat();
        }

        void XoaNuocSanXuat()
        {
            string manuocsx = dtgvNuocSanXuat.SelectedRows[0].Cells["Mã nước sản xuất"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa nước sản xuất có mã " + manuocsx + " không?", "Xóa nước sản xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nuocsanxuat.XoaNuocSanXuat(manuocsx))
                {
                    MessageBox.Show("Xóa nước sản xuất thành công!");
                    LoadDtgvNuocSanXuat();
                }
                else MessageBox.Show("Xóa nước sản xuất không thành công!");
            }
        }
        #endregion

        #region QuanLyHangSanXuat
        void QuanLyHangSanXuat()
        {
            dtgvHangSX.DataSource = sourceHangSanXuat;
            LoadDtgvHangSanXuat();
            ChonHangSanXuat();
            dtgvHangSX.CellClick += (s, e) => { ChonHangSanXuat(); };
            btnTaoHang.Click += (s, e) => { TaoHangSX(); };
            btnLuuHang.Click += (s, e) => { LuuHangSX(); };
            btnHuyHang.Click += (s, e) => { ChonHangSanXuat(); };
            btnXoaHang.Click += (s, e) => { XoaHangSX(); };

            btnHFirst.Click += (s, e) => { common.First(dtgvHangSX); ChonHangSanXuat(); };
            btnHPrevious.Click += (s, e) => { common.Previous(dtgvHangSX); ChonHangSanXuat(); };
            btnHNext.Click += (s, e) => { common.Next(dtgvHangSX); ChonHangSanXuat(); };
            btnHLast.Click += (s, e) => { common.Last(dtgvHangSX); ChonHangSanXuat(); };
        }

        void LoadDtgvHangSanXuat()
        {
            sourceHangSanXuat.DataSource = hangsanxuat.LayDanhSachHangSanXuat();
        }

        void ChonHangSanXuat()
        {
            txbHMaHang.Text = dtgvHangSX.SelectedRows[0].Cells["Mã hãng sản xuất"].Value.ToString();
            txbHTenHang.Text = dtgvHangSX.SelectedRows[0].Cells["Tên hãng sản xuất"].Value.ToString();
        }

        void TaoHangSX()
        {
            txbHMaHang.Text = "";
            txbHMaHang.Focus();
            txbHTenHang.Text = "";
        }

        void LuuHangSX()
        {
            if (txbHMaHang.Text == "") return;
            HangSXDAO tthangsx = new HangSXDAO()
            {
                MaHang = txbHMaHang.Text,
                TenHang = txbHTenHang.Text
            };
            if (hangsanxuat.KiemTraHangSanXuat(tthangsx.MaHang))
            {
                hangsanxuat.SuaHangSanXuat(tthangsx);
            }
            else hangsanxuat.ThemHangSanXuat(tthangsx);
            MessageBox.Show("Lưu hãng sản xuất thành công!");
            LoadDtgvHangSanXuat();
        }

        void XoaHangSX()
        {
            string mahangsx = txbHMaHang.Text = dtgvHangSX.SelectedRows[0].Cells["Mã hãng sản xuất"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa hãng sản xuất có mã " + mahangsx + " không?", "Xóa hãng sản xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (hangsanxuat.XoaHangSanXuat(mahangsx))
                {
                    MessageBox.Show("Xóa hãng sản xuất thành công!");
                    LoadDtgvHangSanXuat();
                }
                else MessageBox.Show("Xóa hãng sản xuất không thành công!");
            }
        }
        #endregion

        #region QuanLyTheLoai
        void QuanLyTheLoai()
        {
            dtgvTheLoai.DataSource = sourceTheLoai;
            LoadDtgvTheLoai();
            ChonTheLoai();
            dtgvTheLoai.CellClick += (s, e) => { ChonTheLoai(); };
            btnTaoTheLoai.Click += (s, e) => { TaoTheLoai(); };
            btnHuyTheLoai.Click += (s, e) => { ChonTheLoai(); };
            btnLuuTheLoai.Click += (s, e) => { LuuTheLoai(); };
            btnXoaTheLoai.Click += (s, e) => { XoaTheLoai(); };

            btnTLFirst.Click += (s, e) => { common.First(dtgvTheLoai); ChonTheLoai(); };
            btnTLPrevious.Click += (s, e) => { common.Previous(dtgvTheLoai); ChonTheLoai(); };
            btnTLNext.Click += (s, e) => { common.Next(dtgvTheLoai); ChonTheLoai(); };
            btnTLLast.Click += (s, e) => { common.Last(dtgvTheLoai); ChonTheLoai(); };
        }

        void LoadDtgvTheLoai()
        {
            sourceTheLoai.DataSource = theloai.LayDanhSachTheLoai();
        }

        void ChonTheLoai()
        {
            txbTLMaTheLoai.Text = dtgvTheLoai.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();
            txbTLTenTheLoai.Text = dtgvTheLoai.SelectedRows[0].Cells["Tên thể loại"].Value.ToString();
        }

        void TaoTheLoai()
        {
            txbTLMaTheLoai.Text = "";
            txbTLMaTheLoai.Focus();
            txbTLTenTheLoai.Text = "";
        }

        void LuuTheLoai()
        {
            if (txbTLMaTheLoai.Text == "") return;
            TheLoaiDAO tttheloai = new TheLoaiDAO()
            {
                MaTheLoai = txbTLMaTheLoai.Text,
                TenTheLoai = txbTLTenTheLoai.Text
            };
            if (theloai.KiemTraTheLoai(tttheloai.MaTheLoai))
            {
                theloai.SuaTheLoai(tttheloai);
            }
            else theloai.ThemTheLoai(tttheloai);
            MessageBox.Show("Lưu thể loại thành công!");
            LoadDtgvTheLoai();
        }

        void XoaTheLoai()
        {
            string matheloai = dtgvTheLoai.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa hãng sản xuất có mã " + matheloai + " không?", "Xóa thể loại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (theloai.XoaTheLoai(matheloai))
                {
                    MessageBox.Show("Xóa thể loại thành công!");
                    LoadDtgvTheLoai();
                }
                else MessageBox.Show("Xóa thể loại không thành công!");
            }
        }
        #endregion

        #region QuanLyPhim
        void QuanLyPhim()
        {
            dtgvPhim.DataSource = sourcePhim;
            LoadDtgvPhim();
            ChonPhim();
            dtgvPhim.CellClick += (s, e) => { ChonPhim(); };

            btnTaoPhim.Click += (s, e) => { TaoPhim(); };
            btnHuyPhim.Click += (s, e) => { ChonPhim(); };
            btnLuuPhim.Click += (s, e) => { LuuPhim(); };
            btnXoaPhim.Click += (s, e) => { XoaPhim(); };

            btnPFirst.Click += (s, e) => { common.First(dtgvPhim); ChonPhim(); };
            btnPPrevious.Click += (s, e) => { common.Previous(dtgvPhim); ChonPhim(); };
            btnPNext.Click += (s, e) => { common.Next(dtgvPhim); ChonPhim(); };
            btnPLast.Click += (s, e) => { common.Last(dtgvPhim); ChonPhim(); };

            txbPTongChiPhi.KeyPress += (s, e) => { KeyPressEvent(e, "Bạn phải nhập chi phí là một số"); };
        }

        void LoadDtgvPhim()
        {
            sourcePhim.DataSource = phim.LayDanhSachPhim();
        }

        void ChonPhim()
        {
            txbPMaPhim.Text = dtgvPhim.SelectedRows[0].Cells[0].Value.ToString();
            txbPTenPhim.Text = dtgvPhim.SelectedRows[0].Cells[1].Value.ToString();
            DuyetComboBox(cbPNuocSX, dtgvPhim.SelectedRows[0].Cells[2].Value.ToString());
            DuyetComboBox(cbPHangSX, dtgvPhim.SelectedRows[0].Cells[3].Value.ToString());
            txbPDaoDien.Text = dtgvPhim.SelectedRows[0].Cells[4].Value.ToString();
            DuyetComboBox(cbPTheLoai, dtgvPhim.SelectedRows[0].Cells[5].Value.ToString());
            dtpPNgayBatDau.Value = DateTime.Parse(dtgvPhim.SelectedRows[0].Cells[6].Value.ToString());
            dtpPNgayKetThuc.Value = DateTime.Parse(dtgvPhim.SelectedRows[0].Cells[7].Value.ToString());
            txbPNuChinh.Text = dtgvPhim.SelectedRows[0].Cells[8].Value.ToString();
            txbPNamChinh.Text = dtgvPhim.SelectedRows[0].Cells[9].Value.ToString();


            rtxbNoiDungChinh.Text = dtgvPhim.SelectedRows[0].Cells[10].Value.ToString();
            txbPTongChiPhi.Text = dtgvPhim.SelectedRows[0].Cells[11].Value.ToString();
            txbPTongThu.Text = dtgvPhim.SelectedRows[0].Cells[12].Value.ToString();
        }

        void TaoPhim()
        {
            txbPMaPhim.Text = "";
            txbPMaPhim.Focus();
            txbPTenPhim.Text = "";
            txbPDaoDien.Text = "";
            txbPNamChinh.Text = "";
            txbPNuChinh.Text = "";
            txbPTongChiPhi.Text = "";
            txbPTongThu.Text = "0";
        }

        void LuuPhim()
        {
            if (txbPMaPhim.Text == "") return;
            PhimDAO ttphim = new PhimDAO()
            {
                MaPhim = txbPMaPhim.Text,
                TenPhim = txbPTenPhim.Text,
                NuocSX = cbPNuocSX.SelectedItem.ToString(),
                HangSX = cbPHangSX.SelectedItem.ToString(),
                DaoDien = txbPDaoDien.Text,
                TheLoai = cbPTheLoai.SelectedItem.ToString(),
                NgayKhoiChieu = dtpPNgayBatDau.Value,
                NgayKetThuc = dtpPNgayKetThuc.Value,
                NamDVChinh = txbPNamChinh.Text,
                NuDVChinh = txbPNuChinh.Text,
                NoiDungChinh = rtxbNoiDungChinh.Text,
                TongChiPhi = long.Parse(txbPTongChiPhi.Text)
            };

            if (phim.KiemTraPhim(ttphim.MaPhim))
            {
                bool kt = phim.SuaPhim(ttphim);
            }
            else phim.ThemPhim(ttphim);
            LoadDtgvPhim();
            MessageBox.Show("Lưu phim thành công!");
        }

        void XoaPhim()
        {
            string maphim = dtgvPhim.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa phim có mã " + maphim + " không?", "Xóa phim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (phim.XoaPhim(maphim))
                {
                    MessageBox.Show("Xóa phim thành công!");
                    LoadDtgvPhim();
                }
                else MessageBox.Show("Xóa phim không thành công!");
            }
        }
        #endregion

        #region QuanLyBuoiChieu
        void QuanLyBuoiChieu()
        {
            dtgvLichChieu.DataSource = sourceBuoiChieu;
            LoadDtgvBuoiChieu();
            ChonBuoiChieu();
            dtgvLichChieu.CellClick += (s, e) => { ChonBuoiChieu(); };

            btnThemLichChieu.Click += (s, e) => { TaoBuoiChieu(); };
            btnHuyLichChieu.Click += (s, e) => { ChonBuoiChieu(); };
            btnLuuLichChieu.Click += (s, e) => { LuuBuoiChieu(); };
            btnXoaLichChieu.Click += (s, e) => { XoaBuoiChieu(); };

            btnLCFirst.Click += (s, e) => { common.First(dtgvLichChieu); ChonBuoiChieu(); };
            btnLCPrevious.Click += (s, e) => { common.Previous(dtgvLichChieu); ChonBuoiChieu(); };
            btnLCNext.Click += (s, e) => { common.Next(dtgvLichChieu); ChonBuoiChieu(); };
            btnLCLast.Click += (s, e) => { common.Last(dtgvLichChieu); ChonBuoiChieu(); };
        }

        void LoadDtgvBuoiChieu()
        {
            sourceBuoiChieu.DataSource = buoichieu.LayDanhSachBuoiChieu();
        }

        void ChonBuoiChieu()
        {
            txbLCMaShow.Text = dtgvLichChieu.SelectedRows[0].Cells[0].Value.ToString();
            DuyetComboBox(cbLCPhim, dtgvLichChieu.SelectedRows[0].Cells[1].Value.ToString());
            DuyetComboBox(cbLCRap, dtgvLichChieu.SelectedRows[0].Cells[2].Value.ToString());
            DuyetComboBox(cbLCPhongChieu, dtgvLichChieu.SelectedRows[0].Cells[3].Value.ToString());
            dtpLCNgayChieu.Value = DateTime.Parse(dtgvLichChieu.SelectedRows[0].Cells[4].Value.ToString());
            DuyetComboBox(cbLCGIoChieu, dtgvLichChieu.SelectedRows[0].Cells[5].Value.ToString());
            txbLCSoVeDaBan.Text = dtgvLichChieu.SelectedRows[0].Cells[6].Value.ToString();
            txbLCTongTien.Text = dtgvLichChieu.SelectedRows[0].Cells[7].Value.ToString();
        }

        void TaoBuoiChieu()
        {
            txbLCMaShow.Text = "";
            txbLCMaShow.Focus();
            txbLCSoVeDaBan.Text = "0";
            txbLCTongTien.Text = "0";
        }

        void LuuBuoiChieu()
        {
            if (txbLCMaShow.Text == "") return;
            BuoiChieuDAO ttshow = new BuoiChieuDAO()
            {
                MaShow = txbLCMaShow.Text,
                TenPhim = cbLCPhim.SelectedItem.ToString(),
                TenPhong = cbLCPhongChieu.SelectedItem.ToString(),
                TenRap = cbLCRap.SelectedItem.ToString(),
                GioChieu = cbLCGIoChieu.SelectedItem.ToString(),
                NgayChieu = dtpLCNgayChieu.Value
            };

            if (buoichieu.KiemTraBuoiChieu(ttshow.MaShow))
            {
                buoichieu.SuaBuoiChieu(ttshow);
            }
            else buoichieu.ThemBuoiChieu(ttshow);
            MessageBox.Show("Lưu thông tin buổi chiếu thành công!");
            LoadDtgvBuoiChieu();
        }

        void XoaBuoiChieu()
        {
            string mashow = dtgvLichChieu.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc xóa buổi chiếu có mã " + mashow + " không?", "Xóa buổi chiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (buoichieu.XoaBuoiChieu(mashow))
                {
                    MessageBox.Show("Xóa buổi chiếu thành công!");
                    LoadDtgvBuoiChieu();
                }
                else MessageBox.Show("Xóa buổi chiếu không thành công!");
            }
        }
        #endregion

        #region QuanLyBanVe
        void QuanLyBanVe()
        {
            dtgvVe.DataSource = sourceVe;
            LoadDtgvVe();
            ChonVe();

            dtgvVe.CellClick += (s, e) => { ChonVe(); };
            btnTaoVe.Click += (s, e) => { ThemVe(); };
            btnHuyVe.Click += (s, e) => { ChonVe(); };
            btnXoaVe.Click += (s, e) => { XoaVe(); };
            btnLuuVe.Click += (s, e) => { LuuVe(); };

            btnVFirst.Click += (s, e) => { common.First(dtgvVe); ChonVe(); };
            btnVPrevious.Click += (s, e) => { common.Previous(dtgvVe); ChonVe(); };
            btnVNext.Click += (s, e) => { common.Next(dtgvVe); ChonVe(); };
            btnVLast.Click += (s, e) => { common.Last(dtgvVe); ChonVe(); };
        }

        void LoadDtgvVe()
        {
            //sourceVe.DataSource = 
        }

        void ChonVe()
        {

        }

        void ThemVe()
        {

        }

        void LuuVe()
        {

        }

        void XoaVe()
        {

        }
        #endregion
    }
}
