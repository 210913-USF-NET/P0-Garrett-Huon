using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DL.Entities
{
    public partial class ProjZeroOneContext : DbContext
    {
        public ProjZeroOneContext()
        {
        }

        public ProjZeroOneContext(DbContextOptions<ProjZeroOneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreInv> StoreInvs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreInv>(entity =>
            {
                entity.HasKey(e => new { e.Ch, e.Id })
                    .HasName("PK__StoreInv__5135D4B81F18E93B");

                entity.ToTable("StoreInv");

                entity.Property(e => e.Ch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CH")
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreInvs)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__StoreInv__StoreI__00200768");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
