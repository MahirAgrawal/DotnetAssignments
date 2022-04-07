using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace av.Migrations
{
    public partial class secondcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_SubjectId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubjectId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "TacherId",
                table: "Teachers",
                newName: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Teachers",
                newName: "TacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectId",
                table: "Students",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_SubjectId",
                table: "Students",
                column: "SubjectId",
                principalTable: "Teachers",
                principalColumn: "TacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
