using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspNetCore_API_PostgreSQLTemplate.Data;

namespace AspNetCore_API_PostgreSQLTemplate.Migrations
{
    [DbContext(typeof(ExampleDbContext))]
    [Migration("20170910135058_new_mig_4")]
    partial class new_mig_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.Document", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DocumentName");

                    b.Property<int>("PersonID");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.HasIndex("PersonID")
                        .IsUnique();

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.Document", b =>
                {
                    b.HasOne("AspNetCore_API_PostgreSQLTemplate.Models.Person", "Person")
                        .WithOne("Document")
                        .HasForeignKey("AspNetCore_API_PostgreSQLTemplate.Models.Document", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
