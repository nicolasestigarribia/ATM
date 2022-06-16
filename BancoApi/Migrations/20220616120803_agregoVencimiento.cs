using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoApi.Migrations
{
    public partial class agregoVencimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "monto",
                table: "operaciones",
                newName: "Monto");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimiento",
                table: "tarjetas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHora",
                table: "operaciones",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaVencimiento",
                table: "tarjetas");

            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "operaciones",
                newName: "monto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHora",
                table: "operaciones",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
