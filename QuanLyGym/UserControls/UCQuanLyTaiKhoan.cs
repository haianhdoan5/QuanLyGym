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
    public partial class UCQuanLyTaiKhoan : UserControl
    {
        private TaiKhoanBLL bll = new TaiKhoanBLL();
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private HoiVienBLL hoiVienBLL = new HoiVienBLL();

        public UCQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void ucQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                CheckPermissions();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void CheckPermissions()
        {
            if (LuuThongTin.QuyenHan == "NhanVien")
            {
                // Nhân viên chỉ được tạo tài khoản Hội Viên
                cboQuyenHan.Items.Clear();
                cboQuyenHan.Items.Add("Hội Viên");
                cboQuyenHan.SelectedIndex = 0;
                cboQuyenHan.Enabled = false;

                // Làm mờ ô Mã NV, chỉ cho phép thao tác ô Mã HV
                cboMaNV.Enabled = false;
                cboMaHV.Enabled = true;

                // Nhân viên ĐƯỢC THÊM, nhưng KHÔNG ĐƯỢC SỬA/XÓA
                btnThem.Visible = true;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            else if (LuuThongTin.QuyenHan == "Admin")
            {
                // Admin có thể tạo tài khoản cho tất cả
                cboQuyenHan.Items.Clear();
                cboQuyenHan.Items.Add("Admin");
                cboQuyenHan.Items.Add("NhanVien");
                cboQuyenHan.Items.Add("PT");
                cboQuyenHan.Items.Add("Hội Viên");
                cboQuyenHan.SelectedIndex = 0;
                cboQuyenHan.Enabled = true;

                // Cập nhật trạng thái mờ/rõ của 2 ô Mã NV/HV
                UpdateComboVisibility();
                cboQuyenHan.SelectedIndexChanged += CboQuyenHan_SelectedIndexChanged;

                // Admin xài full quyền
                btnThem.Visible = true;
                btnSua.Visible = true;
                btnXoa.Visible = true;
            }
        }
        
        private void CboQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboVisibility();
        }

        private void UpdateComboVisibility()
        {
            if (cboQuyenHan.Text == "Hội Viên")
            {
                // Nếu là Hội Viên -> Khóa Mã NV, Mở Mã HV
                cboMaNV.Enabled = false;
                cboMaNV.SelectedIndex = -1;

                cboMaHV.Enabled = true;
            }
            else
            {
                // Nếu là Admin, NhanVien, PT -> Khóa Mã HV, Mở Mã NV
                cboMaHV.Enabled = false;
                cboMaHV.SelectedIndex = -1;

                cboMaNV.Enabled = true;
            }
        }

        private void LoadData()
        {
            try
            {
                List<TaiKhoan> allTaiKhoan = bll.GetAll();
                List<string> dacoTaiKhoanNV = allTaiKhoan
                    .Where(t => !string.IsNullOrWhiteSpace(t.MaNv))
                    .Select(t => t.MaNv.Trim().ToUpper())
                    .ToList();

                List<string> dacoTaiKhoanHV = allTaiKhoan
                    .Where(t => !string.IsNullOrWhiteSpace(t.MaHv))
                    .Select(t => t.MaHv.Trim().ToUpper())
                    .ToList();

                List<TaiKhoan> taiKhoanList = allTaiKhoan;

                // Nếu là NhanVien, chỉ hiển thị tài khoản Hội Viên
                if (LuuThongTin.QuyenHan == "NhanVien")
                {
                    taiKhoanList = taiKhoanList.Where(tk => tk.QuyenHan == "Hội Viên").ToList();
                }

                dgvTaiKhoan.DataSource = taiKhoanList;

                if (dgvTaiKhoan.Columns.Count > 0)
                {
                    dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                    dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                    dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    dgvTaiKhoan.Columns["QuyenHan"].HeaderText = "Quyền Hạn";
                    dgvTaiKhoan.Columns["MaNv"].HeaderText = "Mã Nhân Viên";
                    dgvTaiKhoan.Columns["MaHv"].HeaderText = "Mã Hội Viên";

                    if (dgvTaiKhoan.Columns.Contains("MaNvNavigation"))
                        dgvTaiKhoan.Columns["MaNvNavigation"].Visible = false;
                    if (dgvTaiKhoan.Columns.Contains("MaHvNavigation"))
                        dgvTaiKhoan.Columns["MaHvNavigation"].Visible = false;
                }

                List<NhanVien> nhanVienList = nhanVienBLL.GetNhanVien()
                    .Where(nv => !dacoTaiKhoanNV.Contains(nv.MaNv.Trim().ToUpper()))
                    .ToList();

                var nvDisplayList = nhanVienList.Select(nv => new
                {
                    MaNv = nv.MaNv,
                    HienThi = nv.MaNv + " - " + nv.TenNv
                }).ToList();

                cboMaNV.DataSource = nvDisplayList;
                cboMaNV.DisplayMember = "HienThi";
                cboMaNV.ValueMember = "MaNv";

                List<HoiVien> hoiVienList = hoiVienBLL.GetAll()
                    .Where(hv => !dacoTaiKhoanHV.Contains(hv.MaHv.Trim().ToUpper()))
                    .ToList();

                var hvDisplayList = hoiVienList.Select(hv => new
                {
                    MaHv = hv.MaHv,
                    HienThi = hv.MaHv + " - " + hv.TenHv
                }).ToList();

                cboMaHV.DataSource = hvDisplayList;
                cboMaHV.DisplayMember = "HienThi";
                cboMaHV.ValueMember = "MaHv";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LuuThongTin.QuyenHan != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới có quyền cập nhật tài khoản!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản từ danh sách để sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }

            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái tài khoản!");
                return;
            }

            try
            {
                TaiKhoan tkSua = new TaiKhoan
                {
                    TenDangNhap = txtTenDangNhap.Text, 
                    MatKhau = txtMatKhau.Text,         
                    QuyenHan = cboQuyenHan.Text, 
                    TrangThai = (cboTrangThai.SelectedItem.ToString() == "Hoạt động"), // True/False

                    MaNv = (cboQuyenHan.Text == "Hội Viên") ? null : cboMaNV.SelectedValue?.ToString(),
                    MaHv = (cboQuyenHan.Text == "Hội Viên") ? cboMaHV.SelectedValue?.ToString() : null
                };

                if (bll.Update(tkSua))
                {
                    MessageBox.Show("Cập nhật thông tin tài khoản thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa tài khoản: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtTenDangNhap.Clear();
            txtTenDangNhap.ReadOnly = false;

            txtMatKhau.Clear();

            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            // Trả lại trạng thái phân quyền ban đầu
            if (LuuThongTin.QuyenHan == "Admin")
            {
                cboQuyenHan.Enabled = true;
                cboQuyenHan.SelectedIndex = 0;
                UpdateComboVisibility(); 
            }
            else if (LuuThongTin.QuyenHan == "NhanVien")
            {
                cboQuyenHan.SelectedIndex = 0; // Luôn là Hội Viên
                cboMaNV.Enabled = false;
                cboMaHV.Enabled = true;
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTaiKhoan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa");
                    return;
                }

                DataGridViewRow selectedRow = dgvTaiKhoan.SelectedRows[0];
                string tenDangNhap = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                string quyenHan = selectedRow.Cells["QuyenHan"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show("Không thể xác định tài khoản cần xóa");
                    return;
                }

                if (tenDangNhap == LuuThongTin.MaNV)
                {
                    MessageBox.Show("Không thể xóa tài khoản của chính bạn");
                    return;
                }

                if (LuuThongTin.QuyenHan == "Admin" && quyenHan == "Admin")
                {
                    MessageBox.Show("Admin không thể xóa tài khoản Admin khác");
                    return;
                }
               
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa tài khoản '{tenDangNhap}'?",
                    "Xác nhận xóa tài khoản",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(tenDangNhap))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");
                        ClearForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message);
            }
        }

        private void dgvTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? "";
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString() ?? "";
                cboQuyenHan.Text = row.Cells["QuyenHan"].Value?.ToString() ?? "";
                bool trangThai = row.Cells["TrangThai"].Value != null && (bool)row.Cells["TrangThai"].Value;
                cboTrangThai.SelectedItem = trangThai ? "Hoạt động" : "Không hoạt động";

                if (cboQuyenHan.Text == "Hội Viên")
                {
                    cboMaHV.SelectedValue = row.Cells["MaHv"].Value?.ToString() ?? "";
                }
                else
                {
                    cboMaNV.SelectedValue = row.Cells["MaNv"].Value?.ToString() ?? "";
                }

                // KHOÁ CÁC TRƯỜNG THEO QUYỀN
                txtTenDangNhap.ReadOnly = true;
                cboMaNV.Enabled = false;
                cboMaHV.Enabled = false;

                // Chỉ Admin mới được phép mở khóa để sửa Quyền Hạn
                if (LuuThongTin.QuyenHan == "Admin")
                {
                    cboQuyenHan.Enabled = true;
                }
                else
                {
                    cboQuyenHan.Enabled = false;
                }
            }
        }
    }
}
