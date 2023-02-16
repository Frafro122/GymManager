using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.Infrastructure.Persistence.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5E788BC8-BB66-4584-9A05-EDC59D2D7665", "28F3A9B5-6EBC-4E93-9AC2-B93087DECCEF", "Pracownik", "PRACOWNIK" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7D0EF2AA-7C3B-4543-BA96-AE509AFA3B51", "BEA790A0-8837-4020-A926-C6977D662004", "Klient", "KLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ED6DF2F1-C364-4361-85BE-8CFB11D6ED6B", "5CDAFCAC-FECB-4E0A-B1E4-E406B4AF1246", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5E788BC8-BB66-4584-9A05-EDC59D2D7665");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D0EF2AA-7C3B-4543-BA96-AE509AFA3B51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED6DF2F1-C364-4361-85BE-8CFB11D6ED6B");
        }
    }
}
