using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetePizza.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precioPedido = table.Column<double>(type: "float", nullable: false),
                    UseridUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.idPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuario_UseridUsuario",
                        column: x => x.UseridUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    idPizza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePizza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precioPizza = table.Column<double>(type: "float", nullable: false),
                    PedidosidPedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.idPizza);
                    table.ForeignKey(
                        name: "FK_Pizzas_Pedidos_PedidosidPedido",
                        column: x => x.PedidosidPedido,
                        principalTable: "Pedidos",
                        principalColumn: "idPedido");
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    idIngrediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreIngrediente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    IsGlutenFree = table.Column<bool>(type: "bit", nullable: false),
                    PizzaidPizza = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.idIngrediente);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Pizzas_PizzaidPizza",
                        column: x => x.PizzaidPizza,
                        principalTable: "Pizzas",
                        principalColumn: "idPizza");
                });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "idIngrediente", "IsGlutenFree", "PizzaidPizza", "cantidad", "nombreIngrediente", "precio", "tipo" },
                values: new object[,]
                {
                    { 1, true, null, 2, "Tomate", 0.22, "Fruta" },
                    { 2, false, null, 3, "Prosciutto", 1.3, "Carne" },
                    { 3, true, null, 4, "Queso Parmesano", 2.5, "Lácteo" },
                    { 4, true, null, 1, "Aceite de Oliva", 3.0, "Condimento" },
                    { 5, true, null, 2, "Tomate", 0.22, "Fruta" },
                    { 6, true, null, 1, "Espinaca", 0.29999999999999999, "Vegetal" },
                    { 7, true, null, 2, "Champiñones", 0.25, "Hongos" },
                    { 8, true, null, 2, "Tomate", 0.22, "Fruta" },
                    { 9, false, null, 3, "Pepperoni", 1.5, "Carne" },
                    { 10, true, null, 1, "Oregano", 0.10000000000000001, "Hierba" },
                    { 11, true, null, 2, "Tomate", 0.22, "Fruta" },
                    { 12, true, null, 3, "Queso Mozzarella", 2.0, "Lácteo" },
                    { 13, true, null, 2, "Queso Cheddar", 1.5, "Lácteo" },
                    { 14, true, null, 2, "Queso Gouda", 1.8, "Lácteo" },
                    { 15, true, null, 2, "Queso Brie", 2.2000000000000002, "Lácteo" },
                    { 16, true, null, 2, "Queso Roquefort", 3.5, "Lácteo" },
                    { 17, true, null, 2, "Queso Gruyere", 2.6000000000000001, "Lácteo" },
                    { 18, true, null, 2, "Queso Emmental", 2.2999999999999998, "Lácteo" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "idPizza", "PedidosidPedido", "nombrePizza", "precioPizza" },
                values: new object[,]
                {
                    { 1, null, "Clasica", 13.1 },
                    { 2, null, "Veggie", 7.7000000000000002 },
                    { 3, null, "Pepperoni", 7.0 },
                    { 4, null, "Margarita", 10.4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_PizzaidPizza",
                table: "Ingredientes",
                column: "PizzaidPizza");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UseridUsuario",
                table: "Pedidos",
                column: "UseridUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PedidosidPedido",
                table: "Pizzas",
                column: "PedidosidPedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
