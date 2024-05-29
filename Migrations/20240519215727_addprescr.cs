using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kokos.Migrations
{
    /// <inheritdoc />
    public partial class addprescr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Meds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meds_PrescriptionId",
                table: "Meds",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meds_Prescriptions_PrescriptionId",
                table: "Meds",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meds_Prescriptions_PrescriptionId",
                table: "Meds");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Meds_PrescriptionId",
                table: "Meds");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Meds");
        }
    }
}
