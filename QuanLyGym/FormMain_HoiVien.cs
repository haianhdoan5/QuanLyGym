using QuanLyGym.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGym
{
    public partial class FormMain_HoiVien : Form
    {
        public FormMain_HoiVien()
        {
            InitializeComponent();
        }

        private void TargetControlToPanel(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnLichTap_Click(object sender, EventArgs e)
        {
            UCLichTapLuyen ucLichTap = new UCLichTapLuyen();
            TargetControlToPanel(ucLichTap);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            UCHopDong ucHopDong = new UCHopDong();
            TargetControlToPanel(ucHopDong);
        }

        private void btnChiSoInbody_Click(object sender, EventArgs e)
        {
            UCChiSoInbody ucChiSo = new UCChiSoInbody();
            TargetControlToPanel(ucChiSo);
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mã Hội Viên: {LuuThongTin.MaHV}\n\nTài khoản: {LuuThongTin.LoaiNguoiDung}", "Thông Tin Cá Nhân");
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_HoiVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_HoiVien_Load(object sender, EventArgs e)
        {

        }
    }
}
