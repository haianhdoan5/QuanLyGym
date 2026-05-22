using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGym.BLL;
using QuanLyGym.Models;

namespace QuanLyGym.UserControls
{
    public partial class UCHopDong : UserControl
    {
        HopDongBLL hdBLL = new HopDongBLL();
        HoiVienBLL hvBLL = new HoiVienBLL();
        GoiTapGymBLL gtBLL = new GoiTapGymBLL();
        NhanVienBLL nvBLL = new NhanVienBLL();

        public UCHopDong()
        {
            InitializeComponent();
        }

        private void UCHopDong_Load(object sender, EventArgs e)
        {
            LoadDanhSachHopDong();
            LoadComboBoxes();
            CheckPermissions();
        }

        private void CheckPermissions()
        {
            // Nếu là hội viên, chỉ xem
            if (LuuThongTin.QuyenHan == "HoiVien")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLamMoi.Visible = false;
                txtMaHD.Visible = false;
                txtNoiDung.Visible = false;
                txtMaKM.Visible = false;
                cbHoiVien.Visible = false;
                cbGoiTap.Visible = false;
                cbNhanVien.Visible = false;
                dgvHopDong.ReadOnly = true;
                label1.Visible = false; 
                label2.Visible = false; 
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            // Nếu là nhân viên, vô hiệu hóa nút Sửa và Xóa
            else if (LuuThongTin.QuyenHan != null && 
                (LuuThongTin.QuyenHan.Contains("Nhân Viên") || 
                 LuuThongTin.QuyenHan.Contains("NhanVien") || 
                 LuuThongTin.QuyenHan.ToLower().Contains("staff")))
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
        }

        private void LoadComboBoxes()
        {
            // Đổ dữ liệu Hội Viên
            cbHoiVien.DataSource = hvBLL.GetAll();
            cbHoiVien.DisplayMember = "TenHV";
            cbHoiVien.ValueMember = "MaHV";

            // Đổ dữ liệu Gói Tập
            cbGoiTap.DataSource = gtBLL.GetAllGoiTap();
            cbGoiTap.DisplayMember = "TenGoi";
            cbGoiTap.ValueMember = "MaGoi";

            // Đổ dữ liệu Nhân Viên
            cbNhanVien.DataSource = nvBLL.GetNhanVien();
            cbNhanVien.DisplayMember = "TenNv";
            cbNhanVien.ValueMember = "MaNv";
        }

        private void LoadDanhSachHopDong()
        {
            // Đổ dữ liệu Hợp Đồng
            List<HopDong> list;

            if (LuuThongTin.QuyenHan == "HoiVien")
            {
                list = hdBLL.GetAll().Where(h => h.MaHv == LuuThongTin.MaHV).ToList();
            }
            else
            {
                list = hdBLL.GetAll();
            }

            dgvHopDong.DataSource = list;

            if (dgvHopDong.Columns.Contains("MaGoiNavigation"))
                dgvHopDong.Columns["MaGoiNavigation"].Visible = false;
            if (dgvHopDong.Columns.Contains("MaHvNavigation"))
                dgvHopDong.Columns["MaHvNavigation"].Visible = false;
            if (dgvHopDong.Columns.Contains("MaNvNavigation"))
                dgvHopDong.Columns["MaNvNavigation"].Visible = false;
            if (dgvHopDong.Columns.Contains("MaHoaDonNavigation"))
                dgvHopDong.Columns["MaHoaDonNavigation"].Visible = false;
            if (dgvHopDong.Columns.Contains("DoanhThu"))
                dgvHopDong.Columns["DoanhThu"].Visible = false;
            if (dgvHopDong.Columns.Contains("PhieuBaoLuu"))
                dgvHopDong.Columns["PhieuBaoLuu"].Visible = false;
            if (dgvHopDong.Columns.Contains("PhieuChuyenNhuong"))
                dgvHopDong.Columns["PhieuChuyenNhuong"].Visible = false;
        }
        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HopDong hd = new HopDong();
            hd.MaHd = txtMaHD.Text.Trim();
            hd.NoiDung = txtNoiDung.Text.Trim();
            hd.MaHv = cbHoiVien.SelectedValue?.ToString();
            hd.MaGoi = cbGoiTap.SelectedValue?.ToString();
            hd.MaNv = cbNhanVien.SelectedValue?.ToString();
            
            string ketQua = hdBLL.Update(hd);
            if (ketQua == "Success")
            {
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHopDong(); 
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtNoiDung.Clear();
            txtMaKM.Clear();
            cbHoiVien.SelectedIndex = -1;
            cbGoiTap.SelectedIndex = -1;
            txtMaHD.ReadOnly = false; 
            txtMaHD.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa từ danh sách!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string ketQua = hdBLL.Delete(txtMaHD.Text);
                if (ketQua == "Success")
                {
                    MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo");
                    LoadDanhSachHopDong();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbHoiVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hội viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHoiVien.Focus();
                return;
            }

            if (cbGoiTap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn gói tập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGoiTap.Focus();
                return;
            }

            HopDong hd = new HopDong();

            // Mã Hợp Đồng tự tăng
            string maHDMoi = hdBLL.GetNextMaHD();
            hd.MaHd = maHDMoi;

            // Các trường dữ liệu từ Giao diện
            hd.NoiDung = txtNoiDung.Text.Trim();
            hd.MaHv = cbHoiVien.SelectedValue?.ToString();
            hd.MaGoi = cbGoiTap.SelectedValue?.ToString();
            hd.MaNv = cbNhanVien.SelectedValue?.ToString();

            // Các trường hệ thống tự sinh
            hd.NgayLap = DateTime.Now;

            // Các trường chưa có trên Giao diện
            hd.MaHoaDon = null;

            // Gọi BLL thêm dữ liệu
            string ketQua = hdBLL.Insert(hd);
            if (ketQua == "Success")
            {
                MessageBox.Show($"Lập hợp đồng thành công!\nMã hợp đồng: {maHDMoi}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHopDong();
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi thêm mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhanVien.SelectedValue != null)
            {
                string maNv = cbNhanVien.SelectedValue.ToString();
            }
        }

        private void cbGoiTap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];

                txtMaHD.Text = row.Cells["MaHD"].Value?.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();

                if (dgvHopDong.Columns.Contains("MaKM"))
                {
                    txtMaKM.Text = row.Cells["MaKM"].Value?.ToString();
                }

                if (row.Cells["MaHV"].Value != null)
                    cbHoiVien.SelectedValue = row.Cells["MaHV"].Value.ToString();

                if (row.Cells["MaGoi"].Value != null)
                    cbGoiTap.SelectedValue = row.Cells["MaGoi"].Value.ToString();
                if (row.Cells["MaNV"].Value != null)
                    cbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();

                txtMaHD.ReadOnly = true;
            }
        }
    }
}
