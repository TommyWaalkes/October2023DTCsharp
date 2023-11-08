using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APICreation.Models;

public partial class OmdbApiContext : DbContext
{
    public OmdbApiContext()
    {
    }

    public OmdbApiContext(DbContextOptions<OmdbApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MovieDetail> MovieDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=OmdbApi;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MovieDetail>(entity =>
        {
            entity.HasKey(e => e.ImdbId);

            entity.Property(e => e.ImdbId).HasColumnName("imdbID");
            entity.Property(e => e.Dvd).HasColumnName("DVD");
            entity.Property(e => e.ImdbRating).HasColumnName("imdbRating");
            entity.Property(e => e.ImdbVotes).HasColumnName("imdbVotes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
