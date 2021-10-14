using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class fBill : DevExpress.XtraEditors.XtraForm
    {
        double Price;
        int tableID, permission;
        string tableName, user;
        CultureInfo cultureInfo = new CultureInfo("vi-VN");
        public fBill(int ID, string Name, string u, int p)
        {
            RestaurantManagement db = new RestaurantManagement();
            List<CustomerTable> tables = db.CustomerTables.ToList();
            user = u;
            permission = p;
            tableID = ID;
            tableName = Name;
            InitializeComponent();
            LoadFoodList();
            FillCbChooseTable(tables);
        }

        void LoadFoodList()
        {
            RestaurantManagement db = new RestaurantManagement();
            List<Food> foods = db.Foods.OrderBy(p => p.catID).ToList();
            foreach (Food item in foods)
            {
                Button btn = new Button() { Width = 90, Height = 90 };
                flpFood.Controls.Add(btn);
                btn.Text = item.foodName + Environment.NewLine + Environment.NewLine + item.foodPrice;
                btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Click += food_Click;
                btn.Tag = item;
                switch (item.catID)
                {
                    case 1:
                        btn.BackColor = Color.BlueViolet;
                        break;
                    case 2:
                        btn.BackColor = Color.Transparent;
                        break;
                    case 3:
                        btn.BackColor = Color.Azure;
                        break;
                    case 4:
                        btn.BackColor = Color.DarkGray;
                        break;
                    case 5:
                        btn.BackColor = Color.Crimson;
                        break;
                    case 6:
                        btn.BackColor = Color.DarkOrange;
                        break;
                    case 7:
                        btn.BackColor = Color.Ivory;
                        break;
                    case 8:
                        btn.BackColor = Color.LightSeaGreen;
                        break;
                    case 9:
                        btn.BackColor = Color.MistyRose;
                        break;
                    case 10:
                        btn.BackColor = Color.SpringGreen;
                        break;
                }
            }

        }

        void food_Click(object sender, EventArgs e)
        {
            int foodID = ((sender as Button).Tag as Food).foodID;
            fCount fcount = new fCount(foodID, tableID, user, permission);
            if (fcount.ShowDialog() == DialogResult.OK)
            {
                RestaurantManagement db = new RestaurantManagement();
                List<BillInfo> billInfos = db.BillInfoes.ToList();
                Bill bill = db.Bills.AsEnumerable().FirstOrDefault(p => p.CustomerTable.tableID == tableID && p.billStatus == 0);
                if (bill != null)
                {
                    lbCheckin.Text = bill.checkIn.ToString("hh:mm:ss");
                }

                FillListBill(billInfos);
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int discount;
            RestaurantManagement db = new RestaurantManagement();
            CustomerTable table = db.CustomerTables.AsEnumerable().FirstOrDefault(s => s.tableID == tableID);
            Bill bill = db.Bills.AsEnumerable().FirstOrDefault(p => p.CustomerTable.tableID == tableID && p.billStatus == 0);
            DateTime currentTime = DateTime.Now;
            if (cbDiscount.Text == "")
            {
                discount = 0;
            }
            else
            {
                discount = int.Parse(cbDiscount.Text);
            }
            if (bill != null)
            {
                if (MessageBox.Show(string.Format("Bạn muốn thanh toán hóa đơn này với giảm giá là {0}%. Tổng bill là :  {1}?", discount, Price.ToString("c", cultureInfo)), "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    BillInfo billInfo = db.BillInfoes.AsEnumerable().FirstOrDefault(p => p.Bill.CustomerTable.tableID == tableID && p.Bill.billStatus == 0);
                    if (billInfo != null && Price == 0)
                    {
                        db.BillInfoes.Remove(billInfo);
                        db.Bills.Remove(bill);
                        table.tableStatus = "Trống";
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {

                        bill.checkOut = currentTime;
                        bill.billStatus = 1;
                        bill.discount = discount;
                        table.tableStatus = "Trống";
                        fReceipt f = new fReceipt(tableID, bill.billID, user);
                        db.SaveChanges();
                        f.ShowDialog();
                        this.Hide();

                    }

                }
                else
                {

                    table.tableStatus = "Có người";
                    db.SaveChanges();
                }

            }
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            lbTableName.Text = tableName;
            RestaurantManagement db = new RestaurantManagement();
            List<BillInfo> billInfos = db.BillInfoes.ToList();
            Bill bill = db.Bills.AsEnumerable().FirstOrDefault(p => p.CustomerTable.tableID == tableID && p.billStatus == 0);
            if (bill != null)
            {
                lbCheckin.Text = bill.checkIn.ToString("hh:mm:ss");
                cbDiscount.Text = bill.discount.ToString();
            }
            else
            {
                lbCheckin.Text = "00:00:00";
            }
            FillListBill(billInfos);
        }

        public void FillListBill(List<BillInfo> billInfos)
        {
            RestaurantManagement db = new RestaurantManagement();
            var items = billInfos.Where(p => p.Bill.CustomerTable.tableID == tableID)
                .Where(p => p.Bill.billStatus == 0);
            double totalPrice = 0;
            dgvBill.Rows.Clear();
            foreach (var item in items)
            {
                int index = dgvBill.Rows.Add();
                dgvBill.Rows[index].Cells[0].Value = item.Food.foodName;
                dgvBill.Rows[index].Cells[1].Value = item.count;
                dgvBill.Rows[index].Cells[2].Value = item.Food.foodPrice;
                double TotalPrice = item.count * int.Parse(item.Food.foodPrice);
                dgvBill.Rows[index].Cells[3].Value = TotalPrice;
                totalPrice += TotalPrice;
                Price = totalPrice - (totalPrice * item.Bill.discount) / 100;
                dgvBill.Rows[index].Cells[4].Value = item.note;
            }

            txtTotalPrice.Text = Price.ToString("c", cultureInfo);



        }

        private void btnChooseTable_Click(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            Bill bill = db.Bills.AsEnumerable().FirstOrDefault(p => p.idTable == tableID && p.billStatus == 0);
            if (bill != null)
            {
                if (MessageBox.Show(String.Format("Bạn có muốn chuyển từ bàn {0} sang bàn {1}", bill.CustomerTable.tableName, cbChooseTable.Text), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CustomerTable newTable = db.CustomerTables.AsEnumerable().FirstOrDefault(a => a.tableName == cbChooseTable.Text);
                    if (newTable.tableStatus == "Có người")
                    {
                        MessageBox.Show(String.Format("{0} đã có người! Không thể chuyển bàn!", cbChooseTable.Text), "Thông báo");
                    }
                    else
                    {
                        CustomerTable oldTable = db.CustomerTables.AsEnumerable().FirstOrDefault(b => b.tableName == bill.CustomerTable.tableName);
                        bill.idTable = int.Parse(cbChooseTable.SelectedValue.ToString());
                        newTable.tableStatus = "Có người";
                        oldTable.tableStatus = "Trống";
                        db.SaveChanges();
                        this.Close();

                    }

                }

            }
            else
            {
                MessageBox.Show("Không thể chuyển bàn!Bàn này hiện đang trống!", "Thông báo");
            }

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                int discount;
                if (cbDiscount.Text == "")
                {
                    discount = 0;
                }

                if (int.Parse(cbDiscount.Text) < 0|| int.Parse(cbDiscount.Text)>100)
                {
                    MessageBox.Show("Không thể nhập nhỏ hơn 0");
                }
                else
                {
                    discount = int.Parse(cbDiscount.Text);
                    RestaurantManagement db = new RestaurantManagement();
                    Bill bill = db.Bills.AsEnumerable().FirstOrDefault(p => p.idTable == tableID && p.billStatus == 0);
                    if (bill != null)
                    {
                        bill.idTable = bill.idTable;// cai code gi day ta? gio doc lai khong hieu noi~ @
                        bill.checkIn = bill.checkIn;
                        bill.checkOut = bill.checkOut;
                        bill.billStatus = bill.billStatus;
                        bill.discount = discount;
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Bàn chưa có hóa đơn không thể giảm giá!");
                    }


                    List<BillInfo> billInfos = db.BillInfoes.ToList();
                    FillListBill(billInfos);
                    txtTotalPrice.Text = Price.ToString("c", cultureInfo);
                }


            }
            catch
            {
                MessageBox.Show("Mục này chỉ được nhập số!");
            }

        }

        public void FillCbChooseTable(List<CustomerTable> tables)
        {
            this.cbChooseTable.DataSource = tables;
            this.cbChooseTable.DisplayMember = "tableName";
            this.cbChooseTable.ValueMember = "tableID";
        }

    }
}


