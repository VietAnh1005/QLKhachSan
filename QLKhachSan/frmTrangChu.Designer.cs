namespace QLKhachSan
{
    partial class frmTrangChu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnstripQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstripQLKH,
            this.mnstripDichVu,
            this.mnstripHeThong,
            this.mnstripTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnstripQLKH
            // 
            this.mnstripQLKH.Name = "mnstripQLKH";
            this.mnstripQLKH.Size = new System.Drawing.Size(237, 31);
            this.mnstripQLKH.Text = "Quản Lý Khách Hàng";
            this.mnstripQLKH.Click += new System.EventHandler(this.mnstripQLKH_Click);
            // 
            // mnstripDichVu
            // 
            this.mnstripDichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemQLPhong,
            this.mnitemDatPhong,
            this.mnitemHoaDon,
            this.mnitemThanhToan});
            this.mnstripDichVu.Name = "mnstripDichVu";
            this.mnstripDichVu.Size = new System.Drawing.Size(106, 31);
            this.mnstripDichVu.Text = "Dịch Vụ";
            // 
            // mnitemQLPhong
            // 
            this.mnitemQLPhong.Name = "mnitemQLPhong";
            this.mnitemQLPhong.Size = new System.Drawing.Size(250, 32);
            this.mnitemQLPhong.Text = "Quản Lý Phòng";
            this.mnitemQLPhong.Click += new System.EventHandler(this.mnitemQLPhong_Click);
            // 
            // mnitemDatPhong
            // 
            this.mnitemDatPhong.Name = "mnitemDatPhong";
            this.mnitemDatPhong.Size = new System.Drawing.Size(250, 32);
            this.mnitemDatPhong.Text = "Đặt Phòng";
            this.mnitemDatPhong.Click += new System.EventHandler(this.mnitemDatPhong_Click);
            // 
            // mnitemHoaDon
            // 
            this.mnitemHoaDon.Name = "mnitemHoaDon";
            this.mnitemHoaDon.Size = new System.Drawing.Size(250, 32);
            this.mnitemHoaDon.Text = "Hóa Đơn";
            this.mnitemHoaDon.Click += new System.EventHandler(this.mnitemHoaDon_Click);
            // 
            // mnitemThanhToan
            // 
            this.mnitemThanhToan.Name = "mnitemThanhToan";
            this.mnitemThanhToan.Size = new System.Drawing.Size(250, 32);
            this.mnitemThanhToan.Text = "Thanh Toán";
            this.mnitemThanhToan.Click += new System.EventHandler(this.mnitemThanhToan_Click);
            // 
            // mnstripHeThong
            // 
            this.mnstripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemDangKy,
            this.mnitemDangNhap,
            this.mnitemQLNhanVien});
            this.mnstripHeThong.Name = "mnstripHeThong";
            this.mnstripHeThong.Size = new System.Drawing.Size(121, 31);
            this.mnstripHeThong.Text = "Hệ Thống";
            // 
            // mnitemDangKy
            // 
            this.mnitemDangKy.Name = "mnitemDangKy";
            this.mnitemDangKy.Size = new System.Drawing.Size(291, 32);
            this.mnitemDangKy.Text = "Đăng Ký";
            this.mnitemDangKy.Click += new System.EventHandler(this.mnitemDangKy_Click);
            // 
            // mnitemDangNhap
            // 
            this.mnitemDangNhap.Name = "mnitemDangNhap";
            this.mnitemDangNhap.Size = new System.Drawing.Size(291, 32);
            this.mnitemDangNhap.Text = "Đăng Nhập";
            this.mnitemDangNhap.Click += new System.EventHandler(this.mnitemDangNhap_Click);
            // 
            // mnitemQLNhanVien
            // 
            this.mnitemQLNhanVien.Name = "mnitemQLNhanVien";
            this.mnitemQLNhanVien.Size = new System.Drawing.Size(291, 32);
            this.mnitemQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnitemQLNhanVien.Click += new System.EventHandler(this.mnitemQLNhanVien_Click);
            // 
            // mnstripTroGiup
            // 
            this.mnstripTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemLienHe});
            this.mnstripTroGiup.Name = "mnstripTroGiup";
            this.mnstripTroGiup.Size = new System.Drawing.Size(113, 31);
            this.mnstripTroGiup.Text = "Trợ Giúp";
            // 
            // mnitemLienHe
            // 
            this.mnitemLienHe.Name = "mnitemLienHe";
            this.mnitemLienHe.Size = new System.Drawing.Size(224, 32);
            this.mnitemLienHe.Text = "Liên Hệ";
            this.mnitemLienHe.Click += new System.EventHandler(this.mnitemLienHe_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(858, 90);
            this.label1.TabIndex = 29;
            this.label1.Text = "MAY SAIGON HOTEL";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKhachSan.Properties.Resources.Baotou_Marriott_Hotel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnstripQLKH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnstripDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnstripHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnstripTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnitemQLPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemDatPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnitemDangKy;
        private System.Windows.Forms.ToolStripMenuItem mnitemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnitemQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnitemLienHe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnitemThanhToan;
    }
}