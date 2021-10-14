namespace RestaurantManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int accountID { get; set; }

        [Required]
        [StringLength(100)]
        public string userName { get; set; }

        [Required]
        [StringLength(100)]
        public string displayName { get; set; }

        [Required]
        [StringLength(1000)]
        public string passWord { get; set; }

        public int type { get; set; }
    }
}
