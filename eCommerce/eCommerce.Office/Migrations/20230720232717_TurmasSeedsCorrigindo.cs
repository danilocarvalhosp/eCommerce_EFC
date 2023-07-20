using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Office.Migrations
{
    /// <inheritdoc />
    public partial class TurmasSeedsCorrigindo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
