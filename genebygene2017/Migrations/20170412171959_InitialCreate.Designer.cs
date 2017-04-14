using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using genebygene2017.Data;

namespace genebygene2017.Migrations
{
    [DbContext(typeof(GGContext))]
    [Migration("20170412171959_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("genebygene2017.Models.Samples", b =>
                {
                    b.Property<int>("SampleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("CreatedBy");

                    b.Property<int>("StatusId");

                    b.HasKey("SampleId")
                        .HasName("PK_Samples");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("StatusId");

                    b.ToTable("Samples");
                });

            modelBuilder.Entity("genebygene2017.Models.Statuses", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("StatusId")
                        .HasName("PK_Statuses");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("genebygene2017.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId")
                        .HasName("PK_Users");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("genebygene2017.Models.Samples", b =>
                {
                    b.HasOne("genebygene2017.Models.Users", "CreatedByNavigation")
                        .WithMany("Samples")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("genebygene2017.Models.Statuses", "Status")
                        .WithMany("Samples")
                        .HasForeignKey("StatusId");
                });

        }
    }
}
