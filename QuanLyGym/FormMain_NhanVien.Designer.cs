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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 554);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(31, 430);
            this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(199, 52);
            this.btnQuanLyTaiKhoan.TabIndex = 4;
            this.btnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(31, 340);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(199, 52);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Quản Lý Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.Location = new System.Drawing.Point(31, 249);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(199, 52);
            this.btnThietBi.TabIndex = 2;
            this.btnThietBi.Text = "Quản Lý Thiết Bị";
            this.btnThietBi.UseVisualStyleBackColor = false;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.Location = new System.Drawing.Point(31, 160);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(199, 52);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Quản Lý Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnHoiVien
            // 
            this.btnHoiVien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoiVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHoiVien.Location = new System.Drawing.Point(31, 75);
            this.btnHoiVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoiVien.Name = "btnHoiVien";
            this.btnHoiVien.Size = new System.Drawing.Size(199, 52);
            this.btnHoiVien.TabIndex = 0;
            this.btnHoiVien.Text = "Quản Lý Hội Viên";
            this.btnHoiVien.UseVisualStyleBackColor = false;
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
            // FormMain_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain_NhanVien";
            this.Text = "Quản Lý Gym - Tài Khoản Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
