using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLogicLayer.Migrations.Application
{
    public partial class AddFileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Promotions");

            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Promotions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_FileId",
                table: "Promotions",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Promotions_Files_FileId",
                table: "Promotions",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_Files_FileId",
                table: "Promotions");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_FileId",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Promotions");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Promotions",
                nullable: true);
        }
    }
}
