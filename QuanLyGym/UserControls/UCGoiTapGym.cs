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
    public partial class UCGoiTapGym : UserControl
    {
        private GoiTapGymBLL bll = new GoiTapGymBLL();
        private KhuyenMaiBLL kmBLL = new KhuyenMaiBLL();
        private bool isEditing = false;

        public UCGoiTapGym()
        {
            InitializeComponent();
        }

        private void UCGoiTapGym_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhuyenMai();
            LoadData();
        }

        private void LoadComboBoxKhuyenMai()
        {
            try
            {
                var list = kmBLL.GetAll();
                cbKhuyenMai.DataSource = list;
                cbKhuyenMai.DisplayMember = "MaKm";
                cbKhuyenMai.ValueMember = "MaKm";
                cbKhuyenMai.SelectedIndex = -1; // Không chọn mặc định
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khuyến mãi: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                List<GoiTapGym> list = bll.GetAllGoiTap();
                dgvGoiTap.DataSource = list;

                // Format columns
                if (dgvGoiTap.Columns.Count > 0)
                {
                    dgvGoiTap.Columns["MaGoi"].HeaderText = "Mã Gói Tập";
                    dgvGoiTap.Columns["TenGoi"].HeaderText = "Tên Gói Tập";
                    dgvGoiTap.Columns["DonGia"].HeaderText = "Đơn Giá";
                    dgvGoiTap.Columns["ThoiHan"].HeaderText = "Thời Hạn (ngày)";
                    dgvGoiTap.Columns["MaKm"].HeaderText = "Mã Khuyến Mãi";

                    // Hide navigation properties if any
                    if (dgvGoiTap.Columns.Contains("MaKmNavigation"))
                        dgvGoiTap.Columns["MaKmNavigation"].Visible = false;
                    if (dgvGoiTap.Columns.Contains("HopDong"))
                        dgvGoiTap.Columns["HopDong"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mã gói tập");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenGoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên gói tập");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là số");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtThoiHan.Text))
            {
                MessageBox.Show("Vui lòng nhập thời hạn");
                return;
            }

            if (!int.TryParse(txtThoiHan.Text, out int thoiHan))
            {
                MessageBox.Show("Thời hạn phải là số nguyên");
                return;
            }

            try
            {
                GoiTapGym goiTap = new GoiTapGym
                {
                    MaGoi = txtMaGoi.Text,
                    TenGoi = txtTenGoi.Text,
                    DonGia = donGia,
                    ThoiHan = thoiHan,
                    MaKm = cbKhuyenMai.SelectedValue != null ? cbKhuyenMai.SelectedValue.ToString() : null
                };

                if (bll.AddGoiTap(goiTap))
                {
                    MessageBox.Show("Thêm gói tập thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm gói tập thất bại (mã gói tập có thể đã tồn tại)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGoi.Text))
            {
                MessageBox.Show("Vui lòng chọn gói tập để sửa");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenGoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên gói tập");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là số");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtThoiHan.Text))
            {
                MessageBox.Show("Vui lòng nhập thời hạn");
                return;
            }

            if (!int.TryParse(txtThoiHan.Text, out int thoiHan))
            {
                MessageBox.Show("Thời hạn phải là số nguyên");
                return;
            }

            try
            {
                GoiTapGym goiTap = new GoiTapGym
                {
                    MaGoi = txtMaGoi.Text,
                    TenGoi = txtTenGoi.Text,
                    DonGia = donGia,
                    ThoiHan = thoiHan,
                    MaKm = cbKhuyenMai.SelectedValue != null ? cbKhuyenMai.SelectedValue.ToString() : null
                };

                if (bll.UpdateGoiTap(goiTap))
                {
                    MessageBox.Show("Cập nhật gói tập thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật gói tập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGoi.Text))
            {
                MessageBox.Show("Vui lòng chọn gói tập để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa gói tập này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (bll.DeleteGoiTap(txtMaGoi.Text))
                    {
                        MessageBox.Show("Xóa gói tập thành công!");
                        ClearForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa gói tập thất bại");
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

        private void dgvGoiTap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGoiTap.Rows[e.RowIndex];
                txtMaGoi.Text = row.Cells["MaGoi"].Value?.ToString() ?? "";
                txtMaGoi.ReadOnly = true;
                txtTenGoi.Text = row.Cells["TenGoi"].Value?.ToString() ?? "";
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString() ?? "";
                txtThoiHan.Text = row.Cells["ThoiHan"].Value?.ToString() ?? "";

                // Set ComboBox SelectedValue từ MaKm
                object maKmValue = row.Cells["MaKm"].Value;
                if (maKmValue != null && !string.IsNullOrEmpty(maKmValue.ToString()))
                {
                    cbKhuyenMai.SelectedValue = maKmValue.ToString();
                }
                else
                {
                    cbKhuyenMai.SelectedIndex = -1;
                }

                isEditing = true;
            }
        }

        private void ClearForm()
        {
            txtMaGoi.Text = "";
            txtMaGoi.ReadOnly = false;
            txtTenGoi.Text = "";
            txtDonGia.Text = "";
            txtThoiHan.Text = "";
            cbKhuyenMai.SelectedIndex = -1;
            isEditing = false;
        }
    }
}
