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
        public UCBaoCao()
        {
            InitializeComponent();
        }

        private void UCBaoCao_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void LoadBaoCao()
        {
            try
            {
                lblThongBao.Text = "Chức năng Báo Cáo đang được phát triển";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
