using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarsApi.Models;

public partial class CarDetailsContext : DbContext
{
    public CarDetailsContext()
    {
    }

    public CarDetailsContext(DbContextOptions<CarDetailsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH117\\SQLEXPRESS;Initial Catalog=CarDetails;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cars__3213E83F150B1A53");

            entity.ToTable("cars");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("carname");
            entity.Property(e => e.Companyname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("companyname");
            entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");
            entity.Property(e => e.Modelnum)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("modelnum");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
