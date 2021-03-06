// <auto-generated />
using System;
using GraphQLDemo.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLDemo.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GraphQL.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25f67b9a-6dd4-431d-85ec-9e6360476972"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("1ab11f87-5d41-4000-8898-d41fd485d245"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("69182a05-d547-4985-b192-0b279a9eba14"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("b5245dce-0095-4da6-b8b4-31895ff98b4f"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("92ffa377-07b8-4a9e-a21b-c4f91ccd4c29"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("b5245dce-0095-4da6-b8b4-31895ff98b4f"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("GraphQL.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ab11f87-5d41-4000-8898-d41fd485d245"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("b5245dce-0095-4da6-b8b4-31895ff98b4f"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("GraphQL.Entities.Account", b =>
                {
                    b.HasOne("GraphQL.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
