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
    public partial class Formmain : Form
    {
        private string quyenHan = "";
        public Formmain(string quyen)
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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UCNhanVien ucNhanVien = new UCNhanVien();
            TargetControlToPanel(ucNhanVien);
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            UCThietBiGym ucThietBi = new UCThietBiGym();
            TargetControlToPanel(ucThietBi);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnGoiTap_Click(object sender, EventArgs e)
        {
            UCGoiTapGym ucGoiTap = new UCGoiTapGym();
            TargetControlToPanel(ucGoiTap);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Formmain_Load(object sender, EventArgs e)
        {

        }
    }
}
