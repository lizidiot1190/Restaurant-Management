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
    public partial class fCount : DevExpress.XtraEditors.XtraForm
    {
        int foodID,tableID, permission;
        string user;
        public fCount(int idF,int idT, string u, int p)
        {
            user = u;
            permission = p;
            foodID = idF;
            tableID = idT;
            InitializeComponent();
           
        }

        private void btnCountOK_Click(object sender, EventArgs e)
        {
                CreateBill(tableID);

        }

        void CreateBill(int tableID)
        {
            RestaurantManagement db = new RestaurantManagement();
            CustomerTable table = db.CustomerTables.AsEnumerable().FirstOrDefault(p => p.tableID == tableID);
            Bill billCheck = db.Bills.AsEnumerable().FirstOrDefault(q => q.CustomerTable.tableID == tableID &&q.billStatus==0);
            if (billCheck!=null)
            {
                BillInfo billUpdate = db.BillInfoes.AsEnumerable().FirstOrDefault(q => q.Bill.CustomerTable.tableID == tableID && q.Bill.billStatus == 0 && q.idFood == foodID);
                if (billUpdate != null)
                {
                    int count = 0;
                    billUpdate.idFood = foodID;
                    count = billUpdate.count;
                    billUpdate.note = txtNote.Text;
                    if ((int.Parse(nmCount.Value.ToString()) + count) > 0)
                    {
                        billUpdate.count = int.Parse(nmCount.Value.ToString()) + count;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.BillInfoes.Remove(billUpdate);
                        db.SaveChanges();
                    }

                }
                else
                {
                    BillInfo billInfo = new BillInfo();
                    int count = 0;
                    billInfo.idBIll = billCheck.billID;
                    billInfo.idFood = foodID;
                    billInfo.note = txtNote.Text;
                    if ((int.Parse(nmCount.Value.ToString()) + count) > 0)
                    {
                        billInfo.count = int.Parse(nmCount.Value.ToString()) + count;
                        db.BillInfoes.Add(billInfo);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Món này chưa tồn tại!", "Thông báo");
                    }

                }
            }
            else
            {
                int check = 0;
                Bill bill = new Bill();
                DateTime currentTime = DateTime.Now;
                bill.checkIn = currentTime;
                bill.checkOut = null;
                bill.idTable = tableID;
                bill.billStatus = 0;   
                bill.discount = 0;
                db.Bills.Add(bill);
                //Create BillInfo
                BillInfo billinfo = new BillInfo();
                billinfo.idBIll = bill.billID;
                billinfo.idFood = foodID;
                billinfo.note = txtNote.Text;
                check = int.Parse(nmCount.Value.ToString());
                if (check <= 0)
                {
                    MessageBox.Show("Món này chưa tồn tại!", "Thông báo");
                }
                else
                {
                    billinfo.count = check;
                    db.BillInfoes.Add(billinfo);
                    table.tableStatus = "Có người";
                    db.SaveChanges();
                }
                
                
                
                
            }
        }

    }
}
