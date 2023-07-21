using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office.Migrations
{
    /// <inheritdoc />
    public partial class ColaboradorToVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "VeiculoId");

            migrationBuilder.RenameColumn(
                name: "ColaboradoresId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradorId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculoId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataInicioVinculo",
                table: "ColaboradorVeiculo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7478), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7503), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7502), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7508), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 21, 0, 30, 333, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Nome", "Placa" },
                values: new object[,]
                {
                    { 1, "Fiat Argo", "ABC-1234" },
                    { 2, "Fiat Mobi", "DEF-1234" },
                    { 3, "Fiat Siena", "GHI-1234" },
                    { 4, "Fiat Palio", "JKL-1234" },
                    { 5, "Fiat Idea", "MNO-1234" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradorId",
                table: "ColaboradorVeiculo",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradorId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DataInicioVinculo",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "VeiculosId");

            migrationBuilder.RenameColumn(
                name: "ColaboradorId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradoresId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculosId");

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5647), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5674), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5677), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 20, 27, 17, 766, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo",
                column: "ColaboradoresId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo",
                column: "VeiculosId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
