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
    public partial class UCNhanVien : UserControl
    {
        private NhanVienBLL bll = new NhanVienBLL();
        private bool isEditing = false;

        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<NhanVien> list = bll.GetNhanVien();
                dgvNhanVien.DataSource = list;

                // Format columns
                if (dgvNhanVien.Columns.Count > 0)
                {
                    dgvNhanVien.Columns["MaNv"].HeaderText = "Mã Nhân Viên";
                    dgvNhanVien.Columns["TenNv"].HeaderText = "Tên Nhân Viên";
                    dgvNhanVien.Columns["Sdt"].HeaderText = "Số Điện Thoại";
                    dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";

                    // Hide navigation properties
                    if (dgvNhanVien.Columns.Contains("BaoCaoHongHoc"))
                        dgvNhanVien.Columns["BaoCaoHongHoc"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("ChamSocHoiVien"))
                        dgvNhanVien.Columns["ChamSocHoiVien"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("HoSoNhanSu"))
                        dgvNhanVien.Columns["HoSoNhanSu"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("HopDong"))
                        dgvNhanVien.Columns["HopDong"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("Lam"))
                        dgvNhanVien.Columns["Lam"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("LichBaoTri"))
                        dgvNhanVien.Columns["LichBaoTri"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("LichTapLuyen"))
                        dgvNhanVien.Columns["LichTapLuyen"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("PhieuBaoLuu"))
                        dgvNhanVien.Columns["PhieuBaoLuu"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("PhieuChuyenNhuong"))
                        dgvNhanVien.Columns["PhieuChuyenNhuong"].Visible = false;
                    if (dgvNhanVien.Columns.Contains("TaiKhoan"))
                        dgvNhanVien.Columns["TaiKhoan"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return;
            }

            try
            {
                NhanVien nv = new NhanVien
                {
                    MaNv = txtMaNV.Text,
                    TenNv = txtTenNV.Text,
                    Sdt = txtSDT.Text,
                    ChucVu = txtChucVu.Text
                };

                bool result = bll.AddNhanVien(nv);
                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return;
            }

            try
            {
                NhanVien nv = new NhanVien
                {
                    MaNv = txtMaNV.Text,
                    TenNv = txtTenNV.Text,
                    Sdt = txtSDT.Text,
                    ChucVu = txtChucVu.Text
                };

                string result = bll.Update(nv);
                if (result == "Success")
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string deleteResult = bll.Delete(txtMaNV.Text);
                    if (deleteResult == "Success")
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        ClearForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(deleteResult);
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

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNv"].Value?.ToString() ?? "";
                txtMaNV.ReadOnly = true;
                txtTenNV.Text = row.Cells["TenNv"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["Sdt"].Value?.ToString() ?? "";
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString() ?? "";
                isEditing = true;
            }
        }

        private void ClearForm()
        {
            txtMaNV.Text = "";
            txtMaNV.ReadOnly = false;
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtChucVu.Text = "";
            isEditing = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
