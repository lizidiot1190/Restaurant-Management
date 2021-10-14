using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace RestaurantManagement
{
    public partial class RestaurantManagement : DbContext
    {
        public RestaurantManagement()
            : base("name=RestaurantManagement")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<CustomerTable> CustomerTables { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillInfoes)
                .WithRequired(e => e.Bill)
                .HasForeignKey(e => e.idBIll)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerTable>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.CustomerTable)
                .HasForeignKey(e => e.idTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BillInfoes)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.idFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodCategory>()
                .HasMany(e => e.Foods)
                .WithRequired(e => e.FoodCategory)
                .HasForeignKey(e => e.catID)
                .WillCascadeOnDelete(false);
        }

        internal class ListBillDataSet
        {
            public ListBillDataSet()
            {
            }

            public string DataSetName { get; internal set; }
            public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
            public object USP_GetListBillByIdBill { get; internal set; }
        }

        internal class ListBillDataSetTableAdapters
        {
            internal class USP_GetListBillByIdBillTableAdapter
            {
                public USP_GetListBillByIdBillTableAdapter()
                {
                }

                public bool ClearBeforeFill { get; internal set; }

                internal void Fill(object uSP_GetListBillByIdBill, int idBill)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
