using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReviewDB_Project.Models.Entities
{
    public partial class ReviewDBContext : DbContext
    {
        public ReviewDBContext()
        {
        }

        public ReviewDBContext(DbContextOptions<ReviewDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChuyenBay> ChuyenBay { get; set; }
        public virtual DbSet<Ve> Ve { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-42OBLB8;Database=ReviewDB;user id=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuyenBay>(entity =>
            {
                entity.HasKey(e => e.Macb);

                entity.Property(e => e.Macb).HasColumnName("macb");

                entity.Property(e => e.Giagheloai1)
                    .HasColumnName("giagheloai1")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Giagheloai2)
                    .HasColumnName("giagheloai2")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Ngaydi)
                    .HasColumnName("ngaydi")
                    .HasColumnType("date");

                entity.Property(e => e.Sogheloai1).HasColumnName("sogheloai1");

                entity.Property(e => e.Sogheloai2).HasColumnName("sogheloai2");

                entity.Property(e => e.Tencb)
                    .HasColumnName("tencb")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ve>(entity =>
            {
                entity.HasKey(e => e.Mave);

                entity.Property(e => e.Mave).HasColumnName("mave");

                entity.Property(e => e.Cmnd)
                    .HasColumnName("cmnd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Giaghe)
                    .HasColumnName("giaghe")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.HotenKh)
                    .HasColumnName("hotenKH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Loaighe).HasColumnName("loaighe");

                entity.Property(e => e.Macb).HasColumnName("macb");

                entity.HasOne(d => d.MacbNavigation)
                    .WithMany(p => p.Ve)
                    .HasForeignKey(d => d.Macb)
                    .HasConstraintName("FK_Ve_ChuyenBay");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
