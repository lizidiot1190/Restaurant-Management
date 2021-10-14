using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class fTable : DevExpress.XtraEditors.XtraForm
    {
        string user;
        int Perminssion;
        public fTable(string username,int type)
        {
            user = username;
            Perminssion = type;
            InitializeComponent();
        }

        void LoadTable()
        {
            RestaurantManagement db = new RestaurantManagement();
            List<CustomerTable> tables = db.CustomerTables.ToList();
            CustomerTable table = new CustomerTable();
            flpTable.Controls.Clear();
            foreach (CustomerTable item in tables)
            {
                Button btn = new Button() { Width = 210, Height = 210 };
                flpTable.Controls.Add(btn);
                btn.Text = item.tableName + Environment.NewLine + item.tableStatus;
                btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Tag = item;
                btn.Click += table_Click;

                switch (item.tableStatus)
                {
                    case "Trống":
                        btn.BackColor = Color.SkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.Orange;
                        break;
                }

            }
        }

        void table_Click(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            int ID = ((sender as Button).Tag as CustomerTable).tableID;
            string tableName = ((sender as Button).Tag as CustomerTable).tableName;
            fBill f = new fBill(ID, tableName, user, Perminssion);
            if (f.ShowDialog() == DialogResult.Yes)
            {
                LoadTable();
            }
            else
            {
                LoadTable();
            }


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (Perminssion == 0)
            {
                fRestaurantManagement f = new fRestaurantManagement();
                this.Hide() ;
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!","Cảnh báo!");
            }

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void fTable_Load(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            Account acc = db.Accounts.AsEnumerable().FirstOrDefault(p => p.userName == user);
            lbDisplayName.Text = acc.displayName;
            LoadTable();
        }

        private void flpTable_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
