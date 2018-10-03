using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLogicLayer.Migrations.Application
{
    public partial class AddIsDeletedToPromotions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Promotions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Promotions");
        }
    }
}
