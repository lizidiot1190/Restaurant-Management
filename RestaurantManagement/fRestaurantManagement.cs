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
    public partial class fRestaurantManagement : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        public fRestaurantManagement()
        {
            InitializeComponent();
            RestaurantManagement db = new RestaurantManagement();
            List<Food> foods = db.Foods.OrderBy(p => p.catID).ToList();
            List<CustomerTable> tables = db.CustomerTables.ToList();
            List<FoodCategory> categories = db.FoodCategories.ToList();
            List<Account> accounts = db.Accounts.ToList();
            List<Staff> staffs = db.Staffs.ToList();
            List<Bill> bills = db.Bills.ToList();

            FillFoodDGV(foods);
            FillTableDGV(tables);
            FillFoodCategoryDGV(categories);
            FillAccountDGV(accounts);
            FillStaffDGV(staffs);
            FillFoodCategoryComboBox(categories);
            LoadDateTimePicker();
            FillRevenueDGV(bills);

        }
        //Tab Revenue--------------------------------------------------------
        private void LoadDateTimePicker()
        {
            DateTime currentTime = DateTime.Now;
            dtpFrom.Value = new DateTime(currentTime.Year, currentTime.Month, 1);
            dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
        }
        private void FillRevenueDGV(List<Bill> bills)
        {
            dgvRevenue.Rows.Clear();
            RestaurantManagement db = new RestaurantManagement();
            var bill = bills.Where(p => p.checkIn >= dtpFrom.Value && p.checkOut <= dtpTo.Value);
            List<BillInfo> billInfos = db.BillInfoes.ToList();
            double totalRevenue = 0;
            foreach (var items in bill)
            {
                double Total = 0;
                double TotalRevenue = 0;
                var info = billInfos.Where(p => p.idBIll == items.billID);
                foreach (var i in info)
                {
                    double totalPrice = i.count * double.Parse(i.Food.foodPrice);
                    Total += totalPrice;
                }
                int index = dgvRevenue.Rows.Add();
                dgvRevenue.Rows[index].Cells[0].Value = items.CustomerTable.tableName;
                dgvRevenue.Rows[index].Cells[1].Value = items.checkIn;
                dgvRevenue.Rows[index].Cells[2].Value = items.checkOut;
                dgvRevenue.Rows[index].Cells[3].Value = items.discount;
                TotalRevenue = Total - ((Total * items.discount) / 100);
                totalRevenue += TotalRevenue;
                dgvRevenue.Rows[index].Cells[4].Value = TotalRevenue.ToString("c", culture);

            }
            txtTotalRevenue.Text = totalRevenue.ToString("c", culture);
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            List<Bill> bills = db.Bills.ToList();
            FillRevenueDGV(bills);
        }

        //Tab Food-----------------------------------------------------------
        private void FillFoodDGV(List<Food> foods)
        {
            dgvFood.Rows.Clear();
            foreach (var items in foods)
            {
                int index = dgvFood.Rows.Add();
                dgvFood.Rows[index].Cells[0].Value = items.foodID;
                dgvFood.Rows[index].Cells[1].Value = items.foodName;
                dgvFood.Rows[index].Cells[2].Value = items.FoodCategory.categoryName;
                dgvFood.Rows[index].Cells[3].Value = items.foodPrice;
            }
        }

        private void FillFoodCategoryComboBox(List<FoodCategory> categories)
        {
            this.cbFoodCategory.DataSource = categories;
            this.cbFoodCategory.DisplayMember = "categoryName";
            this.cbFoodCategory.ValueMember = "categoryID";

        }
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFood.Rows[e.RowIndex];
                txtFoodID.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                cbFoodCategory.Text = row.Cells[2].Value.ToString();
                txtFoodPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFoodName.Text=="" || txtFoodPrice.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên món và giá tiền!");
                }
                else
                {
                    RestaurantManagement db = new RestaurantManagement();
                    Food food = new Food();
                    FoodCategory cat = db.FoodCategories.FirstOrDefault(p => p.categoryName == cbFoodCategory.Text);
                    food.foodName = txtFoodName.Text;
                    food.catID = cat.categoryID;
                    if (int.Parse(txtFoodPrice.Text) > 0)
                    {
                        food.foodPrice = txtFoodPrice.Text;
                        InsertFood(food);

                    }
                    else
                    {
                        MessageBox.Show("Giá món không thể nhỏ hơn 0!", "Thông báo");
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!");
            }
            

        }

        public void InsertFood(Food food)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                db.Foods.Add(food);
                db.SaveChanges();

                RestaurantManagement db1 = new RestaurantManagement();
                List<Food> foods = db1.Foods.OrderBy(p => p.catID).ToList();
                FillFoodDGV(foods);

            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }


        private void btnModifyFood_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                Food foodUpdate = db.Foods.AsEnumerable().FirstOrDefault(p => p.foodID == int.Parse(txtFoodID.Text));
                FoodCategory cat = db.FoodCategories.FirstOrDefault(p => p.categoryName == cbFoodCategory.Text);
                if (foodUpdate != null)
                {
                    foodUpdate.foodName = txtFoodName.Text;
                    foodUpdate.catID = cat.categoryID;
                    if (int.Parse(txtFoodPrice.Text) > 0)
                    {
                        foodUpdate.foodPrice = txtFoodPrice.Text;
                        db.SaveChanges();
                        List<Food> foods = db.Foods.ToList();
                        FillFoodDGV(foods);
                    }
                    else
                    {
                        MessageBox.Show("Giá món không thể nhỏ hơn 0!", "Thông báo");
                    }

                }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                Food foodDelete = db.Foods.AsEnumerable().FirstOrDefault(p => p.foodID == int.Parse(txtFoodID.Text));
                if (foodDelete != null)
                {
                    db.Foods.Remove(foodDelete);
                }
                db.SaveChanges();
                List<Food> foods = db.Foods.ToList();
                FillFoodDGV(foods);
            }
            catch (Exception)
            {
                MessageBox.Show("Một hoặc một số bàn đang có món ăn hiện tại nên không thể xóa món ăn!");
            }
        }


        //Tab Table-----------------------------------------------------------
        private void FillTableDGV(List<CustomerTable> tables)
        {
            dgvTable.Rows.Clear();
            foreach (var items in tables)
            {
                int index = dgvTable.Rows.Add();
                dgvTable.Rows[index].Cells[0].Value = items.tableID;
                dgvTable.Rows[index].Cells[1].Value = items.tableName;
                dgvTable.Rows[index].Cells[2].Value = items.tableStatus;
            }
        }


        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTable.Rows[e.RowIndex];
                txtTableID.Text = row.Cells[0].Value.ToString();
                txtTableName.Text = row.Cells[1].Value.ToString();
                txtTableStatus.Text = row.Cells[2].Value.ToString();
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {

            CustomerTable table = new CustomerTable();
            table.tableName = txtTableName.Text;
            table.tableStatus = txtTableStatus.Text;
            InsertTable(table);
        }

        public void InsertTable(CustomerTable table)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                db.CustomerTables.Add(table);
                db.SaveChanges();
                List<CustomerTable> tables = db.CustomerTables.ToList();
                FillTableDGV(tables);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnModifyTable_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                CustomerTable tableUpdate = db.CustomerTables.AsEnumerable().FirstOrDefault(p => p.tableID == int.Parse(txtTableID.Text));
                if (tableUpdate != null)
                {
                    tableUpdate.tableName = txtTableName.Text;
                    tableUpdate.tableStatus = txtTableStatus.Text;
                }
                db.SaveChanges();
                List<CustomerTable> tables = db.CustomerTables.ToList();
                FillTableDGV(tables);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                CustomerTable tableDelete = db.CustomerTables.AsEnumerable().FirstOrDefault(p => p.tableID == int.Parse(txtTableID.Text));
                if (tableDelete != null)
                {
                    db.CustomerTables.Remove(tableDelete);

                }
                db.SaveChanges();
                List<CustomerTable> tables = db.CustomerTables.ToList();
                FillTableDGV(tables);
            }
            catch (Exception)
            {
                MessageBox.Show("Bàn đang được sử dụng! Không thể xóa!");
            }

        }
        //Tab Category---------------------------------------------------------
        private void FillFoodCategoryDGV(List<FoodCategory> categories)
        {
            dgvCategory.Rows.Clear();
            foreach (var items in categories)
            {
                int index = dgvCategory.Rows.Add();
                dgvCategory.Rows[index].Cells[0].Value = items.categoryID;
                dgvCategory.Rows[index].Cells[1].Value = items.categoryName;
            }


        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                txtCategoryID.Text = row.Cells[0].Value.ToString();
                txtCategoryName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                FoodCategory category = new FoodCategory();
                category.categoryName = txtCategoryName.Text;
                db.FoodCategories.Add(category);
                db.SaveChanges();
                List<FoodCategory> categories = db.FoodCategories.ToList();
                FillFoodCategoryDGV(categories);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                FoodCategory catUpdate = db.FoodCategories.AsEnumerable().FirstOrDefault(p => p.categoryID == int.Parse(txtCategoryID.Text));
                if (catUpdate != null)
                {
                    catUpdate.categoryName = txtCategoryName.Text;
                }
                db.SaveChanges();
                List<FoodCategory> categories = db.FoodCategories.ToList();
                FillFoodCategoryDGV(categories);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }
        private void btnDeleCategory_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                FoodCategory catDelete = db.FoodCategories.AsEnumerable().FirstOrDefault(p => p.categoryID == int.Parse(txtCategoryID.Text));
                if (catDelete != null)
                {
                    db.FoodCategories.Remove(catDelete);
                }
                db.SaveChanges();
                List<FoodCategory> categories = db.FoodCategories.ToList();
                FillFoodCategoryDGV(categories);
            }
            catch (Exception)
            {
                MessageBox.Show("Trong danh mục đang có món!Không thể xóa danh mục!");
            }
        }


        //Tab Account-------------------------------------------------------------
        private void FillAccountDGV(List<Account> accounts)
        {
            dgvAccount.Rows.Clear();
            foreach (var items in accounts)
            {
                int index = dgvAccount.Rows.Add();
                dgvAccount.Rows[index].Cells[0].Value = items.accountID;
                dgvAccount.Rows[index].Cells[1].Value = items.userName;
                dgvAccount.Rows[index].Cells[2].Value = items.displayName;
                dgvAccount.Rows[index].Cells[3].Value = items.passWord;
                dgvAccount.Rows[index].Cells[4].Value = items.type;
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAccount.Rows[e.RowIndex];
                txtAccountID.Text = row.Cells[0].Value.ToString();
                txtAccountUserName.Text = row.Cells[1].Value.ToString();
                txtAccountDisplayName.Text = row.Cells[2].Value.ToString();
                txtAccountPassWord.Text = row.Cells[3].Value.ToString();
                cbAccountType.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                Account acc = new Account();
                acc.userName = txtAccountUserName.Text;
                acc.displayName = txtAccountDisplayName.Text;
                acc.type = int.Parse(cbAccountType.Text);
                acc.passWord = txtAccountPassWord.Text;
                db.Accounts.Add(acc);
                db.SaveChanges();
                List<Account> accounts = db.Accounts.ToList();
                FillAccountDGV(accounts);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }
        private void btnModifyAccount_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                Account accUpdate = db.Accounts.AsEnumerable().FirstOrDefault(p => p.accountID == int.Parse(txtAccountID.Text));
                if (accUpdate != null)
                {
                    accUpdate.userName = txtAccountUserName.Text;
                    accUpdate.displayName = txtAccountDisplayName.Text;
                    accUpdate.type = int.Parse(cbAccountType.Text);
                    accUpdate.passWord = txtAccountPassWord.Text;
                }
                db.SaveChanges();
                List<Account> accounts = db.Accounts.ToList();
                FillAccountDGV(accounts);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            Account accDelete = db.Accounts.AsEnumerable().FirstOrDefault(p => p.accountID == int.Parse(txtAccountID.Text));
            if (accDelete != null)
            {
                if (accDelete.userName == "admin")
                {
                    MessageBox.Show("Đây là tài khoản ADMIN! Không thể xóa!");
                }
                else
                {
                    db.Accounts.Remove(accDelete);
                }
                
            }
            db.SaveChanges();
            List<Account> accounts = db.Accounts.ToList();
            FillAccountDGV(accounts);
        }


        //Tab Staff---------------------------------------------------------------
        private void FillStaffDGV(List<Staff> staffs)
        {
            dgvStaff.Rows.Clear();
            foreach (var items in staffs)
            {
                int index = dgvStaff.Rows.Add();
                dgvStaff.Rows[index].Cells[0].Value = items.staffID;
                dgvStaff.Rows[index].Cells[1].Value = items.staffName;
                dgvStaff.Rows[index].Cells[2].Value = items.gender;
                dgvStaff.Rows[index].Cells[3].Value = items.dateOfBirth.ToString("dd/MM/yyyy");
                dgvStaff.Rows[index].Cells[4].Value = items.phoneNumber;
                dgvStaff.Rows[index].Cells[5].Value = items.address;
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStaff.Rows[e.RowIndex];
                txtStaffID.Text = row.Cells[0].Value.ToString();
                txtStaffName.Text = row.Cells[1].Value.ToString();
                cbGender.Text = row.Cells[2].Value.ToString();
                mtxtDOB.Text = row.Cells[3].Value.ToString();
                txtPhoneNumber.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                Staff staff = new Staff();
                staff.staffName = txtStaffName.Text;
                staff.gender = cbGender.Text;
                staff.dateOfBirth = DateTime.Parse(mtxtDOB.Text);
                staff.phoneNumber = txtPhoneNumber.Text;
                staff.address = txtAddress.Text;
                db.Staffs.Add(staff);
                db.SaveChanges();
                List<Staff> staffs = db.Staffs.ToList();
                FillStaffDGV(staffs);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void btnModifyStaff_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantManagement db = new RestaurantManagement();
                Staff staffUpdate = db.Staffs.AsEnumerable().FirstOrDefault(p => p.staffID == int.Parse(txtStaffID.Text));
                if (staffUpdate != null)
                {
                    staffUpdate.staffName = txtStaffName.Text;
                    staffUpdate.gender = cbGender.Text;
                    staffUpdate.dateOfBirth = DateTime.Parse(mtxtDOB.Text);
                    staffUpdate.phoneNumber = txtPhoneNumber.Text;
                    staffUpdate.address = txtAddress.Text;
                    db.SaveChanges();
                    List<Staff> staffs = db.Staffs.ToList();
                    FillStaffDGV(staffs);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            Staff staffDelete = db.Staffs.AsEnumerable().FirstOrDefault(p => p.staffID == int.Parse(txtStaffID.Text));
            if (staffDelete != null)
            {
                db.Staffs.Remove(staffDelete);
            }
            db.SaveChanges();
            List<Staff> staffs = db.Staffs.ToList();
            FillStaffDGV(staffs);
        }
    }
}
