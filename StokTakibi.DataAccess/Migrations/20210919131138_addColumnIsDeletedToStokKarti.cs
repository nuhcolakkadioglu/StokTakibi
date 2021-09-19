using Microsoft.EntityFrameworkCore.Migrations;

namespace StokTakibi.DataAccess.Migrations
{
    public partial class addColumnIsDeletedToStokKarti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StokKartis",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StokKartis");
        }
    }
}
