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
            if (LuuThongTin.LoaiNguoiDung == "HoiVien")
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

            // Nếu là hội viên, chỉ lấy hợp đồng của họ
            if (LuuThongTin.LoaiNguoiDung == "HoiVien")
            {
                list = hdBLL.GetAll().Where(h => h.MaHv == LuuThongTin.MaHV).ToList();
            }
            else
            {
                list = hdBLL.GetAll();
            }

            dgvHopDong.DataSource = list;

            // Ẩn các cột Navigation không cần thiết
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

            // Gom thông tin từ giao diện vào Model
            HopDong hd = new HopDong();
            hd.MaHd = txtMaHD.Text.Trim();
            hd.NoiDung = txtNoiDung.Text.Trim();
            hd.MaHv = cbHoiVien.SelectedValue?.ToString();
            hd.MaGoi = cbGoiTap.SelectedValue?.ToString();
            hd.MaNv = cbNhanVien.SelectedValue?.ToString();
            // hd.MaKM = txtMaKM.Text;

            // Gọi tầng BLL để xử lý cập nhật
            string ketQua = hdBLL.Update(hd);
            if (ketQua == "Success")
            {
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHopDong(); // Tải lại lưới dữ liệu
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
            // cbNhanVien.SelectedIndex = -1;

            txtMaHD.ReadOnly = false; // Mở khóa cho phép nhập mã mới khi thêm mới
            txtMaHD.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa từ danh sách!", "Thông báo");
                return;
            }

            // Hiện bảng hỏi xác nhận trước khi xóa dữ liệu quan trọng
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string ketQua = hdBLL.Delete(txtMaHD.Text);
                if (ketQua == "Success")
                {
                    MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo");
                    LoadDanhSachHopDong();
                    btnLamMoi_Click(sender, e); // Xóa trắng form sau khi xóa dữ liệu thành công
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Validation: Kiểm tra các trường bắt buộc (không cần kiểm tra MaHD vì nó tự động sinh)
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

            // 1. Auto-generate Mã Hợp Đồng
            string maHDMoi = hdBLL.GetNextMaHD();
            hd.MaHd = maHDMoi;

            // 2. Các trường dữ liệu từ Giao diện
            hd.NoiDung = txtNoiDung.Text.Trim();
            hd.MaHv = cbHoiVien.SelectedValue?.ToString();
            hd.MaGoi = cbGoiTap.SelectedValue?.ToString();
            hd.MaNv = cbNhanVien.SelectedValue?.ToString();

            // 3. Các trường hệ thống tự sinh
            hd.NgayLap = DateTime.Now;

            // 4. Các trường chưa có trên Giao diện
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
            // Lấy MaNv từ ComboBox khi chọn nhân viên
            if (cbNhanVien.SelectedValue != null)
            {
                string maNv = cbNhanVien.SelectedValue.ToString();
                // Bạn có thể sử dụng maNv cho các xử lý khác tại đây nếu cần
                // Ví dụ: MessageBox.Show("Nhân viên được chọn: " + maNv);
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
            if (e.RowIndex >= 0) // Kiểm tra người dùng click đúng dòng có dữ liệu
            {
                DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];

                // Đẩy dữ liệu vào TextBox (Chú ý: Đổi tên cột trong ngoặc kép cho khớp với Model Entity Framework)
                txtMaHD.Text = row.Cells["MaHD"].Value?.ToString(); // Thường EF Core tự sinh tên cột là MaHD
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();

                // Cần kiểm tra xem có lấy được MaKM trên lưới không
                if (dgvHopDong.Columns.Contains("MaKM"))
                {
                    txtMaKM.Text = row.Cells["MaKM"].Value?.ToString();
                }

                // Gán giá trị vào ComboBox (Sử dụng ID/Mã thay vì gán Text để tránh lỗi cập nhật)
                if (row.Cells["MaHV"].Value != null)
                    cbHoiVien.SelectedValue = row.Cells["MaHV"].Value.ToString();

                if (row.Cells["MaGoi"].Value != null)
                    cbGoiTap.SelectedValue = row.Cells["MaGoi"].Value.ToString();
                if (row.Cells["MaNV"].Value != null)
                    cbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();

                // Khóa không cho sửa Mã Hợp Đồng
                txtMaHD.ReadOnly = true;
            }
        }
    }
}
