using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DL.Entities
{
    public partial class ProjZeroONeContext : DbContext
    {
        public ProjZeroONeContext()
        {
        }

        public ProjZeroONeContext(DbContextOptions<ProjZeroONeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<ShopOrder> ShopOrders { get; set; }
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

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.ToTable("LineItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__LineItem__ProdId__236943A5");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__LineItem__StoreI__22751F6C");
            });

            modelBuilder.Entity<ShopOrder>(entity =>
            {
                entity.ToTable("ShopOrder");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CName");

                entity.Property(e => e.Cost).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.ShopOrders)
                    .HasForeignKey(d => d.LineId)
                    .HasConstraintName("FK__ShopOrder__LineI__2645B050");
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
                entity.ToTable("StoreInv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ch)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CH")
                    .IsFixedLength(true);

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreInvs)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__StoreInv__StoreI__10566F31");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
