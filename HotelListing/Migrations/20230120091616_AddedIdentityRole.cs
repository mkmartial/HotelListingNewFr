using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedIdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a3d2f22-b973-49c4-baca-b89dfc6f8617", "5f38324d-5e0c-487d-8994-2a89c4bf0e03", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d8fbea8-95dd-41a0-bd7d-9d6870f062b4", "73b60680-58e8-4e63-8b27-35a6e0df7eb7", "Administator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a3d2f22-b973-49c4-baca-b89dfc6f8617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d8fbea8-95dd-41a0-bd7d-9d6870f062b4");
        }
    }
}
