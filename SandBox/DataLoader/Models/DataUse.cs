namespace DataLoader.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataUse")]
    public partial class DataUse
    {
        public int ID { get; set; }

        public DateTime UseDate { get; set; }

        public int UseDataType { get; set; }

        public int UsePhoneId { get; set; }

        public double? UsedDataAmount { get; set; }

        public virtual DataTypeName DataTypeName { get; set; }

        public virtual Phone Phone { get; set; }
    }
}
