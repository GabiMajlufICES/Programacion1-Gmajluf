﻿// <auto-generated />
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Back.CuentaBancaria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("clienteCBid")
                        .HasColumnType("int");

                    b.Property<string>("nombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("numeroCuenta")
                        .HasColumnType("bigint");

                    b.Property<float>("saldo")
                        .HasColumnType("real");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("clienteCBid");

                    b.ToTable("CuentasBancarias");
                });

            modelBuilder.Entity("Back.TarjetaCredito", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("clienteTCid")
                        .HasColumnType("int");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<float>("limiteCredito")
                        .HasColumnType("real");

                    b.Property<string>("numeroTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("saldoActual")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("clienteTCid");

                    b.ToTable("TarjetaCredito");
                });

            modelBuilder.Entity("Back.CuentaBancaria", b =>
                {
                    b.HasOne("Back.Cliente", "clienteCB")
                        .WithMany()
                        .HasForeignKey("clienteCBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clienteCB");
                });

            modelBuilder.Entity("Back.TarjetaCredito", b =>
                {
                    b.HasOne("Back.Cliente", "clienteTC")
                        .WithMany()
                        .HasForeignKey("clienteTCid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clienteTC");
                });
#pragma warning restore 612, 618
        }
    }
}
