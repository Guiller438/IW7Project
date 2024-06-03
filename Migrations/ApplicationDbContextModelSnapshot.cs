﻿// <auto-generated />
using System;
using IW7PP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IW7PP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IW7PP.Models.Amputations.LowerLimbAmputation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AmputationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LowerLimbAmputations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5c237fc7-25e6-4f4e-8881-dd80131c6169"),
                            AmputationName = "Below Knee"
                        },
                        new
                        {
                            Id = new Guid("eb2fdb82-7434-4e4d-bdca-c53c66ff18d9"),
                            AmputationName = "Above Knee"
                        },
                        new
                        {
                            Id = new Guid("03f6120a-5fe8-434f-83e5-82e50a4ce438"),
                            AmputationName = "ToePartial"
                        },
                        new
                        {
                            Id = new Guid("5975536c-9837-44b5-bdaf-24edee8fd7fa"),
                            AmputationName = "ToeComplete"
                        },
                        new
                        {
                            Id = new Guid("1a506915-7368-4947-a28d-97228f344662"),
                            AmputationName = "FootPartial"
                        },
                        new
                        {
                            Id = new Guid("e056bf8b-b140-419e-b921-e6d5c0b7ebf2"),
                            AmputationName = "Lisfranc"
                        },
                        new
                        {
                            Id = new Guid("9d18904a-3cd0-4701-8555-08c015874463"),
                            AmputationName = "Chopart"
                        },
                        new
                        {
                            Id = new Guid("704d785e-d24c-4832-9697-ade07716289a"),
                            AmputationName = "AnkleDisarticulation"
                        },
                        new
                        {
                            Id = new Guid("e4f15b72-d015-48e9-ac59-3ba806c92993"),
                            AmputationName = "Transtibial"
                        },
                        new
                        {
                            Id = new Guid("96b8e4c0-c19f-45d6-9040-26bc4ad5b545"),
                            AmputationName = "KneeDisarticulation"
                        },
                        new
                        {
                            Id = new Guid("96d2bf06-e884-4df4-9a53-a8eddee5694f"),
                            AmputationName = "Transfemoral"
                        },
                        new
                        {
                            Id = new Guid("e396ded0-1035-4b56-9782-d943a0341fd5"),
                            AmputationName = "HipDisarticulation"
                        },
                        new
                        {
                            Id = new Guid("37fe1f4e-058b-449a-a321-0112ad782c3d"),
                            AmputationName = "Hemipelvectomy"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.Amputations.UpperLimbAmputation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AmputationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UpperLimbAmputations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf4275bf-76fb-4183-a55e-ffbedca1398b"),
                            AmputationName = "Finger Partial"
                        },
                        new
                        {
                            Id = new Guid("6674355c-74c7-431a-b255-41a6e15d3f1f"),
                            AmputationName = "Finger Complete"
                        },
                        new
                        {
                            Id = new Guid("0d371bc7-cfdc-4a25-8a3f-831b521236ac"),
                            AmputationName = "Hand Partial"
                        },
                        new
                        {
                            Id = new Guid("191af8c8-378f-48c7-a2b0-d4eab05fc649"),
                            AmputationName = "Wrist Disarticulation"
                        },
                        new
                        {
                            Id = new Guid("8fe2e47b-68c0-48cd-a5e5-36e54e4864c2"),
                            AmputationName = "Transradial"
                        },
                        new
                        {
                            Id = new Guid("ec7c2d2b-849e-4f30-a11a-166f38d1d757"),
                            AmputationName = "Elbow Disarticulation"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.Cliente.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LifeStyleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProsthesisId")
                        .HasColumnType("int");

                    b.Property<int>("ProtesisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LifeStyleId");

                    b.HasIndex("ProsthesisId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("IW7PP.Models.Cliente.LifeStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("promedioDesgaste")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("LifeStyles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "El estilo de vida sedentario implica baja actividad física y largos periodos sentados, a menudo por trabajo o uso de dispositivos",
                            Name = "Sedentary",
                            promedioDesgaste = 0.5
                        },
                        new
                        {
                            Id = 2,
                            Description = "Un estilo de vida activo incluye actividad física moderada y regular, con ejercicios de intensidad moderada",
                            Name = "Activo",
                            promedioDesgaste = 1.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "El estilo de vida de un deportista se enfoca en alta actividad física y rendimiento, dedicando mucho tiempo al entrenamiento",
                            Name = "Deportista",
                            promedioDesgaste = 1.5
                        });
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.Foot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Durability")
                        .HasMaxLength(2)
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Feet");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Foot 1 Description",
                            Durability = 6.0,
                            Name = "Foot 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Foot 2 Description",
                            Durability = 12.0,
                            Name = "Foot 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Foot 3 Description",
                            Durability = 18.0,
                            Name = "Foot 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Foot 4 Description",
                            Durability = 24.0,
                            Name = "Foot 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Foot 5 Description",
                            Durability = 30.0,
                            Name = "Foot 5"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.KneeArticulate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Durability")
                        .HasMaxLength(2)
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("KneeArticulates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "KneeArticulate 1 Description",
                            Durability = 6.0,
                            Name = "KneeArticulate 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "KneeArticulate 2 Description",
                            Durability = 12.0,
                            Name = "KneeArticulate 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "KneeArticulate 3 Description",
                            Durability = 18.0,
                            Name = "KneeArticulate 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "KneeArticulate 4 Description",
                            Durability = 24.0,
                            Name = "KneeArticulate 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "KneeArticulate 5 Description",
                            Durability = 30.0,
                            Name = "KneeArticulate 5"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.Liner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Durability")
                        .HasMaxLength(2)
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Liners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Liner 1 Description",
                            Durability = 6.0,
                            Name = "Liner 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Liner 2 Description",
                            Durability = 12.0,
                            Name = "Liner 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Liner 3 Description",
                            Durability = 18.0,
                            Name = "Liner 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Liner 4 Description",
                            Durability = 24.0,
                            Name = "Liner 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Liner 5 Description",
                            Durability = 30.0,
                            Name = "Liner 5"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.Prosthesis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AverageDurability")
                        .HasColumnType("float");

                    b.Property<double>("Durability")
                        .HasColumnType("float");

                    b.Property<int?>("FootId")
                        .HasColumnType("int");

                    b.Property<int?>("KneeArticulateId")
                        .HasColumnType("int");

                    b.Property<int?>("LinerId")
                        .HasColumnType("int");

                    b.Property<Guid?>("LowerLimbAmputationsiD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SocketId")
                        .HasColumnType("int");

                    b.Property<int?>("TubeId")
                        .HasColumnType("int");

                    b.Property<int?>("UnionSocketId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UpperLimbAmputationsiD")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FootId");

                    b.HasIndex("KneeArticulateId");

                    b.HasIndex("LinerId");

                    b.HasIndex("LowerLimbAmputationsiD");

                    b.HasIndex("SocketId");

                    b.HasIndex("TubeId");

                    b.HasIndex("UnionSocketId");

                    b.HasIndex("UpperLimbAmputationsiD");

                    b.ToTable("Prostheses");
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.Socket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Durability")
                        .HasMaxLength(2)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Sockets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Socket 1",
                            Durability = 6.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Socket 2",
                            Durability = 12.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Socket 3",
                            Durability = 18.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Socket 4",
                            Durability = 24.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Socket 5",
                            Durability = 30.0
                        });
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.Tube", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Durability")
                        .HasMaxLength(2)
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Tubes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Tube 1 Description",
                            Durability = 6.0,
                            Name = "Tube 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tube 2 Description",
                            Durability = 12.0,
                            Name = "Tube 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Tube 3 Description",
                            Durability = 18.0,
                            Name = "Tube 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tube 4 Description",
                            Durability = 24.0,
                            Name = "Tube 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Tube 5 Description",
                            Durability = 30.0,
                            Name = "Tube 5"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.UnionSocket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Durability")
                        .HasMaxLength(2)
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("UnionSockets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "UnionSocket 1 Description",
                            Durability = 6.0,
                            Name = "UnionSocket 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "UnionSocket 2 Description",
                            Durability = 12.0,
                            Name = "UnionSocket 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "UnionSocket 3 Description",
                            Durability = 18.0,
                            Name = "UnionSocket 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "UnionSocket 4 Description",
                            Durability = 24.0,
                            Name = "UnionSocket 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "UnionSocket 5 Description",
                            Durability = 30.0,
                            Name = "UnionSocket 5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IW7PP.Models.UserModel", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("UserModel");
                });

            modelBuilder.Entity("IW7PP.Models.Cliente.Cliente", b =>
                {
                    b.HasOne("IW7PP.Models.Cliente.LifeStyle", "LifeStyle")
                        .WithMany()
                        .HasForeignKey("LifeStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW7PP.Models.ProsthesisM.Prosthesis", "Prosthesis")
                        .WithMany()
                        .HasForeignKey("ProsthesisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LifeStyle");

                    b.Navigation("Prosthesis");
                });

            modelBuilder.Entity("IW7PP.Models.ProsthesisM.Prosthesis", b =>
                {
                    b.HasOne("IW7PP.Models.ProsthesisM.Foot", "Foot")
                        .WithMany()
                        .HasForeignKey("FootId");

                    b.HasOne("IW7PP.Models.ProsthesisM.KneeArticulate", "RodillaArticulada")
                        .WithMany()
                        .HasForeignKey("KneeArticulateId");

                    b.HasOne("IW7PP.Models.ProsthesisM.Liner", "Liner")
                        .WithMany()
                        .HasForeignKey("LinerId");

                    b.HasOne("IW7PP.Models.Amputations.LowerLimbAmputation", "LowerLimbAmputations")
                        .WithMany()
                        .HasForeignKey("LowerLimbAmputationsiD");

                    b.HasOne("IW7PP.Models.ProsthesisM.Socket", "Socket")
                        .WithMany()
                        .HasForeignKey("SocketId");

                    b.HasOne("IW7PP.Models.ProsthesisM.Tube", "Tube")
                        .WithMany()
                        .HasForeignKey("TubeId");

                    b.HasOne("IW7PP.Models.ProsthesisM.UnionSocket", "UnionSocket")
                        .WithMany()
                        .HasForeignKey("UnionSocketId");

                    b.HasOne("IW7PP.Models.Amputations.UpperLimbAmputation", "UpperLimbAmputations")
                        .WithMany()
                        .HasForeignKey("UpperLimbAmputationsiD");

                    b.Navigation("Foot");

                    b.Navigation("Liner");

                    b.Navigation("LowerLimbAmputations");

                    b.Navigation("RodillaArticulada");

                    b.Navigation("Socket");

                    b.Navigation("Tube");

                    b.Navigation("UnionSocket");

                    b.Navigation("UpperLimbAmputations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
