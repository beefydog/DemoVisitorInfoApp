using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoVisitorInfoApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLastVisitDateAndTotalVisits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastVisitDate",
                table: "Visits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TotalVisits",
                table: "Visits",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastVisitDate",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "TotalVisits",
                table: "Visits");
        }
    }
}
