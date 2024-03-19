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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection kenoi = new SqlConnection(@"Data Source=DESKTOP-FPUJ5OD\NGUYENNHATMINH;Initial Catalog=QLKhachSan;Integrated Security=True");
            string userName = txt_email.Text;
            string passWord = txt_pass.Text;
            if (userName == null || userName.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passWord == null || passWord.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            kenoi.Open();
            string sql = "Select * From tbluser Where username='" + userName + "' and password='" + passWord + "'";
            SqlCommand thuchien = new SqlCommand(sql, kenoi);
            SqlDataReader docdl = thuchien.ExecuteReader();
            if (docdl.Read())
            {
                MessageBox.Show("Đăng nhập thành công!\nXin chào " + userName, "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTrangChu frmMain = new frmTrangChu();
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            kenoi.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            this.Hide();
            dk.ShowDialog();
            dk = null;
            this.Show();

        }
    }
}
