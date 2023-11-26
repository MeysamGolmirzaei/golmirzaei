using Microsoft.EntityFrameworkCore.Migrations;

namespace golmirzaeidatalayer.Migrations
{
    public partial class firstt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "tbl_Users");

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "tbl_Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "tbl_Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Family",
                table: "tbl_Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_Users");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "tbl_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
