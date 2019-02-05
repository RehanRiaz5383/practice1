﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using practice1.API.Data;

namespace practice1.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("practice1.API.Model.Person", b =>
                {
                    b.Property<int>("personId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("gender");

                    b.Property<int>("perosnAge");

                    b.Property<string>("personAddress");

                    b.Property<string>("personName");

                    b.Property<string>("picUrl");

                    b.HasKey("personId");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
