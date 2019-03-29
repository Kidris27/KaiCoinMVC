using Microsoft.EntityFrameworkCore.Migrations;

namespace KaiCoinMVC.Data.Migrations
{
    public partial class ChangedToOpeningDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Account",
                newName: "OpeningDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpeningDate",
                table: "Account",
                newName: "Date");
        }
    }
}
