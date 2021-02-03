﻿// <auto-generated />
using System;
using ConsultingMatch.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.Migrations
{
    [DbContext(typeof(DeveloperDbContext))]
    [Migration("20210201113501_AddedPasswordField")]
    partial class AddedPasswordField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ClientConsultant", b =>
                {
                    b.Property<int>("ListOfClientsId")
                        .HasColumnType("int");

                    b.Property<int>("ListOfConsultantsId")
                        .HasColumnType("int");

                    b.HasKey("ListOfClientsId", "ListOfConsultantsId");

                    b.HasIndex("ListOfConsultantsId");

                    b.ToTable("ClientConsultant");
                });

            modelBuilder.Entity("ConsultingMatch.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("ServiceTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ConsultingMatch.Models.Consultant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ConsultingCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PriceForOneOnOneVideoSession")
                        .HasColumnType("float");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultingCategoryId");

                    b.HasIndex("CountryId");

                    b.ToTable("Consultants");
                });

            modelBuilder.Entity("ConsultingMatch.Models.ConsultingCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfConsultants")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConsultingCategory");
                });

            modelBuilder.Entity("ConsultingMatch.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("ConsultingMatch.Models.ServiceType", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<double>("ServiceFee")
                        .HasColumnType("float");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceType");
                });

            modelBuilder.Entity("ClientConsultant", b =>
                {
                    b.HasOne("ConsultingMatch.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ListOfClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultingMatch.Models.Consultant", null)
                        .WithMany()
                        .HasForeignKey("ListOfConsultantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsultingMatch.Models.Client", b =>
                {
                    b.HasOne("ConsultingMatch.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("ConsultingMatch.Models.ServiceType", "ServiceType")
                        .WithMany()
                        .HasForeignKey("ServiceTypeId");

                    b.Navigation("Country");

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("ConsultingMatch.Models.Consultant", b =>
                {
                    b.HasOne("ConsultingMatch.Models.ConsultingCategory", "ConsultingCategory")
                        .WithMany()
                        .HasForeignKey("ConsultingCategoryId");

                    b.HasOne("ConsultingMatch.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.Navigation("ConsultingCategory");

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
