﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDoSolutionsApi.data;

namespace ToDoSolutionsApi.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20190923021843_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ToDoSolutionsApi.Models.DailyTask", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nameOfDay");

                    b.Property<int>("priority");

                    b.Property<string>("remarks");

                    b.Property<string>("status");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("dailyTasks");
                });

            modelBuilder.Entity("ToDoSolutionsApi.Models.ProposedTask", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("priority");

                    b.Property<string>("remarks");

                    b.Property<string>("status");

                    b.Property<string>("title");

                    b.Property<string>("titleLink");

                    b.HasKey("id");

                    b.ToTable("proposedTasks");
                });
#pragma warning restore 612, 618
        }
    }
}