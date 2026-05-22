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
            this.cbThietBi = new System.Windows.Forms.ComboBox();
            this.txtNoiDungBaoCao = new System.Windows.Forms.TextBox();
            this.btnNopBaoCao = new System.Windows.Forms.Button();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTongHoiVien = new System.Windows.Forms.Label();
            this.lblSoBaoCao = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.PictureBox();
            this.pnlAdminButtons = new System.Windows.Forms.Panel();
            this.btnSuaBaoCao = new System.Windows.Forms.Button();
            this.btnXoaBaoCao = new System.Windows.Forms.Button();
            this.pnlNhapBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlAdminButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
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
            this.pnlNhapBaoCao.Location = new System.Drawing.Point(0, 0);
            this.pnlNhapBaoCao.Name = "pnlNhapBaoCao";
            this.pnlNhapBaoCao.Padding = new System.Windows.Forms.Padding(20);
            this.pnlNhapBaoCao.Size = new System.Drawing.Size(800, 600);
            this.pnlNhapBaoCao.TabIndex = 0;
            // 
            // cbThietBi
            // 
            this.cbThietBi.FormattingEnabled = true;
            this.cbThietBi.Location = new System.Drawing.Point(150, 80);
            this.cbThietBi.Name = "cbThietBi";
            this.cbThietBi.Size = new System.Drawing.Size(500, 21);
            this.cbThietBi.TabIndex = 0;
            // 
            // txtNoiDungBaoCao
            // 
            this.txtNoiDungBaoCao.Location = new System.Drawing.Point(150, 130);
            this.txtNoiDungBaoCao.Multiline = true;
            this.txtNoiDungBaoCao.Name = "txtNoiDungBaoCao";
            this.txtNoiDungBaoCao.Size = new System.Drawing.Size(500, 100);
            this.txtNoiDungBaoCao.TabIndex = 1;
            // 
            // btnNopBaoCao
            // 
            this.btnNopBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNopBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNopBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnNopBaoCao.Location = new System.Drawing.Point(150, 330);
            this.btnNopBaoCao.Name = "btnNopBaoCao";
            this.btnNopBaoCao.Size = new System.Drawing.Size(500, 40);
            this.btnNopBaoCao.TabIndex = 2;
            this.btnNopBaoCao.Text = "Nộp Báo Cáo";
            this.btnNopBaoCao.UseVisualStyleBackColor = false;
            this.btnNopBaoCao.Click += new System.EventHandler(this.BtnNopBaoCao_Click);
            // 
            // lblThietBi
            // 
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblThietBi.Location = new System.Drawing.Point(40, 80);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(100, 17);
            this.lblThietBi.TabIndex = 3;
            this.lblThietBi.Text = "Chọn Thiết Bị:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNoiDung.Location = new System.Drawing.Point(40, 130);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(110, 17);
            this.lblNoiDung.TabIndex = 4;
            this.lblNoiDung.Text = "Nội Dung Báo Cáo:";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDonVi.Location = new System.Drawing.Point(40, 250);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(130, 17);
            this.lblDonVi.TabIndex = 5;
            this.lblDonVi.Text = "Đơn Vị Thực Hiện:";
            // 
            // txtDonViThucHien
            // 
            this.txtDonViThucHien.Location = new System.Drawing.Point(150, 250);
            this.txtDonViThucHien.Name = "txtDonViThucHien";
            this.txtDonViThucHien.Size = new System.Drawing.Size(500, 20);
            this.txtDonViThucHien.TabIndex = 6;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(0, 120);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(800, 400);
            this.dgvBaoCao.TabIndex = 1;
            this.dgvBaoCao.Visible = false;
            this.dgvBaoCao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellClick);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.Location = new System.Drawing.Point(20, 20);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(200, 20);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "Doanh Thu Tháng: 0 VNĐ";
            this.lblDoanhThu.Visible = false;
            // 
            // lblTongHoiVien
            // 
            this.lblTongHoiVien.AutoSize = true;
            this.lblTongHoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongHoiVien.Location = new System.Drawing.Point(20, 50);
            this.lblTongHoiVien.Name = "lblTongHoiVien";
            this.lblTongHoiVien.Size = new System.Drawing.Size(150, 20);
            this.lblTongHoiVien.TabIndex = 3;
            this.lblTongHoiVien.Text = "Tổng Hội Viên: 0";
            this.lblTongHoiVien.Visible = false;
            // 
            // lblSoBaoCao
            // 
            this.lblSoBaoCao.AutoSize = true;
            this.lblSoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoBaoCao.Location = new System.Drawing.Point(20, 80);
            this.lblSoBaoCao.Name = "lblSoBaoCao";
            this.lblSoBaoCao.Size = new System.Drawing.Size(140, 20);
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
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(800, 120);
            this.pnlDashboard.TabIndex = 5;
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartDoanhThu.Location = new System.Drawing.Point(500, 120);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Size = new System.Drawing.Size(300, 400);
            this.chartDoanhThu.TabIndex = 6;
            this.chartDoanhThu.TabStop = false;
            this.chartDoanhThu.Visible = false;
            // 
            // pnlAdminButtons
            // 
            this.pnlAdminButtons.Controls.Add(this.btnXoaBaoCao);
            this.pnlAdminButtons.Controls.Add(this.btnSuaBaoCao);
            this.pnlAdminButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdminButtons.Location = new System.Drawing.Point(0, 520);
            this.pnlAdminButtons.Name = "pnlAdminButtons";
            this.pnlAdminButtons.Size = new System.Drawing.Size(800, 80);
            this.pnlAdminButtons.TabIndex = 7;
            this.pnlAdminButtons.Visible = false;
            // 
            // btnSuaBaoCao
            // 
            this.btnSuaBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnSuaBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnSuaBaoCao.Location = new System.Drawing.Point(50, 20);
            this.btnSuaBaoCao.Name = "btnSuaBaoCao";
            this.btnSuaBaoCao.Size = new System.Drawing.Size(150, 40);
            this.btnSuaBaoCao.TabIndex = 0;
            this.btnSuaBaoCao.Text = "Sửa Báo Cáo";
            this.btnSuaBaoCao.UseVisualStyleBackColor = false;
            this.btnSuaBaoCao.Click += new System.EventHandler(this.BtnSuaBaoCao_Click);
            // 
            // btnXoaBaoCao
            // 
            this.btnXoaBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXoaBaoCao.Location = new System.Drawing.Point(250, 20);
            this.btnXoaBaoCao.Name = "btnXoaBaoCao";
            this.btnXoaBaoCao.Size = new System.Drawing.Size(150, 40);
            this.btnXoaBaoCao.TabIndex = 1;
            this.btnXoaBaoCao.Text = "Xóa Báo Cáo";
            this.btnXoaBaoCao.UseVisualStyleBackColor = false;
            this.btnXoaBaoCao.Click += new System.EventHandler(this.BtnXoaBaoCao_Click);
            // 
            // UCBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.pnlAdminButtons);
            this.Controls.Add(this.pnlNhapBaoCao);
            this.Controls.Add(this.pnlDashboard);
            this.Name = "UCBaoCao";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UCBaoCao_Load);
            this.pnlNhapBaoCao.ResumeLayout(false);
            this.pnlNhapBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlAdminButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
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
