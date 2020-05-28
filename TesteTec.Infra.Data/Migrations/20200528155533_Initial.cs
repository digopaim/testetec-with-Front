using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteTec.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDimensao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Morty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDimensao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viagem_Dimensao_IdDimensao",
                        column: x => x.IdDimensao,
                        principalTable: "Dimensao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ricks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDimensao = table.Column<int>(nullable: false),
                    IdMorty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ricks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ricks_Dimensao_IdDimensao",
                        column: x => x.IdDimensao,
                        principalTable: "Dimensao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ricks_Morty_IdMorty",
                        column: x => x.IdMorty,
                        principalTable: "Morty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dimensao",
                columns: new[] { "Id", "NomeDimensao" },
                values: new object[,]
                {
                    { 1, "C001" },
                    { 2, "C002" },
                    { 3, "C003" },
                    { 4, "C137" }
                });

            migrationBuilder.InsertData(
                table: "Morty",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "Id", "IdDimensao", "IdMorty" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_IdDimensao",
                table: "Ricks",
                column: "IdDimensao");

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_IdMorty",
                table: "Ricks",
                column: "IdMorty");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_IdDimensao",
                table: "Viagem",
                column: "IdDimensao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ricks");

            migrationBuilder.DropTable(
                name: "Viagem");

            migrationBuilder.DropTable(
                name: "Morty");

            migrationBuilder.DropTable(
                name: "Dimensao");
        }
    }
}
