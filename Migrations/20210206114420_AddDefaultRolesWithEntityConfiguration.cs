using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelsLookUp.Migrations
{
    public partial class AddDefaultRolesWithEntityConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5002ed6-f658-4e66-ac1f-a6665fd79332", "0fd9d00f-73a0-4bff-9952-34ddfa81f341", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec828491-5068-430a-9bd4-ded3788efe80", "3b56faa0-7696-4ac7-940d-c702f6cdd2c7", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5002ed6-f658-4e66-ac1f-a6665fd79332");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec828491-5068-430a-9bd4-ded3788efe80");
        }
    }
}
