using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysParking.Net.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamento_Gestor_GestorId",
                table: "Estacionamento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Estacionamento_GestorId",
                table: "Estacionamento");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Gestor",
                newName: "Senha");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Gestor",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Gestor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Gestor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EstacionamentoId",
                table: "Gestor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Gestor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Gestor",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Gestor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Gestor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GestorId1",
                table: "Estacionamento",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gestor_EstacionamentoId",
                table: "Gestor",
                column: "EstacionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamento_GestorId1",
                table: "Estacionamento",
                column: "GestorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamento_Gestor_GestorId1",
                table: "Estacionamento",
                column: "GestorId1",
                principalTable: "Gestor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestor_Estacionamento_EstacionamentoId",
                table: "Gestor",
                column: "EstacionamentoId",
                principalTable: "Estacionamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamento_Gestor_GestorId1",
                table: "Estacionamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Gestor_Estacionamento_EstacionamentoId",
                table: "Gestor");

            migrationBuilder.DropIndex(
                name: "IX_Gestor_EstacionamentoId",
                table: "Gestor");

            migrationBuilder.DropIndex(
                name: "IX_Estacionamento_GestorId1",
                table: "Estacionamento");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "EstacionamentoId",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Gestor");

            migrationBuilder.DropColumn(
                name: "GestorId1",
                table: "Estacionamento");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Gestor",
                newName: "senha");

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Gestor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Gestor",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstacionamentoId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Estacionamento_EstacionamentoId",
                        column: x => x.EstacionamentoId,
                        principalTable: "Estacionamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamento_GestorId",
                table: "Estacionamento",
                column: "GestorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstacionamentoId",
                table: "Usuario",
                column: "EstacionamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamento_Gestor_GestorId",
                table: "Estacionamento",
                column: "GestorId",
                principalTable: "Gestor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
