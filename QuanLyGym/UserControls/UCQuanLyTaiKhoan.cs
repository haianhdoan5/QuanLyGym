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
                // Nhân viên chỉ có thể tạo tài khoản cho Hội Viên
                cboQuyenHan.Items.Clear();
                cboQuyenHan.Items.Add("Hội Viên");
                cboQuyenHan.SelectedIndex = 0;
                cboQuyenHan.Enabled = false;

                // Ẩn combo mã nhân viên, hiển thị combo hội viên
                cboMaNV.Visible = false;
                cboMaHV.Visible = true;

                // Ẩn nút xóa đối với nhân viên
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

                // Hiển thị cả hai combo, xử lý thay đổi
                UpdateComboVisibility();
                cboQuyenHan.SelectedIndexChanged += CboQuyenHan_SelectedIndexChanged;

                // Hiển thị nút xóa cho Admin
                btnXoa.Visible = true;
            }
        }

        private void CboQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboVisibility();
        }

        private void UpdateComboVisibility()
        {
            if (cboQuyenHan.SelectedIndex == 3) // "Hội Viên"
            {
                cboMaNV.Visible = false;
                cboMaHV.Visible = true;
            }
            else // Admin, NhanVien, PT
            {
                cboMaNV.Visible = true;
                cboMaHV.Visible = false;
            }
        }

        private void LoadData()
        {
            try
            {
                // Load tài khoản vào datagridview
                List<TaiKhoan> taiKhoanList = bll.GetAll();
                dgvTaiKhoan.DataSource = taiKhoanList;

                // Format columns
                if (dgvTaiKhoan.Columns.Count > 0)
                {
                    dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                    dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                    dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    dgvTaiKhoan.Columns["QuyenHan"].HeaderText = "Quyền Hạn";
                    dgvTaiKhoan.Columns["MaNv"].HeaderText = "Mã Nhân Viên";
                    dgvTaiKhoan.Columns["MaHv"].HeaderText = "Mã Hội Viên";

                    // Hide navigation properties
                    if (dgvTaiKhoan.Columns.Contains("MaNvNavigation"))
                        dgvTaiKhoan.Columns["MaNvNavigation"].Visible = false;
                    if (dgvTaiKhoan.Columns.Contains("MaHvNavigation"))
                        dgvTaiKhoan.Columns["MaHvNavigation"].Visible = false;
                }

                // Load nhân viên vào combo
                List<NhanVien> nhanVienList = nhanVienBLL.GetNhanVien();
                cboMaNV.DataSource = nhanVienList;
                cboMaNV.DisplayMember = "TenNv";
                cboMaNV.ValueMember = "MaNv";

                // Load hội viên vào combo
                List<HoiVien> hoiVienList = hoiVienBLL.GetAll();
                cboMaHV.DataSource = hoiVienList;
                cboMaHV.DisplayMember = "TenHv";
                cboMaHV.ValueMember = "MaHv";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tên đăng nhập
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập");
                    return;
                }

                // Kiểm tra mật khẩu
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    return;
                }

                TaiKhoan taiKhoan = new TaiKhoan
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    QuyenHan = cboQuyenHan.Text,
                    TrangThai = true
                };

                // Xác định MaNv và MaHv dựa trên quyền hạn
                if (cboQuyenHan.Text == "Hội Viên")
                {
                    taiKhoan.MaHv = cboMaHV.SelectedValue?.ToString();
                    taiKhoan.MaNv = null;
                }
                else
                {
                    taiKhoan.MaNv = cboMaNV.SelectedValue?.ToString();
                    taiKhoan.MaHv = null;
                }

                bool result = bll.Add(taiKhoan);
                if (result)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = 0;
            cboMaNV.SelectedIndex = 0;
            cboMaHV.SelectedIndex = 0;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                if (dgvTaiKhoan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa");
                    return;
                }

                // Lấy thông tin tài khoản được chọn
                DataGridViewRow selectedRow = dgvTaiKhoan.SelectedRows[0];
                string tenDangNhap = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                string quyenHan = selectedRow.Cells["QuyenHan"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show("Không thể xác định tài khoản cần xóa");
                    return;
                }

                // Kiểm tra: Không được xóa chính mình
                if (tenDangNhap == LuuThongTin.MaNV)
                {
                    MessageBox.Show("Không thể xóa tài khoản của chính bạn");
                    return;
                }

                // Kiểm tra: Admin không được xóa Admin khác cùng level
                if (LuuThongTin.QuyenHan == "Admin" && quyenHan == "Admin")
                {
                    MessageBox.Show("Admin không thể xóa tài khoản Admin khác");
                    return;
                }
               
                // Xác nhận xóa
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
    }
}
