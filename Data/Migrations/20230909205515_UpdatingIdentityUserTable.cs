using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleInsurance.Data.Migrations
{
    public partial class UpdatingIdentityUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "dbo",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "dbo",
                table: "User");
        }
    }
}
