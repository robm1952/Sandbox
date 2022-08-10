using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataLoader.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DataTypeName> DataTypeNames { get; set; }
        public virtual DbSet<DataUse> DataUses { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataTypeName>()
                .Property(e => e.DataTypeName1)
                .IsFixedLength();

            modelBuilder.Entity<DataTypeName>()
                .HasMany(e => e.DataUses)
                .WithRequired(e => e.DataTypeName)
                .HasForeignKey(e => e.UseDataType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phone>()
                .Property(e => e.Owner)
                .IsFixedLength();

            modelBuilder.Entity<Phone>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Phone>()
                .HasMany(e => e.DataUses)
                .WithRequired(e => e.Phone)
                .HasForeignKey(e => e.UsePhoneId)
                .WillCascadeOnDelete(false);
        }
    }
}
