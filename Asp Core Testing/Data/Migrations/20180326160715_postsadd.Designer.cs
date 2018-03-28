﻿// <auto-generated />
using Asp_Core_Testing.Data;
using Asp_Core_Testing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Asp_Core_Testing.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180326160715_postsadd")]
    partial class postsadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp_Core_Testing.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateAdded");

                    b.Property<int?>("UserModelId");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Code_Snippets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CodeProjectsId");

                    b.Property<string>("CodeSnippet");

                    b.Property<DateTime?>("DateAdded");

                    b.HasKey("Id");

                    b.HasIndex("CodeProjectsId");

                    b.ToTable("Code_Snippets");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.CodeComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Code_SnippetsId");

                    b.Property<string>("Comment");

                    b.Property<DateTime?>("DateAdded");

                    b.Property<string>("Poster");

                    b.Property<string>("PosterId");

                    b.HasKey("Id");

                    b.HasIndex("Code_SnippetsId");

                    b.ToTable("CodeComments");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.CodeProjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateAdded");

                    b.Property<int?>("UserModelId");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("CodeProjects");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime?>("DateAdded");

                    b.Property<string>("Poster");

                    b.Property<string>("PosterId");

                    b.Property<int?>("PostsId");

                    b.HasKey("Id");

                    b.HasIndex("PostsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlbumId");

                    b.Property<int>("Category");

                    b.Property<DateTime?>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime?>("DateAdded");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("ModelId");

                    b.Property<int>("PostType");

                    b.Property<int?>("UserModelId");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarURL");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name");

                    b.Property<string>("ProgLanguages");

                    b.Property<string>("Specializations");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Album", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.UserModel")
                        .WithMany("Album")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Code_Snippets", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.CodeProjects")
                        .WithMany("CodeSnippets")
                        .HasForeignKey("CodeProjectsId");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.CodeComments", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.Code_Snippets")
                        .WithMany("CodeComments")
                        .HasForeignKey("Code_SnippetsId");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.CodeProjects", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.UserModel")
                        .WithMany("CodeProjects")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Comments", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.Posts")
                        .WithMany("Comments")
                        .HasForeignKey("PostsId");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Images", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.Album")
                        .WithMany("Images")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("Asp_Core_Testing.Models.Posts", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.UserModel")
                        .WithMany("Posts")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Asp_Core_Testing.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Asp_Core_Testing.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
