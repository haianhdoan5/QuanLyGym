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
    public partial class UCHoiVien : UserControl
    {
        private HoiVienBLL bll = new HoiVienBLL();
        private bool isEditing = false;

        public UCHoiVien()
        {
            InitializeComponent();
        }

        private void UCHoiVien_Load(object sender, EventArgs e)
        {
            CheckPermissions();
            LoadData();
        }

        private void CheckPermissions()
        {
            // Nếu là hội viên, ẩn tất cả chức năng
            if (LuuThongTin.QuyenHan == "Hội Viên")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLamMoi.Visible = false;
                pnlForm.Visible = false;
                dgvHoiVien.ReadOnly = true;
            }
            // Nếu là PT, chỉ cho xem
            else if (LuuThongTin.QuyenHan == "PT")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLamMoi.Visible = false;
                pnlForm.Visible = false;
                dgvHoiVien.ReadOnly = true;
            }
            // Nếu là nhân viên, vô hiệu hóa nút Sửa và Xóa
            else if (LuuThongTin.QuyenHan == "NhanVien")
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            // Nếu là Admin, hiển thị tất cả nút
            else if (LuuThongTin.QuyenHan == "Admin")
            {
                btnThem.Visible = true;
                btnSua.Visible = true;
                btnXoa.Visible = true;
                btnLamMoi.Visible = true;
                pnlForm.Visible = true;
                dgvHoiVien.ReadOnly = false;
            }
        }

        private void LoadData()
        {
            try
            {
                List<HoiVien> list = bll.GetAll();
                dgvHoiVien.DataSource = list;

                // Format columns
                if (dgvHoiVien.Columns.Count > 0)
                {
                    dgvHoiVien.Columns["MaHv"].HeaderText = "Mã Hội Viên";
                    dgvHoiVien.Columns["TenHv"].HeaderText = "Tên Hội Viên";
                    dgvHoiVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    dgvHoiVien.Columns["Sdt"].HeaderText = "Số Điện Thoại";

                    // Hide navigation properties
                    dgvHoiVien.Columns["ChamSocHoiVien"].Visible = false;
                    dgvHoiVien.Columns["ChiSoInbody"].Visible = false;
                    dgvHoiVien.Columns["HopDong"].Visible = false;
                    dgvHoiVien.Columns["LichTapLuyen"].Visible = false;
                    dgvHoiVien.Columns["PhieuChuyenNhuongMaHv1Navigation"].Visible = false;
                    dgvHoiVien.Columns["PhieuChuyenNhuongMaHv2Navigation"].Visible = false;

                    if (dgvHoiVien.Columns.Contains("TaiKhoan"))
                        dgvHoiVien.Columns["TaiKhoan"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hội viên");
                return;
            }

            if (cbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }

            try
            {
                // 1. Tự động sinh mã HV
                string maHVMoi = bll.GetNextMaHV();

                HoiVien hv = new HoiVien
                {
                    MaHv = maHVMoi,
                    TenHv = txtTenHV.Text,
                    GioiTinh = cbGioiTinh.SelectedItem.ToString(),
                    Sdt = txtSDT.Text
                };

                if (bll.Insert(hv))
                {
                    // 2. Tự động tạo Tài khoản đăng nhập cho Hội viên
                    TaiKhoan tkMoi = new TaiKhoan
                    {
                        TenDangNhap = maHVMoi,
                        MatKhau = "1",
                        QuyenHan = "Hội Viên", // Cứng quyền hội viên
                        TrangThai = true,
                        MaNv = null,
                        MaHv = maHVMoi
                    };

                    using (var db = new GymDbContext()) { db.TaiKhoan.Add(tkMoi); db.SaveChanges(); }

                    MessageBox.Show($"Thêm thành công!\nTài khoản: {maHVMoi}\nMật khẩu: 1", "Tạo tự động");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm hội viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHV.Text))
            {
                MessageBox.Show("Vui lòng chọn hội viên để sửa");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenHV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hội viên");
                return;
            }

            if (cbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }

            try
            {
                HoiVien hv = new HoiVien
                {
                    MaHv = txtMaHV.Text,
                    TenHv = txtTenHV.Text,
                    GioiTinh = cbGioiTinh.SelectedItem.ToString(),
                    Sdt = txtSDT.Text
                };

                if (bll.Update(hv))
                {
                    MessageBox.Show("Cập nhật hội viên thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật hội viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHV.Text))
            {
                MessageBox.Show("Vui lòng chọn hội viên để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hội viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (bll.Delete(txtMaHV.Text))
                    {
                        MessageBox.Show("Xóa hội viên thành công!");
                        ClearForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hội viên thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvHoiVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoiVien.Rows[e.RowIndex];
                txtMaHV.Text = row.Cells["MaHv"].Value?.ToString() ?? "";

                // Chỉ cho Admin sửa
                if (LuuThongTin.QuyenHan == "Admin")
                {
                    txtMaHV.ReadOnly = true;
                    txtTenHV.Text = row.Cells["TenHv"].Value?.ToString() ?? "";
                    cbGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                    txtSDT.Text = row.Cells["Sdt"].Value?.ToString() ?? "";
                    isEditing = true;
                }
            }
        }

        private void ClearForm()
        {
            txtMaHV.Text = "";
            txtMaHV.ReadOnly = false;
            txtTenHV.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            txtSDT.Text = "";
            isEditing = false;
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
