﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoNatal.Server.dbcontext;

#nullable disable

namespace ProjetoNatal.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("ProjetoNatal.Server.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("alvo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("familia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("passe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
