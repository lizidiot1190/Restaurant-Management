namespace RestaurantManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        [Key]
        public int billIinfoID { get; set; }

        public int idBIll { get; set; }

        public int idFood { get; set; }

        public int count { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Food Food { get; set; }
    }
}
