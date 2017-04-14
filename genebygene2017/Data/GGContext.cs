using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using genebygene2017.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace genebygene2017.Data
{

    public class GGContext : DbContext
    {
        public GGContext(DbContextOptions<GGContext> options) : base(options)
        {
        }

        public DbSet<Statuses> Statuses { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Samples> Samples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samples>(entity =>
            {
                entity.HasKey(e => e.SampleId)
                    .HasName("PK_Samples");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Samples)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Samples_Users");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Samples)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Samples_Statuses");
            });

            modelBuilder.Entity<Statuses>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_Statuses");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Users");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Statuses>().ToTable("Statuses");
        //    //modelBuilder.Entity<Users>().ToTable("Users");
        //    //modelBuilder.Entity<Samples>().ToTable("Samples");

        //    //modelBuilder.Entity<Samples>()
        //    //    .HasOne(e => e.User)
        //    //    .WithMany()
        //    //    .OnDelete(DeleteBehavior.Restrict);

        //    //modelBuilder.Entity<Samples>()
        //    //    .HasOne(e => e.Status)
        //    //    .WithMany()
        //    //    .OnDelete(DeleteBehavior.Restrict);


        //    //modelBuilder.Entity(typeof(Statuses), e =>
        //    //{
        //    //    e.Property<int>("StatusId").ValueGeneratedOnAdd();
        //    //    e.ToTable("Statuses");
        //    //});

        //    //modelBuilder.Entity(typeof(Users), e =>
        //    //{
        //    //    //e.Property<int>("UserId").ValueGeneratedOnAdd();
        //    //    e.HasMany(typeof(Samples)).WithOne().HasPrincipalKey("UserId").HasForeignKey("CreatedBy").OnDelete(DeleteBehavior.Restrict);
        //    //    e.ToTable("Users");
        //    //});
        //    //modelBuilder.Entity(typeof(Samples), e =>
        //    //{
        //    //    e.Property<int>("SampleId").ValueGeneratedOnAdd();
        //    //    //e.HasOne(typeof(Users)).WithMany().HasForeignKey("CreatedBy").OnDelete(DeleteBehavior.Restrict);
        //    //    //e.HasOne(typeof(Users)).WithMany().OnDelete(DeleteBehavior.Restrict);
        //    //    //e.HasOne(typeof(Statuses)).WithMany().OnDelete(DeleteBehavior.Restrict);
        //    //    e.ToTable("Samples");
        //    //});

        //}
    }
    
}
