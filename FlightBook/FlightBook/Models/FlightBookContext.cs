﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FlightBook.Models
{
    public partial class FlightBookContext : DbContext
    {
        public FlightBookContext()
        {
        }

        public FlightBookContext(DbContextOptions<FlightBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBookDetail> TblBookDetails { get; set; }
        public virtual DbSet<TblFlight> TblFlights { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3CGDM53;Initial Catalog=FlightBook;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblBookDetail>(entity =>
            {
                entity.ToTable("TblBookDetail");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EndDateTime)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FromPlace)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Meal)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDateTime)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ToPlace)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblFlight>(entity =>
            {
                entity.ToTable("TblFlight");

                entity.Property(e => e.Airline).HasMaxLength(100);

                entity.Property(e => e.BusinessSeats).HasMaxLength(100);

                entity.Property(e => e.Days).HasMaxLength(100);

                entity.Property(e => e.EndDateTime).HasMaxLength(100);

                entity.Property(e => e.FromPlace).HasMaxLength(100);

                entity.Property(e => e.Instrument).HasMaxLength(100);

                entity.Property(e => e.Logo).HasMaxLength(100);

                entity.Property(e => e.Meal).HasMaxLength(100);

                entity.Property(e => e.NonBusinessSeats).HasMaxLength(100);

                entity.Property(e => e.StartDateTime).HasMaxLength(100);

                entity.Property(e => e.ToPlace).HasMaxLength(100);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
