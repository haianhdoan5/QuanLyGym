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
            var taikhoan = tkBLL.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);

            if (taikhoan != null)
            {
                // Lưu thông tin người dùng (QuyenHan, MaNV) vào biến toàn cục tĩnh
                LuuThongTin.MaNV = taikhoan.MaNv;
                LuuThongTin.QuyenHan = taikhoan.QuyenHan;

                // Pass the required 'quyen' argument to the Formmain constructor
                Formmain frm = new Formmain(taikhoan.QuyenHan);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnThoa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
