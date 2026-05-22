namespace QuanLyGym.UserControls
{
    partial class UCBaoCao
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNhapBaoCao = new System.Windows.Forms.Panel();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtDonViThucHien = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.btnNopBaoCao = new System.Windows.Forms.Button();
            this.txtNoiDungBaoCao = new System.Windows.Forms.TextBox();
            this.cbThietBi = new System.Windows.Forms.ComboBox();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTongHoiVien = new System.Windows.Forms.Label();
            this.lblSoBaoCao = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.PictureBox();
            this.pnlAdminButtons = new System.Windows.Forms.Panel();
            this.btnXoaBaoCao = new System.Windows.Forms.Button();
            this.btnSuaBaoCao = new System.Windows.Forms.Button();
            this.pnlNhapBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.pnlAdminButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNhapBaoCao
            // 
            this.pnlNhapBaoCao.Controls.Add(this.lblDonVi);
            this.pnlNhapBaoCao.Controls.Add(this.txtDonViThucHien);
            this.pnlNhapBaoCao.Controls.Add(this.lblNoiDung);
            this.pnlNhapBaoCao.Controls.Add(this.lblThietBi);
            this.pnlNhapBaoCao.Controls.Add(this.btnNopBaoCao);
            this.pnlNhapBaoCao.Controls.Add(this.txtNoiDungBaoCao);
            this.pnlNhapBaoCao.Controls.Add(this.cbThietBi);
            this.pnlNhapBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhapBaoCao.Location = new System.Drawing.Point(0, 148);
            this.pnlNhapBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNhapBaoCao.Name = "pnlNhapBaoCao";
            this.pnlNhapBaoCao.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlNhapBaoCao.Size = new System.Drawing.Size(1067, 590);
            this.pnlNhapBaoCao.TabIndex = 0;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDonVi.Location = new System.Drawing.Point(53, 308);
            this.lblDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(146, 20);
            this.lblDonVi.TabIndex = 5;
            this.lblDonVi.Text = "Đơn Vị Thực Hiện:";
            // 
            // txtDonViThucHien
            // 
            this.txtDonViThucHien.Location = new System.Drawing.Point(200, 308);
            this.txtDonViThucHien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonViThucHien.Name = "txtDonViThucHien";
            this.txtDonViThucHien.Size = new System.Drawing.Size(665, 22);
            this.txtDonViThucHien.TabIndex = 6;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoiDung.Location = new System.Drawing.Point(53, 160);
            this.lblNoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(154, 20);
            this.lblNoiDung.TabIndex = 4;
            this.lblNoiDung.Text = "Nội Dung Báo Cáo:";
            // 
            // lblThietBi
            // 
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblThietBi.Location = new System.Drawing.Point(53, 98);
            this.lblThietBi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(116, 20);
            this.lblThietBi.TabIndex = 3;
            this.lblThietBi.Text = "Chọn Thiết Bị:";
            // 
            // btnNopBaoCao
            // 
            this.btnNopBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNopBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNopBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnNopBaoCao.Location = new System.Drawing.Point(200, 406);
            this.btnNopBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNopBaoCao.Name = "btnNopBaoCao";
            this.btnNopBaoCao.Size = new System.Drawing.Size(667, 49);
            this.btnNopBaoCao.TabIndex = 2;
            this.btnNopBaoCao.Text = "Nộp Báo Cáo";
            this.btnNopBaoCao.UseVisualStyleBackColor = false;
            this.btnNopBaoCao.Click += new System.EventHandler(this.BtnNopBaoCao_Click);
            // 
            // txtNoiDungBaoCao
            // 
            this.txtNoiDungBaoCao.Location = new System.Drawing.Point(200, 160);
            this.txtNoiDungBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDungBaoCao.Multiline = true;
            this.txtNoiDungBaoCao.Name = "txtNoiDungBaoCao";
            this.txtNoiDungBaoCao.Size = new System.Drawing.Size(665, 122);
            this.txtNoiDungBaoCao.TabIndex = 1;
            // 
            // cbThietBi
            // 
            this.cbThietBi.FormattingEnabled = true;
            this.cbThietBi.Location = new System.Drawing.Point(200, 98);
            this.cbThietBi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbThietBi.Name = "cbThietBi";
            this.cbThietBi.Size = new System.Drawing.Size(665, 24);
            this.cbThietBi.TabIndex = 0;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(0, 148);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.Size = new System.Drawing.Size(1067, 492);
            this.dgvBaoCao.TabIndex = 1;
            this.dgvBaoCao.Visible = false;
            this.dgvBaoCao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellClick);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.Location = new System.Drawing.Point(27, 25);
            this.lblDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(263, 25);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "Doanh Thu Tháng: 0 VNĐ";
            this.lblDoanhThu.Visible = false;
            // 
            // lblTongHoiVien
            // 
            this.lblTongHoiVien.AutoSize = true;
            this.lblTongHoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongHoiVien.Location = new System.Drawing.Point(27, 62);
            this.lblTongHoiVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongHoiVien.Name = "lblTongHoiVien";
            this.lblTongHoiVien.Size = new System.Drawing.Size(175, 25);
            this.lblTongHoiVien.TabIndex = 3;
            this.lblTongHoiVien.Text = "Tổng Hội Viên: 0";
            this.lblTongHoiVien.Visible = false;
            // 
            // lblSoBaoCao
            // 
            this.lblSoBaoCao.AutoSize = true;
            this.lblSoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoBaoCao.Location = new System.Drawing.Point(27, 98);
            this.lblSoBaoCao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoBaoCao.Name = "lblSoBaoCao";
            this.lblSoBaoCao.Size = new System.Drawing.Size(189, 25);
            this.lblSoBaoCao.TabIndex = 4;
            this.lblSoBaoCao.Text = "Báo Cáo Tháng: 0";
            this.lblSoBaoCao.Visible = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblSoBaoCao);
            this.pnlDashboard.Controls.Add(this.lblTongHoiVien);
            this.pnlDashboard.Controls.Add(this.lblDoanhThu);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1067, 148);
            this.pnlDashboard.TabIndex = 5;
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartDoanhThu.Location = new System.Drawing.Point(667, 148);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Size = new System.Drawing.Size(400, 492);
            this.chartDoanhThu.TabIndex = 6;
            this.chartDoanhThu.TabStop = false;
            this.chartDoanhThu.Visible = false;
            // 
            // pnlAdminButtons
            // 
            this.pnlAdminButtons.Controls.Add(this.btnXoaBaoCao);
            this.pnlAdminButtons.Controls.Add(this.btnSuaBaoCao);
            this.pnlAdminButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdminButtons.Location = new System.Drawing.Point(0, 640);
            this.pnlAdminButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdminButtons.Name = "pnlAdminButtons";
            this.pnlAdminButtons.Size = new System.Drawing.Size(1067, 98);
            this.pnlAdminButtons.TabIndex = 7;
            this.pnlAdminButtons.Visible = false;
            // 
            // btnXoaBaoCao
            // 
            this.btnXoaBaoCao.BackColor = System.Drawing.Color.White;
            this.btnXoaBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnXoaBaoCao.Location = new System.Drawing.Point(333, 25);
            this.btnXoaBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaBaoCao.Name = "btnXoaBaoCao";
            this.btnXoaBaoCao.Size = new System.Drawing.Size(200, 49);
            this.btnXoaBaoCao.TabIndex = 1;
            this.btnXoaBaoCao.Text = "Xóa Báo Cáo";
            this.btnXoaBaoCao.UseVisualStyleBackColor = false;
            this.btnXoaBaoCao.Click += new System.EventHandler(this.BtnXoaBaoCao_Click);
            // 
            // btnSuaBaoCao
            // 
            this.btnSuaBaoCao.BackColor = System.Drawing.Color.White;
            this.btnSuaBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnSuaBaoCao.Location = new System.Drawing.Point(67, 25);
            this.btnSuaBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaBaoCao.Name = "btnSuaBaoCao";
            this.btnSuaBaoCao.Size = new System.Drawing.Size(200, 49);
            this.btnSuaBaoCao.TabIndex = 0;
            this.btnSuaBaoCao.Text = "Sửa Báo Cáo";
            this.btnSuaBaoCao.UseVisualStyleBackColor = false;
            this.btnSuaBaoCao.Click += new System.EventHandler(this.BtnSuaBaoCao_Click);
            // 
            // UCBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.pnlAdminButtons);
            this.Controls.Add(this.pnlNhapBaoCao);
            this.Controls.Add(this.pnlDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCBaoCao";
            this.Size = new System.Drawing.Size(1067, 738);
            this.Load += new System.EventHandler(this.UCBaoCao_Load);
            this.pnlNhapBaoCao.ResumeLayout(false);
            this.pnlNhapBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.pnlAdminButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhapBaoCao;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.Button btnNopBaoCao;
        private System.Windows.Forms.TextBox txtNoiDungBaoCao;
        private System.Windows.Forms.ComboBox cbThietBi;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblTongHoiVien;
        private System.Windows.Forms.Label lblSoBaoCao;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox chartDoanhThu;
        private System.Windows.Forms.Panel pnlAdminButtons;
        private System.Windows.Forms.Button btnSuaBaoCao;
        private System.Windows.Forms.Button btnXoaBaoCao;
        private System.Windows.Forms.TextBox txtDonViThucHien;
        private System.Windows.Forms.Label lblDonVi;
    }
}
