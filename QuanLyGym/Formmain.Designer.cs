namespace QuanLyGym
{
    partial class Formmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.btnGoiTap = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnHoiVien = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panelMenu.Controls.Add(this.btnKhuyenMai);
            this.panelMenu.Controls.Add(this.btnGoiTap);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnThietBi);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.btnHopDong);
            this.panelMenu.Controls.Add(this.btnHoiVien);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 554);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Location = new System.Drawing.Point(49, 408);
            this.btnKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(159, 48);
            this.btnKhuyenMai.TabIndex = 6;
            this.btnKhuyenMai.Text = "Quản Lý Khuyến Mãi";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(49, 465);
            this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(159, 48);
            this.btnQuanLyTaiKhoan.TabIndex = 7;
            this.btnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnGoiTap
            // 
            this.btnGoiTap.Location = new System.Drawing.Point(49, 353);
            this.btnGoiTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoiTap.Name = "btnGoiTap";
            this.btnGoiTap.Size = new System.Drawing.Size(159, 47);
            this.btnGoiTap.TabIndex = 5;
            this.btnGoiTap.Text = "Quản Lý Gói Tập";
            this.btnGoiTap.UseVisualStyleBackColor = true;
            this.btnGoiTap.Click += new System.EventHandler(this.btnGoiTap_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(49, 296);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(159, 49);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Quản Lý Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.Location = new System.Drawing.Point(49, 239);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(159, 49);
            this.btnThietBi.TabIndex = 3;
            this.btnThietBi.Text = "Quản Lý Thiết Bị";
            this.btnThietBi.UseVisualStyleBackColor = true;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(49, 182);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(159, 49);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(49, 126);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(159, 48);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Quản Lý Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnHoiVien
            // 
            this.btnHoiVien.Location = new System.Drawing.Point(49, 69);
            this.btnHoiVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoiVien.Name = "btnHoiVien";
            this.btnHoiVien.Size = new System.Drawing.Size(159, 49);
            this.btnHoiVien.TabIndex = 0;
            this.btnHoiVien.Text = " Quản Lý Hội Viên";
            this.btnHoiVien.UseVisualStyleBackColor = true;
            this.btnHoiVien.Click += new System.EventHandler(this.btnHoiVien_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(267, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 554);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formmain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Formmain_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnGoiTap;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnHoiVien;
    }
}