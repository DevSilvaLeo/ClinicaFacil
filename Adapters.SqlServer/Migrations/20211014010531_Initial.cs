using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adapters.SqlServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    IdCargo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.IdCargo);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCargo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCarteira = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeConselho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdFuncionario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    IdProcedimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeProcedimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.IdProcedimento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Procedimento");
        }
    }
}
