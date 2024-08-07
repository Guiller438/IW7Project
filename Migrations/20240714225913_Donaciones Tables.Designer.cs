﻿// <auto-generated />
using System;
using IW7PP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IW7PP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240714225913_Donaciones Tables")]
    partial class DonacionesTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("0100f4d0-d03e-4fd6-a8d5-2e39e7c5a3a8"),
                            AmputationName = "Below Knee"
                        },
                        new
                        {
                            Id = new Guid("7ae8dbd1-528f-41c4-a18b-e59fa13006c4"),
                            AmputationName = "Above Knee"
                        },
                        new
                        {
                            Id = new Guid("3a80fb08-2444-4325-90ba-2ddbe0d7ccbd"),
                            AmputationName = "ToePartial"
                        },
                        new
                        {
                            Id = new Guid("56ee89ba-fa30-473a-9a6f-2102756e411c"),
                            AmputationName = "ToeComplete"
                        },
                        new
                        {
                            Id = new Guid("fb172a43-bbf0-47f0-8feb-75fac69ad1ae"),
                            AmputationName = "FootPartial"
                        },
                        new
                        {
                            Id = new Guid("7f65d764-296b-4376-bdb2-80edfe641f10"),
                            AmputationName = "Lisfranc"
                        },
                        new
                        {
                            Id = new Guid("490f1718-3462-4759-8875-1686dfa00994"),
                            AmputationName = "Chopart"
                        },
                        new
                        {
                            Id = new Guid("f43923f5-865a-4caf-82da-859d2af5833f"),
                            AmputationName = "AnkleDisarticulation"
                        },
                        new
                        {
                            Id = new Guid("784bc31e-704a-49a7-963f-b14992cebc90"),
                            AmputationName = "Transtibial"
                        },
                        new
                        {
                            Id = new Guid("329c10c9-34cb-49a5-a946-ea6dd664a568"),
                            AmputationName = "KneeDisarticulation"
                        },
                        new
                        {
                            Id = new Guid("2d4057f2-dbbc-4e6d-9372-53d45a4c177d"),
                            AmputationName = "Transfemoral"
                        },
                        new
                        {
                            Id = new Guid("9aa6ff13-b1e4-42ee-883a-d2c3f61b2860"),
                            AmputationName = "HipDisarticulation"
                        },
                        new
                        {
                            Id = new Guid("1120c9b9-23c6-4b4d-924a-f073d171b31b"),
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
                            Id = new Guid("2c4b64cb-62d3-444a-bcbf-641e3096d052"),
                            AmputationName = "Finger Partial"
                        },
                        new
                        {
                            Id = new Guid("88070be0-1c32-4f04-8da4-ee86b81eadff"),
                            AmputationName = "Finger Complete"
                        },
                        new
                        {
                            Id = new Guid("9991406a-f857-4cd8-9ab4-56c44391fe9e"),
                            AmputationName = "Hand Partial"
                        },
                        new
                        {
                            Id = new Guid("5bd17c2e-4d34-4128-8e98-403b12ffa62e"),
                            AmputationName = "Wrist Disarticulation"
                        },
                        new
                        {
                            Id = new Guid("01dd424a-5856-4bb6-8bcd-2f077611c496"),
                            AmputationName = "Transradial"
                        },
                        new
                        {
                            Id = new Guid("0d26626e-af6a-467d-bf3d-c072b217dd33"),
                            AmputationName = "Elbow Disarticulation"
                        });
                });

            modelBuilder.Entity("IW7PP.Models.Cliente.ClientesProtesicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LifeStyleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("ProtesisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LifeStyleId");

                    b.HasIndex("ProtesisId");

                    b.ToTable("ClientesProtesicos");
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

            modelBuilder.Entity("IW7PP.Models.Donations.DonationRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Donaciones");
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

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("IW7PP.Models.Cliente.ClientesProtesicos", b =>
                {
                    b.HasOne("IW7PP.Models.Cliente.LifeStyle", "LifeStyle")
                        .WithMany()
                        .HasForeignKey("LifeStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IW7PP.Models.ProsthesisM.Prosthesis", "Prosthesis")
                        .WithMany()
                        .HasForeignKey("ProtesisId");

                    b.Navigation("LifeStyle");

                    b.Navigation("Prosthesis");
                });

            modelBuilder.Entity("IW7PP.Models.Donations.DonationRequests", b =>
                {
                    b.HasOne("IW7PP.Models.Cliente.ClientesProtesicos", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
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
