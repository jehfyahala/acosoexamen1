using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroQuejas.Data.Migrations
{
    public partial class AddQuejas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complains",
                columns: table => new
                {
                    QuejaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuejaFecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuejaDni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaCopia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaNum = table.Column<int>(type: "int", nullable: false),
                    QuejaDependencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaQueja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaHechos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuejaPrueba = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complains", x => x.QuejaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complains");
        }
    }
}
