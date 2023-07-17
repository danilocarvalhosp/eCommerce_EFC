using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class TestandoDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Usuarios_UsuarioId",
                table: "Contatos");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartamentoUsuario_Usuarios_UsuariosId",
                table: "DepartamentoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosEntrega_Usuarios_UsuarioId",
                table: "EnderecosEntrega");

            migrationBuilder.DropIndex(
                name: "IX_Contatos_UsuarioId",
                table: "Contatos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "tb_usuarios");

            migrationBuilder.RenameColumn(
                name: "RG",
                table: "tb_usuarios",
                newName: "RegistroGeral");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "tb_usuarios",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_usuarios",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tb_usuarios",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "tb_usuarios",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Matricula",
                table: "tb_usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "tb_usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_usuarios",
                table: "tb_usuarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_tb_usuarios_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tb_usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_tb_usuarios_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "tb_usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_tb_usuarios_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "tb_usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMAIL_UNICO",
                table: "tb_usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_usuarios_Nome_CPF",
                table: "tb_usuarios",
                columns: new[] { "Nome", "CPF" });

            migrationBuilder.CreateIndex(
                name: "IX_tb_usuarios_UsuarioId",
                table: "tb_usuarios",
                column: "UsuarioId",
                unique: true,
                filter: "[UsuarioId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ColaboradorId",
                table: "Pedido",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_SupervisorId",
                table: "Pedido",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartamentoUsuario_tb_usuarios_UsuariosId",
                table: "DepartamentoUsuario",
                column: "UsuariosId",
                principalTable: "tb_usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosEntrega_tb_usuarios_UsuarioId",
                table: "EnderecosEntrega",
                column: "UsuarioId",
                principalTable: "tb_usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_usuarios_Contatos_UsuarioId",
                table: "tb_usuarios",
                column: "UsuarioId",
                principalTable: "Contatos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartamentoUsuario_tb_usuarios_UsuariosId",
                table: "DepartamentoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosEntrega_tb_usuarios_UsuarioId",
                table: "EnderecosEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_usuarios_Contatos_UsuarioId",
                table: "tb_usuarios");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_usuarios",
                table: "tb_usuarios");

            migrationBuilder.DropIndex(
                name: "IX_EMAIL_UNICO",
                table: "tb_usuarios");

            migrationBuilder.DropIndex(
                name: "IX_tb_usuarios_Nome_CPF",
                table: "tb_usuarios");

            migrationBuilder.DropIndex(
                name: "IX_tb_usuarios_UsuarioId",
                table: "tb_usuarios");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "tb_usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "tb_usuarios");

            migrationBuilder.RenameTable(
                name: "tb_usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "RegistroGeral",
                table: "Usuarios",
                newName: "RG");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_UsuarioId",
                table: "Contatos",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Usuarios_UsuarioId",
                table: "Contatos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartamentoUsuario_Usuarios_UsuariosId",
                table: "DepartamentoUsuario",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosEntrega_Usuarios_UsuarioId",
                table: "EnderecosEntrega",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
