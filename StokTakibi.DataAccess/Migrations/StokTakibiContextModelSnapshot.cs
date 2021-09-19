﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StokTakibi.DataAccess.Concrete.EntityFramework;

namespace StokTakibi.DataAccess.Migrations
{
    [DbContext(typeof(StokTakibiContext))]
    partial class StokTakibiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StokTakibi.Entities.Concrete.StokKarti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AlisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Kdv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SatisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StokAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StokBarkod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StokKartis");
                });
#pragma warning restore 612, 618
        }
    }
}
