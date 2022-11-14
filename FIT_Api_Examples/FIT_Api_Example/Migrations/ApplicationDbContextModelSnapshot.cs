﻿// <auto-generated />
using System;
using FIT_Api_Example.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FIT_Api_Example.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FIT_Api_Example.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaKorisnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDekan")
                        .HasColumnType("bit");

                    b.Property<bool>("isProdekan")
                        .HasColumnType("bit");

                    b.Property<bool>("isStudentskaSluzba")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.AkademskaGodina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AkademskaGodina");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Drzava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Ispit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.ToTable("Ispit");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Obavijest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EvidentiraoKorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("IzmijenioKorisnikID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EvidentiraoKorisnikID");

                    b.HasIndex("IzmijenioKorisnikID");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Opstina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Predmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Ects")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.PrijavaIspita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IspitID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IspitID");

                    b.HasIndex("StudentID");

                    b.ToTable("PrijavaIspita");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul2.Models.Ocjena", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BrojcanaOcjena")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.HasIndex("StudentID");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Nastavnik", b =>
                {
                    b.HasBaseType("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Student", b =>
                {
                    b.HasBaseType("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("BrojIndeksa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpstinaRodjenjaID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("OpstinaRodjenjaID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Ispit", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul1.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Obavijest", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog", "EvidentiraoKorisnik")
                        .WithMany()
                        .HasForeignKey("EvidentiraoKorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog", "IzmijenioKorisnik")
                        .WithMany()
                        .HasForeignKey("IzmijenioKorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvidentiraoKorisnik");

                    b.Navigation("IzmijenioKorisnik");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Opstina", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul1.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.PrijavaIspita", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul1.Models.Ispit", "Ispit")
                        .WithMany()
                        .HasForeignKey("IspitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Example.Modul1.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ispit");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul2.Models.Ocjena", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul1.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Example.Modul1.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Nastavnik", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FIT_Api_Example.Modul1.Models.Nastavnik", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FIT_Api_Example.Modul1.Models.Student", b =>
                {
                    b.HasOne("FIT_Api_Example.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FIT_Api_Example.Modul1.Models.Student", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Example.Modul1.Models.Opstina", "OpstinaRodjenja")
                        .WithMany()
                        .HasForeignKey("OpstinaRodjenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OpstinaRodjenja");
                });
#pragma warning restore 612, 618
        }
    }
}
