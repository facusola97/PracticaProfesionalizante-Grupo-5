using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class NuevaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ingredientes",
                columns: table => new
                {
                    IdIngredientes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientes", x => x.IdIngredientes);
                    
                });

            migrationBuilder.CreateTable(
                name: "ingredientesOpciones",
                columns: table => new
                {
                    IdOpcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIngredientes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientesOpciones", x => x.IdOpcion);
                });

            migrationBuilder.CreateTable(
                name: "reportePedidos",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportePedidos", x => x.IdReporte);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reporte",
                columns: table => new
                {
                    IdReporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRealizado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usuarioid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reporte", x => x.IdReporte);
                    table.ForeignKey(
                        name: "FK_reporte_usuarios_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargado = table.Column<bool>(type: "bit", nullable: false),
                    ReporteIdReporte = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_pedidos_reporte_ReporteIdReporte",
                        column: x => x.ReporteIdReporte,
                        principalTable: "reporte",
                        principalColumn: "IdReporte");
                });

            migrationBuilder.CreateTable(
                name: "opciones",
                columns: table => new
                {
                    IdOpcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PedidoIdPedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opciones", x => x.IdOpcion);
                    table.ForeignKey(
                        name: "FK_opciones_pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "pedidos",
                        principalColumn: "IdPedido");
                });

            migrationBuilder.CreateTable(
                name: "IngredientesOpcion",
                columns: table => new
                {
                    IngredientesIdIngredientes = table.Column<int>(type: "int", nullable: false),
                    OpcionesIdOpcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesOpcion", x => new { x.IngredientesIdIngredientes, x.OpcionesIdOpcion });
                    table.ForeignKey(
                        name: "FK_IngredientesOpcion_ingredientes_IngredientesIdIngredientes",
                        column: x => x.IngredientesIdIngredientes,
                        principalTable: "ingredientes",
                        principalColumn: "IdIngredientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesOpcion_opciones_OpcionesIdOpcion",
                        column: x => x.OpcionesIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "opcionesPedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOpcion = table.Column<int>(type: "int", nullable: false),
                    OpcionIdOpcion = table.Column<int>(type: "int", nullable: false),
                    PedidoIdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opcionesPedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_opcionesPedidos_opciones_OpcionIdOpcion",
                        column: x => x.OpcionIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_opcionesPedidos_pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesOpcion_OpcionesIdOpcion",
                table: "IngredientesOpcion",
                column: "OpcionesIdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_opciones_PedidoIdPedido",
                table: "opciones",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_opcionesPedidos_OpcionIdOpcion",
                table: "opcionesPedidos",
                column: "OpcionIdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_opcionesPedidos_PedidoIdPedido",
                table: "opcionesPedidos",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_ReporteIdReporte",
                table: "pedidos",
                column: "ReporteIdReporte");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_Usuarioid",
                table: "reporte",
                column: "Usuarioid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientesOpcion");

            migrationBuilder.DropTable(
                name: "ingredientesOpciones");

            migrationBuilder.DropTable(
                name: "opcionesPedidos");

            migrationBuilder.DropTable(
                name: "reportePedidos");

            migrationBuilder.DropTable(
                name: "ingredientes");

            migrationBuilder.DropTable(
                name: "opciones");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "reporte");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
