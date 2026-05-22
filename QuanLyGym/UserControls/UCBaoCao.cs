using QuanLyGym.BLL;
using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGym.UserControls
{
    public partial class UCBaoCao : UserControl
    {
        private BaoCaoBLL baoCaoBLL = new BaoCaoBLL();
        private string chucVu = "";
        private BaoCaoHongHoc selectedReport = null;

        public UCBaoCao()
        {
            InitializeComponent();
        }

        public UCBaoCao(string role) : this()
        {
            this.chucVu = role;
        }

        private void UCBaoCao_Load(object sender, EventArgs e)
        {
            if (chucVu != null && 
                (chucVu.Contains("Nhân Viên") || 
                 chucVu.Contains("NhanVien") || 
                 chucVu.ToLower().Contains("staff")))
            {
                LoadEmployeeUI();
            }
            else
            {
                LoadAdminUI();
            }
        }

        private void LoadEmployeeUI()
        {
            try
            {
                // Hide Admin components
                dgvBaoCao.Visible = false;
                lblDoanhThu.Visible = false;
                lblTongHoiVien.Visible = false;
                lblSoBaoCao.Visible = false;
                chartDoanhThu.Visible = false;
                pnlDashboard.Visible = false;
                pnlAdminButtons.Visible = false;

                // Show Employee components - CHỈ GỬI BÁO CÁO
                pnlNhapBaoCao.Visible = true;
                txtNoiDungBaoCao.Visible = true;
                cbThietBi.Visible = true;
                btnNopBaoCao.Visible = true;
                lblThietBi.Visible = true;
                lblNoiDung.Visible = true;
                txtDonViThucHien.Visible = true;
                lblDonVi.Visible = true;

                // Load equipment combobox
                List<ThietBiGym> danhSachThietBi = baoCaoBLL.LayDanhSachThietBi();
                cbThietBi.DataSource = danhSachThietBi;
                cbThietBi.DisplayMember = "TenTb";
                cbThietBi.ValueMember = "MaTb";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải UI nhân viên: " + ex.Message, "Lỗi");
            }
        }

        private void LoadAdminUI()
        {
            try
            {
                // Show Admin components - FULL QUYỀN (VIEW, EDIT, DELETE)
                dgvBaoCao.Visible = true;
                lblDoanhThu.Visible = true;
                lblTongHoiVien.Visible = true;
                lblSoBaoCao.Visible = true;
                chartDoanhThu.Visible = false;
                pnlDashboard.Visible = true;
                pnlAdminButtons.Visible = true;

                // Hide Employee components
                pnlNhapBaoCao.Visible = false;

                // Set DataGridView editable for Admin
                dgvBaoCao.ReadOnly = false;
                dgvBaoCao.AllowUserToAddRows = false;
                dgvBaoCao.AllowUserToDeleteRows = false;

                // Load dashboard data
                LoadDashboardData();
                LoadReportList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải UI quản lý: " + ex.Message, "Lỗi");
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                int thang = DateTime.Now.Month;
                int nam = DateTime.Now.Year;

                // Total Members
                int tongHoiVien = baoCaoBLL.DemTongHoiVien();
                lblTongHoiVien.Text = $"Tổng Hội Viên: {tongHoiVien}";

                // Monthly Revenue
                decimal doanhThuThang = baoCaoBLL.TinhDoanhThuThang(thang, nam);
                lblDoanhThu.Text = $"Doanh Thu Tháng {thang}: {doanhThuThang:N0} HĐ";

                // Monthly Reports Count
                int soBaoCao = baoCaoBLL.DemBaoCaoThang(thang, nam);
                lblSoBaoCao.Text = $"Báo Cáo Tháng {thang}: {soBaoCao}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu dashboard: " + ex.Message, "Lỗi");
            }
        }

        private void LoadReportList()
        {
            try
            {
                List<BaoCaoHongHoc> danhSachBaoCao = baoCaoBLL.LayDanhSachBaoCaoNhanVien();
                dgvBaoCao.DataSource = danhSachBaoCao;
                dgvBaoCao.AutoResizeColumns();

                // Rename columns
                if (dgvBaoCao.Columns.Contains("MaNv"))
                    dgvBaoCao.Columns["MaNv"].HeaderText = "Mã Nhân Viên";
                if (dgvBaoCao.Columns.Contains("MaTb"))
                    dgvBaoCao.Columns["MaTb"].HeaderText = "Mã Thiết Bị";
                if (dgvBaoCao.Columns.Contains("MoTaSuCo"))
                    dgvBaoCao.Columns["MoTaSuCo"].HeaderText = "Nội Dung";
                if (dgvBaoCao.Columns.Contains("NgayBao"))
                    dgvBaoCao.Columns["NgayBao"].HeaderText = "Ngày Báo Cáo";
                if (dgvBaoCao.Columns.Contains("DonViThucHien"))
                    dgvBaoCao.Columns["DonViThucHien"].HeaderText = "Đơn Vị Thực Hiện";

                // Hide navigation columns
                if (dgvBaoCao.Columns.Contains("MaNvNavigation"))
                    dgvBaoCao.Columns["MaNvNavigation"].Visible = false;
                if (dgvBaoCao.Columns.Contains("MaTbNavigation"))
                    dgvBaoCao.Columns["MaTbNavigation"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách báo cáo: " + ex.Message, "Lỗi");
            }
        }

        private void SubmitReport()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(LuuThongTin.MaNV))
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên", "Lỗi");
                    return;
                }

                if (cbThietBi.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị", "Cảnh báo");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNoiDungBaoCao.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung báo cáo", "Cảnh báo");
                    return;
                }

                BaoCaoHongHoc baoCao = new BaoCaoHongHoc
                {
                    MaNv = LuuThongTin.MaNV,
                    MaTb = cbThietBi.SelectedValue.ToString(),
                    MoTaSuCo = txtNoiDungBaoCao.Text,
                    DonViThucHien = txtDonViThucHien.Text,
                    NgayBao = DateTime.Now
                };

                if (baoCaoBLL.NopBaoCaoHongHoc(baoCao))
                {
                    MessageBox.Show("Nộp báo cáo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearEmployeeForm();
                }
                else
                {
                    MessageBox.Show("Nộp báo cáo thất bại", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nộp báo cáo: " + ex.Message, "Lỗi");
            }
        }

        private void ClearEmployeeForm()
        {
            cbThietBi.SelectedIndex = -1;
            txtNoiDungBaoCao.Clear();
            txtDonViThucHien.Clear();
        }

        private void LoadBaoCao()
        {
            try
            {
                if (chucVu != null && 
                    (chucVu.Contains("Nhân Viên") || 
                     chucVu.Contains("NhanVien") || 
                     chucVu.ToLower().Contains("staff")))
                {
                    LoadEmployeeUI();
                }
                else
                {
                    LoadAdminUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers for submit button
        public void BtnNopBaoCao_Click(object sender, EventArgs e)
        {
            SubmitReport();
        }

        public void RefreshReports()
        {
            if (!chucVu.Contains("Nhân Viên") && 
                !chucVu.Contains("NhanVien") && 
                !chucVu.ToLower().Contains("staff"))
            {
                LoadDashboardData();
                LoadReportList();
            }
        }

        private void dgvBaoCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBaoCao.Rows[e.RowIndex];
                string maTb = row.Cells["MaTb"].Value?.ToString();
                string maNv = row.Cells["MaNv"].Value?.ToString();

                if (!string.IsNullOrEmpty(maTb) && !string.IsNullOrEmpty(maNv))
                {
                    selectedReport = baoCaoBLL.LayChiTietBaoCao(maTb, maNv);
                }
            }
        }

        private void BtnSuaBaoCao_Click(object sender, EventArgs e)
        {
            if (selectedReport == null)
            {
                MessageBox.Show("Vui lòng chọn báo cáo cần sửa từ danh sách!", "Thông báo");
                return;
            }

            try
            {
                // Tạo form để sửa báo cáo
                using (Form editForm = new Form())
                {
                    editForm.Text = "Sửa Báo Cáo Hư Hỏng";
                    editForm.Width = 500;
                    editForm.Height = 300;
                    editForm.StartPosition = FormStartPosition.CenterParent;

                    Label lblNguoiBC = new Label() { Text = "Nhân Viên:", Left = 20, Top = 20, Width = 100 };
                    TextBox txtNguoiBC = new TextBox() { Left = 150, Top = 20, Width = 300, Text = selectedReport.MaNv, ReadOnly = true };

                    Label lblThietBiBC = new Label() { Text = "Thiết Bị:", Left = 20, Top = 60, Width = 100 };
                    TextBox txtThietBiBC = new TextBox() { Left = 150, Top = 60, Width = 300, Text = selectedReport.MaTb, ReadOnly = true };

                    Label lblNoiDungBC = new Label() { Text = "Nội Dung:", Left = 20, Top = 100, Width = 100 };
                    TextBox txtNoiDungBC = new TextBox() { Left = 150, Top = 100, Width = 300, Height = 80, Multiline = true, Text = selectedReport.MoTaSuCo };

                    Label lblDonVi = new Label() { Text = "Đơn Vị Thực Hiện:", Left = 20, Top = 190, Width = 100 };
                    TextBox txtDonVi = new TextBox() { Left = 150, Top = 190, Width = 300, Text = selectedReport.DonViThucHien ?? "" };

                    Button btnSave = new Button() { Text = "Lưu", Left = 150, Top = 230, Width = 100, DialogResult = DialogResult.OK };
                    Button btnCancel = new Button() { Text = "Hủy", Left = 300, Top = 230, Width = 100, DialogResult = DialogResult.Cancel };

                    editForm.Controls.Add(lblNguoiBC);
                    editForm.Controls.Add(txtNguoiBC);
                    editForm.Controls.Add(lblThietBiBC);
                    editForm.Controls.Add(txtThietBiBC);
                    editForm.Controls.Add(lblNoiDungBC);
                    editForm.Controls.Add(txtNoiDungBC);
                    editForm.Controls.Add(lblDonVi);
                    editForm.Controls.Add(txtDonVi);
                    editForm.Controls.Add(btnSave);
                    editForm.Controls.Add(btnCancel);
                    editForm.AcceptButton = btnSave;
                    editForm.CancelButton = btnCancel;

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedReport.MoTaSuCo = txtNoiDungBC.Text;
                        selectedReport.DonViThucHien = txtDonVi.Text;

                        if (baoCaoBLL.SuaBaoCaoHongHoc(selectedReport))
                        {
                            MessageBox.Show("Cập nhật báo cáo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReportList();
                            selectedReport = null;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật báo cáo thất bại!", "Lỗi");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void BtnXoaBaoCao_Click(object sender, EventArgs e)
        {
            if (selectedReport == null)
            {
                MessageBox.Show("Vui lòng chọn báo cáo cần xóa từ danh sách!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa báo cáo của nhân viên {selectedReport.MaNv}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (baoCaoBLL.XoaBaoCaoHongHoc(selectedReport.MaTb, selectedReport.MaNv))
                    {
                        MessageBox.Show("Xóa báo cáo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReportList();
                        selectedReport = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa báo cáo thất bại!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}
