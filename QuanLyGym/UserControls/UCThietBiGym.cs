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
    public partial class UCThietBiGym : UserControl
    {
        private ThietBiGymBLL bll = new ThietBiGymBLL();
        private bool isEditing = false;

        public UCThietBiGym()
        {
            InitializeComponent();
        }

        private void UCThietBiGym_Load(object sender, EventArgs e)
        {
            LoadData();
            CheckPermissions();
        }

        private void CheckPermissions()
        {
            // Nếu là nhân viên, vô hiệu hóa nút Sửa và Xóa
            if (LuuThongTin.QuyenHan != null && 
                (LuuThongTin.QuyenHan.Contains("Nhân Viên") || 
                 LuuThongTin.QuyenHan.Contains("NhanVien") || 
                 LuuThongTin.QuyenHan.ToLower().Contains("staff")))
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
        }

        private void LoadData()
        {
            try
            {
                List<ThietBiGym> list = bll.GetAllThietBi();
                dgvThietBi.DataSource = list;

                // Format columns
                if (dgvThietBi.Columns.Count > 0)
                {
                    dgvThietBi.Columns["MaTb"].HeaderText = "Mã Thiết Bị";
                    dgvThietBi.Columns["TenTb"].HeaderText = "Tên Thiết Bị";
                    dgvThietBi.Columns["LoaiThietBi"].HeaderText = "Loại Thiết Bị";
                    dgvThietBi.Columns["NgayMua"].HeaderText = "Ngày Mua";
                    dgvThietBi.Columns["TinhTrang"].HeaderText = "Tình Trạng";

                    // Hide navigation properties if any
                    if (dgvThietBi.Columns.Contains("BaoCaoHongHoc"))
                        dgvThietBi.Columns["BaoCaoHongHoc"].Visible = false;
                    if (dgvThietBi.Columns.Contains("LichBaoTri"))
                        dgvThietBi.Columns["LichBaoTri"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Đã bỏ check txtMaTB vì sinh tự động
            if (string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị");
                return;
            }

            if (cboLoaiThietBi.SelectedIndex == -1) // Đổi từ txtLoaiTB sang cboLoaiThietBi
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị (Máy/Tạ)");
                return;
            }

            if (cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng");
                return;
            }

            try
            {
                // Gọi hàm tự sinh mã từ BLL
                string maTBMoi = bll.GetNextMaTb();

                ThietBiGym thietBi = new ThietBiGym
                {
                    MaTb = maTBMoi, // Dùng mã mới sinh
                    TenTb = txtTenTB.Text,
                    LoaiThietBi = cboLoaiThietBi.SelectedItem.ToString(), // Lấy từ ComboBox
                    NgayMua = dtpNgayMua.Value,
                    TinhTrang = cboTinhTrang.SelectedItem.ToString()
                };

                if (bll.AddThietBi(thietBi))
                {
                    MessageBox.Show($"Thêm thiết bị thành công với Mã: {maTBMoi}");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thiết bị thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTB.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị ở bảng dưới để sửa");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị");
                return;
            }

            if (cboLoaiThietBi.SelectedIndex == -1) // Đổi từ txtLoaiTB
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị");
                return;
            }

            if (cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng");
                return;
            }

            try
            {
                ThietBiGym thietBi = new ThietBiGym
                {
                    MaTb = txtMaTB.Text,
                    TenTb = txtTenTB.Text,
                    LoaiThietBi = cboLoaiThietBi.SelectedItem.ToString(), // Lấy từ ComboBox
                    NgayMua = dtpNgayMua.Value,
                    TinhTrang = cboTinhTrang.SelectedItem.ToString()
                };

                if (bll.UpdateThietBi(thietBi))
                {
                    MessageBox.Show("Cập nhật thiết bị thành công!");
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thiết bị thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTB.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (bll.DeleteThietBi(txtMaTB.Text))
                    {
                        MessageBox.Show("Xóa thiết bị thành công!");
                        ClearForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thiết bị thất bại");
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

        private void dgvThietBi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThietBi.Rows[e.RowIndex];
                txtMaTB.Text = row.Cells["MaTb"].Value?.ToString() ?? "";
                txtTenTB.Text = row.Cells["TenTb"].Value?.ToString() ?? "";

                // Đẩy loại thiết bị lên ComboBox
                cboLoaiThietBi.SelectedItem = row.Cells["LoaiThietBi"].Value?.ToString() ?? "";

                if (row.Cells["NgayMua"].Value != null && row.Cells["NgayMua"].Value != DBNull.Value)
                {
                    dtpNgayMua.Value = (DateTime)row.Cells["NgayMua"].Value;
                }
                cboTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value?.ToString() ?? "";
                isEditing = true;
            }
        }

        private void ClearForm()
        {
            txtMaTB.Text = "";
            txtTenTB.Text = "";
            dtpNgayMua.Value = DateTime.Now;
            cboTinhTrang.SelectedIndex = -1;
            cboLoaiThietBi.SelectedIndex = -1; // Reset lại ComboBox Loại
            isEditing = false;
        }

        private void dgvThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
