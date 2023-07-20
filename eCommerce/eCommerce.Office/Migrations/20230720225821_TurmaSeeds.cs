using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office.Migrations
{
    /// <inheritdoc />
    public partial class TurmaSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9082), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9085), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9084), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9087), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 19, 58, 21, 364, DateTimeKind.Unspecified).AddTicks(9092), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Turma A1" },
                    { 2, "Turma A2" },
                    { 3, "Turma A3" },
                    { 4, "Turma A4" },
                    { 5, "Turma A5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 4 },
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
