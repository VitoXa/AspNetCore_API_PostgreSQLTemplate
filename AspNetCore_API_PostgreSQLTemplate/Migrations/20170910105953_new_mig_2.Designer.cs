using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspNetCore_API_PostgreSQLTemplate.Data;

namespace AspNetCore_API_PostgreSQLTemplate.Migrations
{
    [DbContext(typeof(ExampleDbContext))]
    [Migration("20170910105953_new_mig_2")]
    partial class new_mig_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.TasksUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.UserTask", b =>
                {
                    b.Property<long>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TaskName");

                    b.Property<int>("UserId");

                    b.HasKey("TaskId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Task");
                });

            modelBuilder.Entity("AspNetCore_API_PostgreSQLTemplate.Models.UserTask", b =>
                {
                    b.HasOne("AspNetCore_API_PostgreSQLTemplate.Models.TasksUser", "User")
                        .WithOne("Task")
                        .HasForeignKey("AspNetCore_API_PostgreSQLTemplate.Models.UserTask", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
