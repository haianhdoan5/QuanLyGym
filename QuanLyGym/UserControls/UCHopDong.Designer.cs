namespace QuanLyGym.UserControls
{
    partial class UCHopDong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.cbHoiVien = new System.Windows.Forms.ComboBox();
            this.cbGoiTap = new System.Windows.Forms.ComboBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(68, 37);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(216, 22);
            this.txtMaHD.TabIndex = 0;
            this.txtMaHD.Text = "Nhập Mã hợp đồng";
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            this.txtMaHD.Visible = false;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(68, 103);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(216, 22);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.Text = "Nhập nội dung/ghi chú";
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(68, 174);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(216, 22);
            this.txtMaKM.TabIndex = 2;
            this.txtMaKM.Text = "Nhập mã khuyến mãi nếu có";
            this.txtMaKM.TextChanged += new System.EventHandler(this.txtMaKM_TextChanged);
            // 
            // cbHoiVien
            // 
            this.cbHoiVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoiVien.FormattingEnabled = true;
            this.cbHoiVien.Location = new System.Drawing.Point(327, 36);
            this.cbHoiVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHoiVien.Name = "cbHoiVien";
            this.cbHoiVien.Size = new System.Drawing.Size(160, 24);
            this.cbHoiVien.TabIndex = 3;
            this.cbHoiVien.SelectedIndexChanged += new System.EventHandler(this.cbHoiVien_SelectedIndexChanged);
            // 
            // cbGoiTap
            // 
            this.cbGoiTap.FormattingEnabled = true;
            this.cbGoiTap.Location = new System.Drawing.Point(327, 102);
            this.cbGoiTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGoiTap.Name = "cbGoiTap";
            this.cbGoiTap.Size = new System.Drawing.Size(160, 24);
            this.cbGoiTap.TabIndex = 4;
            this.cbGoiTap.SelectedIndexChanged += new System.EventHandler(this.cbGoiTap_SelectedIndexChanged);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(327, 174);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(160, 24);
            this.cbNhanVien.TabIndex = 5;
            this.cbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbNhanVien_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 257);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(327, 335);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(68, 335);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(327, 257);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToOrderColumns = true;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(541, 22);
            this.dgvHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.Size = new System.Drawing.Size(492, 361);
            this.dgvHopDong.TabIndex = 10;
            this.dgvHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellClick);
            this.dgvHopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellContentClick);
            // 
            // UCHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.cbGoiTap);
            this.Controls.Add(this.cbHoiVien);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaHD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCHopDong";
            this.Size = new System.Drawing.Size(1103, 452);
            this.Load += new System.EventHandler(this.UCHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.ComboBox cbHoiVien;
        private System.Windows.Forms.ComboBox cbGoiTap;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvHopDong;
    }
}
