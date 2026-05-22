namespace QuanLyGym
{
    partial class FormMain_PT
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuanLyHoiVien = new System.Windows.Forms.Button();
            this.btnChiSoInbody = new System.Windows.Forms.Button();
            this.btnLichTapLuyen = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnQuanLyHoiVien);
            this.panelMenu.Controls.Add(this.btnChiSoInbody);
            this.panelMenu.Controls.Add(this.btnLichTapLuyen);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnLichTapLuyen
            // 
            this.btnLichTapLuyen.Location = new System.Drawing.Point(23, 75);
            this.btnLichTapLuyen.Name = "btnLichTapLuyen";
            this.btnLichTapLuyen.Size = new System.Drawing.Size(149, 23);
            this.btnLichTapLuyen.TabIndex = 0;
            this.btnLichTapLuyen.Text = "Lịch Tập Luyện";
            this.btnLichTapLuyen.UseVisualStyleBackColor = true;
            this.btnLichTapLuyen.Click += new System.EventHandler(this.btnLichTapLuyen_Click);
            // 
            // btnChiSoInbody
            // 
            this.btnChiSoInbody.Location = new System.Drawing.Point(23, 117);
            this.btnChiSoInbody.Name = "btnChiSoInbody";
            this.btnChiSoInbody.Size = new System.Drawing.Size(149, 23);
            this.btnChiSoInbody.TabIndex = 1;
            this.btnChiSoInbody.Text = "Chi Số InBody";
            this.btnChiSoInbody.UseVisualStyleBackColor = true;
            this.btnChiSoInbody.Click += new System.EventHandler(this.btnChiSoInbody_Click);
            // 
            // btnQuanLyHoiVien
            // 
            this.btnQuanLyHoiVien.Location = new System.Drawing.Point(23, 159);
            this.btnQuanLyHoiVien.Name = "btnQuanLyHoiVien";
            this.btnQuanLyHoiVien.Size = new System.Drawing.Size(149, 23);
            this.btnQuanLyHoiVien.TabIndex = 2;
            this.btnQuanLyHoiVien.Text = "Quản Lý Hội Viên";
            this.btnQuanLyHoiVien.UseVisualStyleBackColor = true;
            this.btnQuanLyHoiVien.Click += new System.EventHandler(this.btnQuanLyHoiVien_Click);
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
            // FormMain_PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain_PT";
            this.Text = "Quản Lý Gym - Tài Khoản Huấn Luyện Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_PT_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_PT_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnLichTapLuyen;
        private System.Windows.Forms.Button btnChiSoInbody;
        private System.Windows.Forms.Button btnQuanLyHoiVien;
    }
}
