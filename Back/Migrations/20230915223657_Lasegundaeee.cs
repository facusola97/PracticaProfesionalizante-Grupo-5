using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    public partial class Lasegundaeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reporte_usuarios_Usuarioid",
                table: "reporte");

            migrationBuilder.AddColumn<int>(
                name: "pedidoIdPedido",
                table: "reportePedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "reporteIdReporte",
                table: "reportePedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Usuarioid",
                table: "reporte",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_reportePedidos_pedidoIdPedido",
                table: "reportePedidos",
                column: "pedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_reportePedidos_reporteIdReporte",
                table: "reportePedidos",
                column: "reporteIdReporte");

            migrationBuilder.AddForeignKey(
                name: "FK_reporte_usuarios_Usuarioid",
                table: "reporte",
                column: "Usuarioid",
                principalTable: "usuarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_reportePedidos_pedidos_pedidoIdPedido",
                table: "reportePedidos",
                column: "pedidoIdPedido",
                principalTable: "pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reportePedidos_reporte_reporteIdReporte",
                table: "reportePedidos",
                column: "reporteIdReporte",
                principalTable: "reporte",
                principalColumn: "IdReporte",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reporte_usuarios_Usuarioid",
                table: "reporte");

            migrationBuilder.DropForeignKey(
                name: "FK_reportePedidos_pedidos_pedidoIdPedido",
                table: "reportePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_reportePedidos_reporte_reporteIdReporte",
                table: "reportePedidos");

            migrationBuilder.DropIndex(
                name: "IX_reportePedidos_pedidoIdPedido",
                table: "reportePedidos");

            migrationBuilder.DropIndex(
                name: "IX_reportePedidos_reporteIdReporte",
                table: "reportePedidos");

            migrationBuilder.DropColumn(
                name: "pedidoIdPedido",
                table: "reportePedidos");

            migrationBuilder.DropColumn(
                name: "reporteIdReporte",
                table: "reportePedidos");

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "pedidos");

            migrationBuilder.AlterColumn<int>(
                name: "Usuarioid",
                table: "reporte",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_reporte_usuarios_Usuarioid",
                table: "reporte",
                column: "Usuarioid",
                principalTable: "usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
