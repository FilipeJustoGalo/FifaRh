using Microsoft.EntityFrameworkCore.Migrations;

namespace CampeonatoFIFaR.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubes_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Torneios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantClube = table.Column<int>(type: "int", nullable: false),
                    ClubeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Torneios_Clubes_ClubeId",
                        column: x => x.ClubeId,
                        principalTable: "Clubes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubes_PlayerId",
                table: "Clubes",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneios_ClubeId",
                table: "Torneios",
                column: "ClubeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Torneios");

            migrationBuilder.DropTable(
                name: "Clubes");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
