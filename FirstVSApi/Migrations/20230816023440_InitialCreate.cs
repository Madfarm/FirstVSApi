using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstVSApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DishesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    DishesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientsTable_DishesTable_DishesId",
                        column: x => x.DishesId,
                        principalTable: "DishesTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsTable_DishesId",
                table: "IngredientsTable",
                column: "DishesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientsTable");

            migrationBuilder.DropTable(
                name: "DishesTable");
        }
    }
}
