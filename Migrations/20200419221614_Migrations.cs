using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjetoEngSoftware.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_etnia",
                columns: table => new
                {
                    id_etnia = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ds_etnia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_etnia", x => x.id_etnia);
                });

            migrationBuilder.CreateTable(
                name: "tb_exame",
                columns: table => new
                {
                    id_exame = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nm_exame = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_exame", x => x.id_exame);
                });

            migrationBuilder.CreateTable(
                name: "tb_medico",
                columns: table => new
                {
                    id_medico = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nm_medico = table.Column<string>(nullable: true),
                    crm = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_medico", x => x.id_medico);
                });

            migrationBuilder.CreateTable(
                name: "tb_paciente",
                columns: table => new
                {
                    id_paciente = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nm_paciente = table.Column<string>(nullable: true),
                    tp_sexo = table.Column<char>(nullable: false),
                    EtniaId = table.Column<int>(nullable: true),
                    dt_nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_paciente", x => x.id_paciente);
                    table.ForeignKey(
                        name: "FK_tb_paciente_tb_etnia_EtniaId",
                        column: x => x.EtniaId,
                        principalTable: "tb_etnia",
                        principalColumn: "id_etnia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_docente",
                columns: table => new
                {
                    id_docente = table.Column<int>(nullable: false),
                    ds_titulacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_docente", x => x.id_docente);
                    table.ForeignKey(
                        name: "FK_tb_docente_tb_medico_id_docente",
                        column: x => x.id_docente,
                        principalTable: "tb_medico",
                        principalColumn: "id_medico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_login", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_login_tb_medico_Id",
                        column: x => x.Id,
                        principalTable: "tb_medico",
                        principalColumn: "id_medico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_residente",
                columns: table => new
                {
                    id_residente = table.Column<int>(nullable: false),
                    dt_residencia = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_residente", x => x.id_residente);
                    table.ForeignKey(
                        name: "FK_tb_residente_tb_medico_id_residente",
                        column: x => x.id_residente,
                        principalTable: "tb_medico",
                        principalColumn: "id_medico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_pedido_exame",
                columns: table => new
                {
                    IdPedidoExame = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PacienteId = table.Column<int>(nullable: true),
                    MedicoIdMedico = table.Column<int>(nullable: true),
                    ExameId = table.Column<int>(nullable: true),
                    dt_exame = table.Column<DateTime>(nullable: false),
                    ds_hipotese_diagnostica = table.Column<string>(nullable: true),
                    ds_recomendacoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_pedido_exame", x => x.IdPedidoExame);
                    table.ForeignKey(
                        name: "FK_tb_pedido_exame_tb_exame_ExameId",
                        column: x => x.ExameId,
                        principalTable: "tb_exame",
                        principalColumn: "id_exame",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_pedido_exame_tb_medico_MedicoIdMedico",
                        column: x => x.MedicoIdMedico,
                        principalTable: "tb_medico",
                        principalColumn: "id_medico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_pedido_exame_tb_paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "tb_paciente",
                        principalColumn: "id_paciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_laudo",
                columns: table => new
                {
                    id_laudo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExameId = table.Column<int>(nullable: true),
                    MedicoLaudoId = table.Column<int>(nullable: true),
                    DescricaoLaudo = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_laudo", x => x.id_laudo);
                    table.ForeignKey(
                        name: "FK_tb_laudo_tb_exame_ExameId",
                        column: x => x.ExameId,
                        principalTable: "tb_exame",
                        principalColumn: "id_exame",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_laudo_tb_residente_MedicoLaudoId",
                        column: x => x.MedicoLaudoId,
                        principalTable: "tb_residente",
                        principalColumn: "id_residente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_laudo_ExameId",
                table: "tb_laudo",
                column: "ExameId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_laudo_MedicoLaudoId",
                table: "tb_laudo",
                column: "MedicoLaudoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_paciente_EtniaId",
                table: "tb_paciente",
                column: "EtniaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_pedido_exame_ExameId",
                table: "tb_pedido_exame",
                column: "ExameId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_pedido_exame_MedicoIdMedico",
                table: "tb_pedido_exame",
                column: "MedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_tb_pedido_exame_PacienteId",
                table: "tb_pedido_exame",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_docente");

            migrationBuilder.DropTable(
                name: "tb_laudo");

            migrationBuilder.DropTable(
                name: "tb_login");

            migrationBuilder.DropTable(
                name: "tb_pedido_exame");

            migrationBuilder.DropTable(
                name: "tb_residente");

            migrationBuilder.DropTable(
                name: "tb_exame");

            migrationBuilder.DropTable(
                name: "tb_paciente");

            migrationBuilder.DropTable(
                name: "tb_medico");

            migrationBuilder.DropTable(
                name: "tb_etnia");
        }
    }
}
