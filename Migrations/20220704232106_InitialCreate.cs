using Microsoft.EntityFrameworkCore.Migrations;

namespace LivresWebApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "livre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(nullable: true),
                    AnneePub = table.Column<int>(nullable: false),
                    Auteur = table.Column<string>(nullable: true),
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livre", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livre");
        }
    }
}
