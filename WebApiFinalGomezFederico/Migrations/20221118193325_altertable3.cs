using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalGomezFederico.Migrations
{
    public partial class altertable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_Hospital_Cod",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospital",
                table: "Hospital");

            migrationBuilder.RenameTable(
                name: "Hospital",
                newName: "hospital");

            migrationBuilder.AddColumn<int>(
                name: "numeroTelefono",
                table: "hospital",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_hospital",
                table: "hospital",
                column: "Hospital_Cod");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_hospital_Hospital_Cod",
                table: "Doctor",
                column: "Hospital_Cod",
                principalTable: "hospital",
                principalColumn: "Hospital_Cod",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_hospital_Hospital_Cod",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hospital",
                table: "hospital");

            migrationBuilder.DropColumn(
                name: "numeroTelefono",
                table: "hospital");

            migrationBuilder.RenameTable(
                name: "hospital",
                newName: "Hospital");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospital",
                table: "Hospital",
                column: "Hospital_Cod");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Hospital_Hospital_Cod",
                table: "Doctor",
                column: "Hospital_Cod",
                principalTable: "Hospital",
                principalColumn: "Hospital_Cod",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
