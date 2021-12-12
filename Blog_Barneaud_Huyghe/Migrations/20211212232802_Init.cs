using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_Barneaud_Huyghe.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Individu",
                columns: table => new
                {
                    IndividuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identifiant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Motdepasse = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EstBloggeur = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individu", x => x.IndividuId);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividuId = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Contenu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publication = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Individu_IndividuId",
                        column: x => x.IndividuId,
                        principalTable: "Individu",
                        principalColumn: "IndividuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commentaire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    IndividuId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Publication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Autorisation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commentaire_Individu_IndividuId",
                        column: x => x.IndividuId,
                        principalTable: "Individu",
                        principalColumn: "IndividuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_IndividuId",
                table: "Article",
                column: "IndividuId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_IndividuId",
                table: "Commentaire",
                column: "IndividuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Commentaire");

            migrationBuilder.DropTable(
                name: "Individu");
        }
    }
}
