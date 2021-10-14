using Microsoft.Reporting.WinForms;
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

namespace RestaurantManagement
{
    public partial class fReceipt : DevExpress.XtraEditors.XtraForm
    {
        int idTable, idBill;
        string user;
        public fReceipt(int idt, int idb, string u)
        {
            idTable = idt;
            idBill = idb;
            user = u;
            InitializeComponent();
        }

        private void fReceipt_Load(object sender, EventArgs e)
        {
            RestaurantManagement db = new RestaurantManagement();
            Bill bill = db.Bills.AsEnumerable().FirstOrDefault(p => p.billID == idBill);
            Account acc = db.Accounts.AsEnumerable().FirstOrDefault(p => p.userName == user);
            ReportParameter[] para = new ReportParameter[6];
            para[0] = new ReportParameter("DateTime", bill.checkOut?.ToString("dd/MM/yyyy"));
            para[1] = new ReportParameter("tableName", bill.CustomerTable.tableName);
            para[2] = new ReportParameter("billID", bill.billID.ToString());
            para[3] = new ReportParameter("timeIn", bill.checkIn.ToString("hh:mm:ss"));
            para[4] = new ReportParameter("timeOut", bill.checkOut?.ToString("hh:mm:ss"));
            para[5] = new ReportParameter("userName", acc.displayName);
            //ListBillDataSet listBillDataSet = new ListBillDataSet();
            //ListBillDataSetTableAdapters.USP_GetListBillByIdBillTableAdapter tableAdapter = new ListBillDataSetTableAdapters.USP_GetListBillByIdBillTableAdapter();
            //tableAdapter.Fill(listBillDataSet.USP_GetListBillByIdBill, idTable);


            string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = string.Format("EXEC dbo.USP_GetListBillByIdBill @idBill={0}",idBill);
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();

            var datasource = new ReportDataSource("ListBill", data);
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
