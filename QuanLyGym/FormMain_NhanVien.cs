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
    public partial class FormMain_NhanVien : Form
    {
        public FormMain_NhanVien()
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

        private void btnHoiVien_Click(object sender, EventArgs e)
        {
            UCHoiVien uc = new UCHoiVien();
            TargetControlToPanel(uc);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            UCHopDong ucHopDong = new UCHopDong();
            TargetControlToPanel(ucHopDong);
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            UCThietBiGym ucThietBi = new UCThietBiGym();
            TargetControlToPanel(ucThietBi);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            UCBaoCao ucBaoCao = new UCBaoCao(LuuThongTin.QuyenHan);
            TargetControlToPanel(ucBaoCao);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
