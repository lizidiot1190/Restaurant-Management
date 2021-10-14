namespace RestaurantManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int staffID { get; set; }

        [Required]
        [StringLength(30)]
        public string staffName { get; set; }

        [Required]
        [StringLength(5)]
        public string gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateOfBirth { get; set; }
        [StringLength(11)]
        public string phoneNumber { get; set; }

        [StringLength(100)]
        public string address { get; set; }
    }
}
