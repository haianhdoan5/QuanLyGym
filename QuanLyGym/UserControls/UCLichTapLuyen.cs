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
    public partial class UCLichTapLuyen : UserControl
    {
        private LichTapLuyenBLL bll = new LichTapLuyenBLL();
        private bool isEditing = false;
        private string currentMaLt = "";

        public UCLichTapLuyen()
        {
            InitializeComponent();
        }

        private void UCLichTapLuyen_Load(object sender, EventArgs e)
        {
            LoadData();
            CheckPermissions();
        }

        private void CheckPermissions()
        {
            // Nếu là hội viên, chỉ xem được lịch tập của mình
            if (LuuThongTin.QuyenHan == "HoiVien")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                pnlThongTin.Visible = false;
                dgvLichTap.ReadOnly = true;
            }
        }

        private void LoadData()
        {
            try
            {
                List<LichTapLuyen> list;

                // Nếu là hội viên, chỉ lấy lịch tập của họ
                if (LuuThongTin.LoaiNguoiDung == "HoiVien")
                {
                    list = bll.GetByHoiVien(LuuThongTin.MaHV);
                }
                else
                {
                    // Admin/nhân viên lấy tất cả
                    list = bll.GetAll();
                }

                dgvLichTap.DataSource = list;

                if (dgvLichTap.Columns.Count > 0)
                {
                    dgvLichTap.Columns["MaLt"].HeaderText = "Mã Lịch";
                    dgvLichTap.Columns["NgayTap"].HeaderText = "Ngày Tập";
                    dgvLichTap.Columns["GioTap"].HeaderText = "Giờ Tập";
                    dgvLichTap.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    dgvLichTap.Columns["MaHv"].HeaderText = "Mã HV";
                    dgvLichTap.Columns["MaNv"].HeaderText = "Mã NV";

                    if (dgvLichTap.Columns.Contains("MaHvNavigation"))
                        dgvLichTap.Columns["MaHvNavigation"].Visible = false;
                    if (dgvLichTap.Columns.Contains("MaNvNavigation"))
                        dgvLichTap.Columns["MaNvNavigation"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLichTap.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lịch tập");
                return;
            }

            if (dtpNgayTap.Value == null)
            {
                MessageBox.Show("Vui lòng chọn ngày tập");
                return;
            }

            try
            {
                LichTapLuyen lichTap = new LichTapLuyen
                {
                    MaLt = txtMaLichTap.Text,
                    NgayTap = dtpNgayTap.Value,
                    GioTap = TimeSpan.FromHours(int.TryParse(txtGioTap.Text, out int hour) ? hour : 0),
                    TrangThai = cbTrangThai.SelectedItem?.ToString() ?? "Chưa Tập",
                    MaHv = txtMaHV.Text,
                    MaNv = txtMaNV.Text
                };

                if (bll.Add(lichTap))
                {
                    MessageBox.Show("Thêm lịch tập thành công!", "Thành công");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm lịch tập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                //BẤM "SỬA" ĐỂ ĐỔ DỮ LIỆU LÊN FORM
                if (dgvLichTap.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một lịch tập để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = dgvLichTap.SelectedRows[0];
                currentMaLt = row.Cells["MaLt"].Value.ToString();
                var lichTap = bll.GetById(currentMaLt);

                if (lichTap != null)
                {
                    txtMaLichTap.Text = lichTap.MaLt;
                    dtpNgayTap.Value = lichTap.NgayTap ?? DateTime.Now;

                    txtGioTap.Text = lichTap.GioTap?.ToString(@"hh\:mm") ?? "00:00";

                    cbTrangThai.Text = lichTap.TrangThai;
                    txtMaHV.Text = lichTap.MaHv;
                    txtMaNV.Text = lichTap.MaNv;

                    // Chuyển trạng thái giao diện sang chế độ đang chỉnh sửa
                    isEditing = true;
                    btnSua.Text = "Lưu Sửa";
                    txtMaLichTap.ReadOnly = true;
                }
            }
            else
            {
                // TRƯỜNG HỢP 2: BẤM "LƯU SỬA" ĐỂ CẬP NHẬT DATABASE
                try
                {
                    var lichTap = bll.GetById(currentMaLt);
                    if (lichTap == null)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu lịch tập này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lichTap.NgayTap = dtpNgayTap.Value;

                    string inputGio = txtGioTap.Text.Trim();
                    // Nhập mỗi số "3", tự động biến đổi thành "3:00" để Parse không lỗi
                    if (int.TryParse(inputGio, out int hourOnly))
                    {
                        lichTap.GioTap = TimeSpan.FromHours(hourOnly);
                    }
                    else if (TimeSpan.TryParse(inputGio, out TimeSpan parsedTime))
                    {
                        lichTap.GioTap = parsedTime;
                    }
                    else
                    {
                        MessageBox.Show("Giờ tập không hợp lệ! Vui lòng nhập số giờ (VD: 3) hoặc định dạng giờ (VD: 03:00).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    lichTap.TrangThai = cbTrangThai.SelectedItem?.ToString() ?? cbTrangThai.Text ?? "Chưa Tập";
                    lichTap.MaHv = txtMaHV.Text.Trim();
                    lichTap.MaNv = txtMaNV.Text.Trim();

                    if (bll.Update(lichTap))
                    {
                        MessageBox.Show("Cập nhật lịch tập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();

                        isEditing = false;
                        btnSua.Text = "Sửa";
                        txtMaLichTap.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật lịch tập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Ngoại lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichTap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lịch tập để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string maLt = dgvLichTap.SelectedRows[0].Cells["MaLt"].Value.ToString();
                    if (bll.Delete(maLt))
                    {
                        MessageBox.Show("Xóa lịch tập thành công!", "Thành công");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa lịch tập thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtMaLichTap.Clear();
            txtGioTap.Clear();
            txtMaHV.Clear();
            txtMaNV.Clear();
            cbTrangThai.SelectedIndex = 0;
            isEditing = false;
            btnSua.Text = "Sửa";
            txtMaLichTap.ReadOnly = false;
        }
    }
}
