namespace DataLoader.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataTypeName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataTypeName()
        {
            DataUses = new HashSet<DataUse>();
        }

        public int ID { get; set; }

        [Column("DataTypeName")]
        [StringLength(20)]
        public string DataTypeName1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataUse> DataUses { get; set; }
    }
}
