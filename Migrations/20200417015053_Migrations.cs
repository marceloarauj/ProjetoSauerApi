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
                name: "login",
                columns: table => new
                {
                    login = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.login);
                });

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
                name: "tb_login",
                columns: table => new
                {
                    id_login = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_login", x => x.id_login);
                });

            migrationBuilder.CreateTable(
                name: "tb_paciente",
                columns: table => new
                {
                    id_paciente = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nm_paciente = table.Column<string>(nullable: true),
                    tp_sexo = table.Column<char>(nullable: false),
                    tp_etnia = table.Column<int>(nullable: false),
                    dt_nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_paciente", x => x.id_paciente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "tb_etnia");

            migrationBuilder.DropTable(
                name: "tb_login");

            migrationBuilder.DropTable(
                name: "tb_paciente");
        }
    }
}
