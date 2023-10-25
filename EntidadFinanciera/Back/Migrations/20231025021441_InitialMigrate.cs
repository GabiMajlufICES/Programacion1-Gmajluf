using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CuentasBancarias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroCuenta = table.Column<long>(type: "bigint", nullable: false),
                    saldo = table.Column<float>(type: "real", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clienteCBid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasBancarias", x => x.id);
                    table.ForeignKey(
                        name: "FK_CuentasBancarias_Clientes_clienteCBid",
                        column: x => x.clienteCBid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TarjetaCredito",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    limiteCredito = table.Column<float>(type: "real", nullable: false),
                    saldoActual = table.Column<float>(type: "real", nullable: false),
                    clienteTCid = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetaCredito", x => x.id);
                    table.ForeignKey(
                        name: "FK_TarjetaCredito_Clientes_clienteTCid",
                        column: x => x.clienteTCid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuentasBancarias_clienteCBid",
                table: "CuentasBancarias",
                column: "clienteCBid");

            migrationBuilder.CreateIndex(
                name: "IX_TarjetaCredito_clienteTCid",
                table: "TarjetaCredito",
                column: "clienteTCid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentasBancarias");

            migrationBuilder.DropTable(
                name: "TarjetaCredito");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
