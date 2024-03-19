using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void mnstripQLKH_Click(object sender, EventArgs e)
        {
            frmQLKhachHang qlkh = new frmQLKhachHang();
            this.Hide();
            qlkh.ShowDialog();
            qlkh = null;
            this.Show();
        }

        private void mnitemQLPhong_Click(object sender, EventArgs e)
        {
            frmQLPhong qlp = new frmQLPhong();
            this.Hide();
            qlp.ShowDialog();
            qlp = null;
            this.Show();
        }

        private void mnitemDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong dp = new frmDatPhong();
            this.Hide();
            dp.ShowDialog();
            dp = null;
            this.Show();
        }

        private void mnitemHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            this.Hide();
            hd.ShowDialog();
            hd = null;
            this.Show();
        }

        private void mnitemThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan  tt = new frmThanhToan();
            this.Hide();
            tt.ShowDialog();
            tt = null;
            this.Show();
        }

        private void mnitemDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            this.Hide();
            dk.ShowDialog();
            dk = null;
            this.Show();
        }

        private void mnitemDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Hide();
            dn.ShowDialog();
            dn = null;
            this.Show();
        }

        private void mnitemQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien qlnv = new frmQLNhanVien();
            this.Hide();
            qlnv.ShowDialog();
            qlnv = null;
            this.Show();
        }

        private void mnitemLienHe_Click(object sender, EventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            this.Hide();
            lh.ShowDialog();
            lh = null;
            this.Show();
        }
    }
}
