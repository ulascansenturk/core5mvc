﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ctbl.Data.Concrete.EntityFramework.Contexts;

namespace ctbl.Data.Migrations
{
    [DbContext(typeof(ctblMvcContext))]
    [Migration("20210822191944_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ctbl.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(4443),
                            Date = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(3126),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(5381),
                            Note = "C# article",
                            SeoAuthor = "ulasdev",
                            SeoDescription = "C# Testing article",
                            SeoTags = "C#,Javascript,.NetCore,.Net,.NetFramework",
                            Thumbnail = "Default.jpg",
                            Title = "C# Testing article",
                            UserId = 1,
                            ViewsCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(7878),
                            Date = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(7876),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(7880),
                            Note = "C++ article",
                            SeoAuthor = "ulasdev",
                            SeoDescription = "C++ Testing article",
                            SeoTags = "C#,Javascript,.NetCore,.Net,.NetFramework",
                            Thumbnail = "Default.jpg",
                            Title = "C++ Testing article",
                            UserId = 1,
                            ViewsCount = 123
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(7889),
                            Date = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(7887),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 237, DateTimeKind.Local).AddTicks(7891),
                            Note = "Javascript article",
                            SeoAuthor = "ulasdev",
                            SeoDescription = "Javascript Testing article",
                            SeoTags = "C#,Javascript,.NetCore,.Net,.NetFramework",
                            Thumbnail = "Default.jpg",
                            Title = "Javascript Testing article",
                            UserId = 1,
                            ViewsCount = 150
                        });
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 241, DateTimeKind.Local).AddTicks(2452),
                            Description = "Testing the description of C# category",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 241, DateTimeKind.Local).AddTicks(2477),
                            Name = "C#",
                            Note = "C# Category"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 241, DateTimeKind.Local).AddTicks(2498),
                            Description = "Testing the description of C++ category",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 241, DateTimeKind.Local).AddTicks(2500),
                            Name = "C++",
                            Note = "C++ Category"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 241, DateTimeKind.Local).AddTicks(2506),
                            Description = "Testing the description of Javascript category",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 241, DateTimeKind.Local).AddTicks(2508),
                            Name = "Javascript",
                            Note = "Javascript Category"
                        });
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 244, DateTimeKind.Local).AddTicks(4712),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 244, DateTimeKind.Local).AddTicks(4735),
                            Note = "C# comment",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 244, DateTimeKind.Local).AddTicks(4756),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 244, DateTimeKind.Local).AddTicks(4758),
                            Note = "C++ comment",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 244, DateTimeKind.Local).AddTicks(4764),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 244, DateTimeKind.Local).AddTicks(4766),
                            Note = "Javascript comment",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                        });
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 246, DateTimeKind.Local).AddTicks(5342),
                            Description = "Root privilige",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 246, DateTimeKind.Local).AddTicks(5363),
                            Name = "Root",
                            Note = "Root User"
                        });
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EmailAdress")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "InitialCreate",
                            CreatedDate = new DateTime(2021, 8, 22, 22, 19, 44, 261, DateTimeKind.Local).AddTicks(7457),
                            Description = "First root user",
                            EmailAdress = "ulascansenturk@hotmail.com",
                            FirstName = "Ulas",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Senturk",
                            ModifiedBy = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 8, 22, 22, 19, 44, 261, DateTimeKind.Local).AddTicks(7559),
                            Note = "Root user",
                            PasswordHash = new byte[] { 57, 53, 102, 52, 52, 101, 48, 51, 50, 49, 101, 100, 57, 54, 98, 97, 57, 100, 50, 57, 54, 49, 97, 53, 52, 100, 97, 97, 98, 48, 53, 101 },
                            Picture = "User.jpg",
                            RoleId = 1,
                            Username = "ulasdev"
                        });
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Article", b =>
                {
                    b.HasOne("ctbl.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ctbl.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("ctbl.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.User", b =>
                {
                    b.HasOne("ctbl.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ctbl.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
