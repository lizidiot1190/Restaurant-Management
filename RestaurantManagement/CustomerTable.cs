namespace RestaurantManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerTable")]
    public partial class CustomerTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerTable()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        public int tableID { get; set; }

        [Required]
        [StringLength(100)]
        public string tableName { get; set; }

        [Required]
        [StringLength(100)]
        public string tableStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
