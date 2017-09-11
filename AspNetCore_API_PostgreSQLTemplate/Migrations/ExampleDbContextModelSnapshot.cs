using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspNetCore_API_PostgreSQLTemplate.Data;

namespace AspNetCore_API_PostgreSQLTemplate.Migrations
{
    [DbContext(typeof(ExampleDbContext))]
    partial class ExampleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.Document", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DocumentName");

                    b.Property<int>("PersonId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.Document", b =>
                {
                    b.HasOne("AspNetCore_API_PostgreSQLTemplate.Models.Person", "Person")
                        .WithOne("Document")
                        .HasForeignKey("AspNetCore_API_PostgreSQLTemplate.Models.Document", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
