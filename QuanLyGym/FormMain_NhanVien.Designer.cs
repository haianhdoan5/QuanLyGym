namespace QuanLyGym
{
    partial class FormMain_NhanVien
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
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnHoiVien = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnThietBi);
            this.panelMenu.Controls.Add(this.btnHopDong);
            this.panelMenu.Controls.Add(this.btnHoiVien);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(23, 265);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(149, 23);
            this.btnQuanLyTaiKhoan.TabIndex = 4;
            this.btnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(23, 219);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(149, 23);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Quản Lý Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.Location = new System.Drawing.Point(23, 168);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(149, 23);
            this.btnThietBi.TabIndex = 2;
            this.btnThietBi.Text = "Quản Lý Thiết Bị";
            this.btnThietBi.UseVisualStyleBackColor = true;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(23, 117);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(149, 23);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Quản Lý Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnHoiVien
            // 
            this.btnHoiVien.Location = new System.Drawing.Point(23, 75);
            this.btnHoiVien.Name = "btnHoiVien";
            this.btnHoiVien.Size = new System.Drawing.Size(149, 23);
            this.btnHoiVien.TabIndex = 0;
            this.btnHoiVien.Text = "Quản Lý Hội Viên";
            this.btnHoiVien.UseVisualStyleBackColor = true;
            this.btnHoiVien.Click += new System.EventHandler(this.btnHoiVien_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 450);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // FormMain_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain_NhanVien";
            this.Text = "Quản Lý Gym - Tài Khoản Nhân Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_NhanVien_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_NhanVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnHoiVien;
    }
}
