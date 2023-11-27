using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestaurantFaves.Models;

public partial class RestaurantFavesContext : DbContext
{
    public RestaurantFavesContext()
    {
    }

    public RestaurantFavesContext(DbContextOptions<RestaurantFavesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=RestaurantFaves;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order__3213E83F4E75C17D");

            entity.ToTable("Order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.OrderAgain).HasColumnName("orderAgain");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Restaurant)
                .HasMaxLength(40)
                .HasColumnName("restaurant");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
