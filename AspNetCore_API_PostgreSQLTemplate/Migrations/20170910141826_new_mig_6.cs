using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_API_PostgreSQLTemplate.Migrations
{
    public partial class new_mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Persons_PersonID",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Persons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Documents",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Documents",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_PersonID",
                table: "Documents",
                newName: "IX_Documents_PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Persons_PersonId",
                table: "Documents",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Persons_PersonId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persons",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Documents",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Documents",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_PersonId",
                table: "Documents",
                newName: "IX_Documents_PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Persons_PersonID",
                table: "Documents",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
