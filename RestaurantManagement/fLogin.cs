using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {

            InitializeComponent();
            //txtUserName.Text = "admin";
            //txtPassWord.Text = "1";
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            if(txtUserName.Text=="" || txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
            }
            else
            {
                Account acc = db.Accounts.FirstOrDefault(p => p.userName == txtUserName.Text);


                if (acc != null)
                {
                    if (txtPassWord.Text == acc.passWord)
                    {
                        fTable f = new fTable(acc.userName, acc.type);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        if (cbRemember.Checked == false)
                        {
                            txtUserName.Text = "";
                            txtPassWord.Text = "";
                        }
                        else
                        {
                            txtUserName.Text = txtUserName.Text;
                            txtPassWord.Text = txtPassWord.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
                        txtPassWord.Text = "";
                        txtUserName.Text = "";
                        txtUserName.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
                }
            }
            
               


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muôn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
