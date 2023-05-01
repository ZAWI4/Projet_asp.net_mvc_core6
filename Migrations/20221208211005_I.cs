using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projetasp.Migrations
{
    /// <inheritdoc />
    public partial class I : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Chefs1");

            migrationBuilder.EnsureSchema(
                name: "Menu1");

            migrationBuilder.EnsureSchema(
                name: "Plats1");

            migrationBuilder.EnsureSchema(
                name: "RES1");

            migrationBuilder.CreateTable(
                name: "Chefs",
                schema: "Chefs1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(200)", nullable: false),
                    prenom = table.Column<string>(type: "varchar(200)", nullable: false),
                    datenaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tel = table.Column<int>(type: "int", nullable: false),
                    specialite = table.Column<string>(type: "varchar(200)", nullable: false),
                    Photo = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                schema: "Menu1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(200)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                schema: "RES1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomclient = table.Column<string>(name: "Nom_client", type: "varchar(200)", nullable: false),
                    prenomclient = table.Column<string>(name: "prenom_client", type: "varchar(200)", nullable: false),
                    telclient = table.Column<int>(name: "tel_client", type: "int", nullable: false),
                    emailclient = table.Column<string>(name: "email_client", type: "varchar(200)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heure = table.Column<string>(type: "varchar(200)", nullable: false),
                    nombredepersonne = table.Column<int>(name: "nombre_de_personne", type: "int", nullable: false),
                    Message = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plats",
                schema: "Plats1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lib = table.Column<string>(type: "varchar(200)", nullable: false),
                    idMenu = table.Column<int>(name: "id_Menu", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plats_Menus_id_Menu",
                        column: x => x.idMenu,
                        principalSchema: "Menu1",
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plats_id_Menu",
                schema: "Plats1",
                table: "Plats",
                column: "id_Menu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chefs",
                schema: "Chefs1");

            migrationBuilder.DropTable(
                name: "Plats",
                schema: "Plats1");

            migrationBuilder.DropTable(
                name: "Reservations",
                schema: "RES1");

            migrationBuilder.DropTable(
                name: "Menus",
                schema: "Menu1");
        }
    }
}
