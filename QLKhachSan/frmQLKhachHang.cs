using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmQLKhachHang : Form
    {
        string sql;
        string chuoiketnoi = @"Data Source=DESKTOP-FPUJ5OD\NGUYENNHATMINH;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            //this.tblkhachhangTableAdapter1.Fill(this.quanLyKSDataSet.tblkhachhang);
            //ketnoi = new SqlConnection(chuoiketnoi);
            //hienthi();
        }
    }
}
