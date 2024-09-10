using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoVisitorInfoApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPathAndQueryFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastPath",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastQueryString",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastReferrerUrl",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QueryString",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastPath",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "LastQueryString",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "LastReferrerUrl",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "QueryString",
                table: "Visits");
        }
    }
}
