﻿// <auto-generated />
using System;
using ApiHotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiHotel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241007171857_AddingSeeders")]
    partial class AddingSeeders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ApiHotel.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<int>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double")
                        .HasColumnName("total_cost");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("bokings");
                });

            modelBuilder.Entity("ApiHotel.Models.Employe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("employes");
                });

            modelBuilder.Entity("ApiHotel.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("ApiHotel.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<byte>("MaxOccupancyPersons")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("max_occupancy_person");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("room_type_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "1-1",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "1-2",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "1-3",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "1-4",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "1-5",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 6,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "1-6",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "1-7",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 8,
                            Availability = false,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "1-8",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "1-9",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "1-10",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "2-1",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 12,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "2-2",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 13,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "2-3",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 14,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "2-4",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "2-5",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 16,
                            Availability = false,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "2-6",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 17,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "2-7",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 18,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "2-8",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 19,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "2-9",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 20,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "2-10",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "3-1",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 22,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "3-2",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 23,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "3-3",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 24,
                            Availability = false,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "3-4",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 25,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "3-5",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 26,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "3-6",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 27,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "3-7",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 28,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "3-8",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 29,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "3-9",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 30,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "3-10",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 31,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "4-1",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 32,
                            Availability = false,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "4-2",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 33,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "4-3",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 34,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "4-4",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 35,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "4-5",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 36,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "4-6",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 37,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "4-7",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 38,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "4-8",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 39,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "4-9",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 40,
                            Availability = false,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "4-10",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 41,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "5-1",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 42,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "5-2",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 43,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "5-3",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 44,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "5-4",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 45,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "5-5",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 46,
                            Availability = false,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "5-6",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 47,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "5-7",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 48,
                            Availability = false,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "5-8",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 49,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "5-9",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 50,
                            Availability = false,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "5-10",
                            RoomTypeId = 1
                        });
                });

            modelBuilder.Entity("ApiHotel.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("room_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.",
                            Name = "Habitación Simple"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.",
                            Name = "Habitación Doble"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.",
                            Name = "Suite"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.",
                            Name = "Habitación Familiar"
                        });
                });

            modelBuilder.Entity("ApiHotel.Models.Booking", b =>
                {
                    b.HasOne("ApiHotel.Models.Employe", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiHotel.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiHotel.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ApiHotel.Models.Room", b =>
                {
                    b.HasOne("ApiHotel.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}