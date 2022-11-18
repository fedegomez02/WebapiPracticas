using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalGomezFederico.Migrations
{
    public partial class crearTAabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Hospital_Cod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Num_Cama = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Hospital_Cod);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_NO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Especialidad = table.Column<string>(nullable: true),
                    Hospital_Cod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_NO);
                    table.ForeignKey(
                        name: "FK_Doctor_Hospital_Hospital_Cod",
                        column: x => x.Hospital_Cod,
                        principalTable: "Hospital",
                        principalColumn: "Hospital_Cod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Hospital_Cod",
                table: "Doctor",
                column: "Hospital_Cod");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
