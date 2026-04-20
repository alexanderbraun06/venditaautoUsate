using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autousate.Migrations
{
    /// <inheritdoc />
    public partial class AutoUsateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concessionarie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConcessionaria = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concessionarie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdConcessionaria = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcessionariaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clienti_Concessionarie_ConcessionariaId",
                        column: x => x.ConcessionariaId,
                        principalTable: "Concessionarie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAuto = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    Produttore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modello = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPrimaImmatricolazione = table.Column<DateOnly>(type: "date", nullable: false),
                    Targa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroKm = table.Column<double>(type: "float", nullable: false),
                    Prezzo = table.Column<double>(type: "float", nullable: false),
                    ConcessionariaId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auto_Clienti_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auto_Concessionarie_ConcessionariaId",
                        column: x => x.ConcessionariaId,
                        principalTable: "Concessionarie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_ClienteId",
                table: "Auto",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_ConcessionariaId",
                table: "Auto",
                column: "ConcessionariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clienti_ConcessionariaId",
                table: "Clienti",
                column: "ConcessionariaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Concessionarie");
        }
    }
}
