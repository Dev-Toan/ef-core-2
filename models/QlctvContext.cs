using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLPB.models;

public partial class QlctvContext : DbContext
{
    public QlctvContext()
    {
    }

    public QlctvContext(DbContextOptions<QlctvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CongTacVien> CongTacViens { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NGUYEN-DUC-TOAN;Initial Catalog=QLCTV;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CongTacVien>(entity =>
        {
            entity.HasKey(e => e.MaCtv).HasName("PK__CongTacV__3DCB54E7894BC286");

            entity.ToTable("CongTacVien");

            entity.Property(e => e.MaCtv)
                .HasMaxLength(10)
                .HasColumnName("MaCTV");
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaPhong).HasMaxLength(10);
            entity.Property(e => e.SoBv).HasColumnName("SoBV");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.CongTacViens)
                .HasForeignKey(d => d.MaPhong)
                .HasConstraintName("FK__CongTacVi__MaPho__398D8EEE");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.MaPhong).HasName("PK__PhongBan__20BD5E5B9AB1616B");

            entity.ToTable("PhongBan");

            entity.Property(e => e.MaPhong).HasMaxLength(10);
            entity.Property(e => e.TenPhong).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
