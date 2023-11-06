using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdoptionMVC.Models;

public partial class AdoptionMvcContext : DbContext
{
    public AdoptionMvcContext()
    {
    }

    public AdoptionMvcContext(DbContextOptions<AdoptionMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pet> Pets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=AdoptionMVC;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pets__3213E83F2F4E9C5D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Breed)
                .HasMaxLength(20)
                .HasColumnName("breed");
            entity.Property(e => e.Img)
                .HasMaxLength(30)
                .HasColumnName("img");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
