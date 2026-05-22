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

namespace QuanLyGym
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();



        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Cố gắng đăng nhập như nhân viên trước
            var taikhoan = tkBLL.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);

            if (taikhoan != null && !string.IsNullOrEmpty(taikhoan.MaNv))
            {
                // Đăng nhập thành công như nhân viên
                LuuThongTin.MaNV = taikhoan.MaNv;
                LuuThongTin.MaHV = taikhoan.MaHv;
                LuuThongTin.QuyenHan = taikhoan.QuyenHan;
                

                // Phân loại nhân viên: PT, Nhân viên, Admin
                if (taikhoan.QuyenHan != null && (taikhoan.QuyenHan.Contains("PT") || taikhoan.QuyenHan.Contains("PersonalTrainer") || taikhoan.QuyenHan.Contains("Huấn Luyện")))
                {
                    // Mở form dành cho PT
                    FormMain_PT frm = new FormMain_PT();
                    frm.Show();
                    
                }
                else if (taikhoan.QuyenHan != null && (taikhoan.QuyenHan.Contains("Nhân Viên") || taikhoan.QuyenHan.Contains("NhanVien") || taikhoan.QuyenHan.ToLower().Contains("staff")))
                {
                    // Mở form dành cho nhân viên
                    FormMain_NhanVien frm = new FormMain_NhanVien();
                    frm.Show();
                }
                else
                {
                    // Mở form dành cho quản lý
                    Formmain frm = new Formmain(taikhoan.QuyenHan);
                    frm.Show();
                }
                this.Hide();
            }
            else
            {
                // Nếu không phải nhân viên, thử đăng nhập như hội viên
                var taikkhoanHoiVien = tkBLL.KiemTraDangNhapHoiVien(txtTaiKhoan.Text, txtMatKhau.Text);

                if (taikkhoanHoiVien != null)
                {
                    // Đăng nhập thành công như hội viên
                    LuuThongTin.MaNV = null;
                    LuuThongTin.MaHV = taikkhoanHoiVien.MaHv;
                    LuuThongTin.QuyenHan = "HoiVien";
                    

                    // Mở form dành cho hội viên
                    FormMain_HoiVien frm = new FormMain_HoiVien();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void btnThoa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
