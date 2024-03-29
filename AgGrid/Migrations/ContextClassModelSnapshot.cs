﻿// <auto-generated />
using AgGrid.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AgGrid.Migrations
{
    [DbContext(typeof(ContextClass))]
    partial class ContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AgGrid.Models.Product", b =>
                {
                    b.Property<int>("pId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("pId"));

                    b.Property<string>("pCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("pName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("pQuantity")
                        .HasColumnType("integer");

                    b.HasKey("pId");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
