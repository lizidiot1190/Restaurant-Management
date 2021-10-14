namespace RestaurantManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            BillInfoes = new HashSet<BillInfo>();
        }

        public int foodID { get; set; }

        [Required]
        [StringLength(100)]
        public string foodName { get; set; }

        public int catID { get; set; }

        [Required]
        [StringLength(100)]
        public string foodPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }
    }
}
