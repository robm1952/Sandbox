namespace DataLoader.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phone()
        {
            DataUses = new HashSet<DataUse>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string Owner { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataUse> DataUses { get; set; }
    }
}
