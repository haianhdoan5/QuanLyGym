using QuanLyGym.UserControls;
using System;
using System.Windows.Forms;

namespace QuanLyGym
{
    public partial class FormMain_PT : Form
    {
        public FormMain_PT()
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

        private void btnLichTapLuyen_Click(object sender, EventArgs e)
        {
            UCLichTapLuyen ucLichTap = new UCLichTapLuyen();
            TargetControlToPanel(ucLichTap);
        }

        private void btnChiSoInbody_Click(object sender, EventArgs e)
        {
            UCChiSoInbody ucChiSo = new UCChiSoInbody();
            TargetControlToPanel(ucChiSo);
        }

        private void btnQuanLyHoiVien_Click(object sender, EventArgs e)
        {
            UCHoiVien ucHoiVien = new UCHoiVien();
            TargetControlToPanel(ucHoiVien);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormMain_PT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_PT_Load(object sender, EventArgs e)
        {
        }
    }
}
