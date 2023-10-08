using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHoatDong.BLL;
//using QuanLyHoatDong.DTO;
using System.Data.SqlClient;

namespace QuanLyHoatDong
{
    public partial class FrmLogin : Form
    {
        AccountBLL BLLAccount;
        public string tdn;
        public string ps;
        public string ltk;
        public FrmLogin()
        {
            InitializeComponent();
            BLLAccount = new AccountBLL();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Login(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát Chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        public bool checkInfoAccount()
        {
            if (string.IsNullOrEmpty(txtuserName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (rdSV.Checked == false && rdBTC.Checked == false && rdAD.Checked == false && rdDVQL.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn người dùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tdn = txtuserName.Text;
            string ps = txtPassWord.Text;
            string ltk = "";
            if (rdSV.Checked == true)
            {
                ltk = rdSV.Text;
            }
            else if (rdBTC.Checked == true)
            {
                ltk = rdBTC.Text;
            }
            else if (rdAD.Checked == true)
            {
                ltk = rdAD.Text;
            }
            else
            {
                ltk = rdDVQL.Text;
            }
            if (checkInfoAccount())
            {
                // Thực hiện kiểm tra đăng nhập
                CheckAccount(tdn, ps, ltk);
            }

        }
        public void CheckAccount(string tdn, string ps, string ltk)
        {
            DataTable dt = BLLAccount.getAccount(tdn, ps, ltk);
            if (dt.Rows.Count > 0)
            {
                if (ltk == "Sinh Viên")
                {
                    this.Hide();
                    FrmSinhVien frmSinhVien = new FrmSinhVien();
                    frmSinhVien.tdn = txtuserName.Text;
                    frmSinhVien.ps = txtPassWord.Text;
                    frmSinhVien.ltk = ltk;
                    frmSinhVien.ShowDialog();
                    this.Show();
                }
                else if (ltk == "Ban Tổ Chức")
                {
                    this.Hide();
                    FrmBanToChuc frmBanToChuc = new FrmBanToChuc();
                    frmBanToChuc.tdn = txtuserName.Text;
                    frmBanToChuc.ps = txtPassWord.Text;
                    frmBanToChuc.ltk = ltk;
                    frmBanToChuc.ShowDialog();
                    this.Show();
                }
                else if (ltk == "Admin")
                {
                    this.Hide();
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.tdn = txtuserName.Text;
                    frmAdmin.ps = txtPassWord.Text;
                    frmAdmin.ltk = ltk;
                    frmAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    FrmDonViQuanLy frmDonViQuanLy = new FrmDonViQuanLy();
                    frmDonViQuanLy.tdn = txtuserName.Text;
                    frmDonViQuanLy.ps = txtPassWord.Text;
                    frmDonViQuanLy.ltk = ltk;
                    frmDonViQuanLy.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin và người dùng !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtuserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBTC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdAD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdDVQL_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

   // internal class AccountBLL
 //   {
     /*   internal DataTable getAccount(string tdn, string ps, string ltk)
        {
            throw new NotImplementedException();
        }
     */
   // }
}
   