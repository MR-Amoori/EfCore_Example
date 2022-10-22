using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore_Sample.Migrations
{
    public partial class InsertData_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "1234", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
