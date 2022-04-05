using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoConnectDb.Models
{
    public partial class DataDbContextEntities : DbContext
    {
        public DataDbContextEntities()
        {
        }

        public DataDbContextEntities(DbContextOptions<DataDbContextEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Diemthi> Diemthi { get; set; }
        public virtual DbSet<Hocky> Hocky { get; set; }
        public virtual DbSet<Hocsinh> Hocsinh { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<Monhoc> Monhoc { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-13F9CN2\\SQLEXPRESS;Database=QLVT;user id=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.Property(e => e.NameCategory).HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCus);

                entity.Property(e => e.IdCus).HasColumnName("idCus");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200);

                entity.Property(e => e.NameCus)
                    .IsRequired()
                    .HasColumnName("nameCus")
                    .HasMaxLength(200);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Diemthi>(entity =>
            {
                entity.HasKey(e => new { e.Mahs, e.Mamon, e.Hk });

                entity.ToTable("DIEMTHI");

                entity.Property(e => e.Mahs)
                    .HasColumnName("MAHS")
                    .HasMaxLength(50);

                entity.Property(e => e.Mamon)
                    .HasColumnName("MAMON")
                    .HasMaxLength(50);

                entity.Property(e => e.Hk)
                    .HasColumnName("HK")
                    .HasMaxLength(50);

                entity.Property(e => e.Diemlan1).HasColumnName("DIEMLAN1");

                entity.Property(e => e.Diemlan2).HasColumnName("DIEMLAN2");

                entity.Property(e => e.Ghichu)
                    .HasColumnName("GHICHU")
                    .HasColumnType("text");

                entity.HasOne(d => d.HkNavigation)
                    .WithMany(p => p.Diemthi)
                    .HasForeignKey(d => d.Hk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIEMTHI_HOCKY");

                entity.HasOne(d => d.MahsNavigation)
                    .WithMany(p => p.Diemthi)
                    .HasForeignKey(d => d.Mahs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIEMTHI_HOCSINH");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany(p => p.Diemthi)
                    .HasForeignKey(d => d.Mamon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIEMTHI_MONHOC");
            });

            modelBuilder.Entity<Hocky>(entity =>
            {
                entity.HasKey(e => e.Hk);

                entity.ToTable("HOCKY");

                entity.Property(e => e.Hk)
                    .HasColumnName("HK")
                    .HasMaxLength(50);

                entity.Property(e => e.Ghichu)
                    .HasColumnName("GHICHU")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hocsinh>(entity =>
            {
                entity.HasKey(e => e.Mahs);

                entity.ToTable("HOCSINH");

                entity.Property(e => e.Mahs)
                    .HasColumnName("MAHS")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.Hohs)
                    .HasColumnName("HOHS")
                    .HasMaxLength(50);

                entity.Property(e => e.Malop)
                    .HasColumnName("MALOP")
                    .HasMaxLength(50);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("NGAYSINH")
                    .HasColumnType("date");

                entity.Property(e => e.Noisinh)
                    .HasColumnName("NOISINH")
                    .HasMaxLength(50);

                entity.Property(e => e.Tenhs)
                    .HasColumnName("TENHS")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MalopNavigation)
                    .WithMany(p => p.Hocsinh)
                    .HasForeignKey(d => d.Malop)
                    .HasConstraintName("FK_HOCSINH_LOP");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.IdInv);

                entity.Property(e => e.IdInv).HasColumnName("idInv");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCus).HasColumnName("idCus");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("totalPrice")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdCusNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.IdCus)
                    .HasConstraintName("FK_Invoice_Customer");
            });

            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasKey(e => new { e.IdInv, e.IdProd });

                entity.Property(e => e.IdInv).HasColumnName("idInv");

                entity.Property(e => e.IdProd).HasColumnName("idProd");

                entity.Property(e => e.PriceSale).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Promotion).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdInvNavigation)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.IdInv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_Invoice");

                entity.HasOne(d => d.IdProdNavigation)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.IdProd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_Product");
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.Malop);

                entity.ToTable("LOP");

                entity.Property(e => e.Malop)
                    .HasColumnName("MALOP")
                    .HasMaxLength(50);

                entity.Property(e => e.Tenlop)
                    .HasColumnName("TENLOP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Monhoc>(entity =>
            {
                entity.HasKey(e => e.Mamon);

                entity.ToTable("MONHOC");

                entity.Property(e => e.Mamon)
                    .HasColumnName("MAMON")
                    .HasMaxLength(50);

                entity.Property(e => e.Sotiet).HasColumnName("SOTIET");

                entity.Property(e => e.Tenmon)
                    .HasColumnName("TENMON")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProd);

                entity.Property(e => e.IdProd).HasColumnName("idProd");

                entity.Property(e => e.NameProd)
                    .IsRequired()
                    .HasColumnName("nameProd")
                    .HasMaxLength(200);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.HasOne(d => d.IdCateNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IdCate)
                    .HasConstraintName("FK_Product_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
