using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_estacionamento.Migrations
{
    public partial class BancoInicialCondominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moradores",
                columns: table => new
                {
                    MoradorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Apartamento = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Bloco = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo_veiculo = table.Column<string>(type: "TEXT", nullable: true),
                    Cor = table.Column<string>(type: "TEXT", nullable: true),
                    Placa = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moradores", x => x.MoradorId);
                });

            migrationBuilder.CreateTable(
                name: "vagas",
                columns: table => new
                {
                    VagasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MoradorId = table.Column<int>(type: "INTEGER", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vagas", x => x.VagasId);
                    table.ForeignKey(
                        name: "FK_vagas_moradores_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "moradores",
                        principalColumn: "MoradorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vagas_MoradorId",
                table: "vagas",
                column: "MoradorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vagas");

            migrationBuilder.DropTable(
                name: "moradores");
        }
    }
}
