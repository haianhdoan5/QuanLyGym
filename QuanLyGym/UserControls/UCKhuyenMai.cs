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
    public partial class UCKhuyenMai : UserControl
    {
        private KhuyenMaiBLL kmBLL = new KhuyenMaiBLL();
        private bool isEditing = false;

        public UCKhuyenMai()
        {
            InitializeComponent();
        }

        private void UCKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhuyenMai();
        }

        private void LoadDanhSachKhuyenMai()
        {
            try
            {
                dgvKhuyenMai.DataSource = kmBLL.GetAll();

                // Đặt tiêu đề cột
                if (dgvKhuyenMai.Columns.Count > 0)
                {
                    dgvKhuyenMai.Columns["MaKm"].HeaderText = "Mã Khuyến Mãi";
                    dgvKhuyenMai.Columns["PhanTramGiam"].HeaderText = "Phần Trăm Giảm (%)";

                    // Ẩn các cột Navigation
                    if (dgvKhuyenMai.Columns.Contains("GoiTapGym"))
                        dgvKhuyenMai.Columns["GoiTapGym"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKm.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khuyến mãi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKm.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhanTramGiam.Text))
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramGiam.Focus();
                return;
            }

            if (!decimal.TryParse(txtPhanTramGiam.Text, out decimal phanTramGiam))
            {
                MessageBox.Show("Phần trăm giảm phải là số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramGiam.Focus();
                return;
            }

            try
            {
                KhuyenMai km = new KhuyenMai
                {
                    MaKm = txtMaKm.Text.Trim(),
                    PhanTramGiam = phanTramGiam
                };

                string ketQua = kmBLL.Insert(km);
                if (ketQua == "Success")
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhuyenMai();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKm.Text))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhanTramGiam.Text))
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramGiam.Focus();
                return;
            }

            if (!decimal.TryParse(txtPhanTramGiam.Text, out decimal phanTramGiam))
            {
                MessageBox.Show("Phần trăm giảm phải là số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramGiam.Focus();
                return;
            }

            try
            {
                KhuyenMai km = new KhuyenMai
                {
                    MaKm = txtMaKm.Text.Trim(),
                    PhanTramGiam = phanTramGiam
                };

                string ketQua = kmBLL.Update(km);
                if (ketQua == "Success")
                {
                    MessageBox.Show("Cập nhật khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhuyenMai();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKm.Text))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string ketQua = kmBLL.Delete(txtMaKm.Text.Trim());
                    if (ketQua == "Success")
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachKhuyenMai();
                        btnLamMoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKm.Clear();
            txtPhanTramGiam.Clear();
            txtMaKm.ReadOnly = false;
            txtMaKm.Focus();
            isEditing = false;
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];

                // Đẩy dữ liệu vào TextBox
                txtMaKm.Text = row.Cells["MaKm"].Value?.ToString();
                txtPhanTramGiam.Text = row.Cells["PhanTramGiam"].Value?.ToString();

                // Khóa không cho sửa Mã Khuyến Mãi
                txtMaKm.ReadOnly = true;
                isEditing = true;
            }
        }

        private void txtPhanTramGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và dấu chấm
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
