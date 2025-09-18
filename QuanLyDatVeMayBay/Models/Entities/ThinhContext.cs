using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class ThinhContext : DbContext
{
    public ThinhContext()
    {
    }

    public ThinhContext(DbContextOptions<ThinhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IThucHanh> IThucHanhs { get; set; }

    public virtual DbSet<IiThucHanh> IiThucHanhs { get; set; }

    public virtual DbSet<IiiThucHanh> IiiThucHanhs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Connection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IThucHanh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("I_thucHanh");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<IiThucHanh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("II_thucHanh");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SoDienThoai).HasMaxLength(255);
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<IiiThucHanh>(entity =>
        {
            entity.ToTable("III_thucHanh");

            entity.Property(e => e.Mssv)
                .HasMaxLength(255)
                .HasColumnName("MSSV");
            entity.Property(e => e.SoDienThoai).HasMaxLength(255);
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
