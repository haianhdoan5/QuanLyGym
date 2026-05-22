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
    public partial class UCChiSoInbody : UserControl
    {
        private ChiSoInbodyBLL bll = new ChiSoInbodyBLL();
        private bool isEditing = false;
        private string currentMaInbody = "";

        public UCChiSoInbody()
        {
            InitializeComponent();
        }

        private void UCChiSoInbody_Load(object sender, EventArgs e)
        {
            LoadData();
            CheckPermissions();
        }

        private void CheckPermissions()
        {
            // Nếu là hội viên, chỉ xem
            if (LuuThongTin.QuyenHan == "HoiVien")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                pnlThongTin.Visible = false;
                dgvChiSo.ReadOnly = true;
            }
        }

        private void LoadData()
        {
            try
            {
                List<ChiSoInbody> list;

                // Nếu là hội viên, chỉ lấy chi số của họ
                if (LuuThongTin.LoaiNguoiDung == "HoiVien")
                {
                    list = bll.GetByHoiVien(LuuThongTin.MaHV);
                }
                else
                {
                    // Admin/nhân viên lấy tất cả
                    list = bll.GetAll();
                }

                dgvChiSo.DataSource = list;

                // Format columns
                if (dgvChiSo.Columns.Count > 0)
                {
                    dgvChiSo.Columns["MaInbody"].HeaderText = "Mã InBody";
                    dgvChiSo.Columns["CanNang"].HeaderText = "Cân Nặng (kg)";
                    dgvChiSo.Columns["ChieuCao"].HeaderText = "Chiều Cao (cm)";
                    dgvChiSo.Columns["TyLeCo"].HeaderText = "Tỷ Lệ Cơ (%)";
                    dgvChiSo.Columns["TyLeMo"].HeaderText = "Tỷ Lệ Mỡ (%)";
                    dgvChiSo.Columns["MaHv"].HeaderText = "Mã HV";

                    // Hide navigation properties
                    if (dgvChiSo.Columns.Contains("MaHvNavigation"))
                        dgvChiSo.Columns["MaHvNavigation"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaInbody.Text))
            {
                MessageBox.Show("Vui lòng nhập mã InBody");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaHV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hội viên");
                return;
            }

            try
            {
                ChiSoInbody chiSo = new ChiSoInbody
                {
                    MaInbody = txtMaInbody.Text,
                    CanNang = string.IsNullOrWhiteSpace(txtCanNang.Text) ? (double?)null : double.Parse(txtCanNang.Text),
                    ChieuCao = string.IsNullOrWhiteSpace(txtChieuCao.Text) ? (double?)null : double.Parse(txtChieuCao.Text),
                    TyLeCo = string.IsNullOrWhiteSpace(txtTyLeCo.Text) ? (double?)null : double.Parse(txtTyLeCo.Text),
                    TyLeMo = string.IsNullOrWhiteSpace(txtTyLeMo.Text) ? (double?)null : double.Parse(txtTyLeMo.Text),
                    MaHv = txtMaHV.Text
                };

                if (bll.Add(chiSo))
                {
                    MessageBox.Show("Thêm chi số InBody thành công!", "Thành công");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm chi số InBody thất bại");
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
                if (dgvChiSo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một chi số để sửa");
                    return;
                }

                var row = dgvChiSo.SelectedRows[0];
                currentMaInbody = row.Cells["MaInbody"].Value.ToString();
                var chiSo = bll.GetById(currentMaInbody);

                if (chiSo != null)
                {
                    txtMaInbody.Text = chiSo.MaInbody;
                    txtCanNang.Text = chiSo.CanNang?.ToString() ?? "";
                    txtChieuCao.Text = chiSo.ChieuCao?.ToString() ?? "";
                    txtTyLeCo.Text = chiSo.TyLeCo?.ToString() ?? "";
                    txtTyLeMo.Text = chiSo.TyLeMo?.ToString() ?? "";
                    txtMaHV.Text = chiSo.MaHv;

                    isEditing = true;
                    btnSua.Text = "Lưu Sửa";
                    txtMaInbody.ReadOnly = true;
                }
            }
            else
            {
                try
                {
                    var chiSo = bll.GetById(currentMaInbody);
                    chiSo.CanNang = string.IsNullOrWhiteSpace(txtCanNang.Text) ? (double?)null : double.Parse(txtCanNang.Text);
                    chiSo.ChieuCao = string.IsNullOrWhiteSpace(txtChieuCao.Text) ? (double?)null : double.Parse(txtChieuCao.Text);
                    chiSo.TyLeCo = string.IsNullOrWhiteSpace(txtTyLeCo.Text) ? (double?)null : double.Parse(txtTyLeCo.Text);
                    chiSo.TyLeMo = string.IsNullOrWhiteSpace(txtTyLeMo.Text) ? (double?)null : double.Parse(txtTyLeMo.Text);
                    chiSo.MaHv = txtMaHV.Text;

                    if (bll.Update(chiSo))
                    {
                        MessageBox.Show("Cập nhật chi số InBody thành công!", "Thành công");
                        LoadData();
                        ClearForm();
                        isEditing = false;
                        btnSua.Text = "Sửa";
                        txtMaInbody.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chi số InBody thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiSo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chi số để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string maInbody = dgvChiSo.SelectedRows[0].Cells["MaInbody"].Value.ToString();
                    if (bll.Delete(maInbody))
                    {
                        MessageBox.Show("Xóa chi số InBody thành công!", "Thành công");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi số InBody thất bại");
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
            txtMaInbody.Clear();
            txtCanNang.Clear();
            txtChieuCao.Clear();
            txtTyLeCo.Clear();
            txtTyLeMo.Clear();
            txtMaHV.Clear();
            isEditing = false;
            btnSua.Text = "Sửa";
            txtMaInbody.ReadOnly = false;
        }
    }
}
