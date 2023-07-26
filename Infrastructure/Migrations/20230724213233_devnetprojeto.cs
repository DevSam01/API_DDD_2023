using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class devnetprojeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_MESSAGE_AspNetUsers_ApplicationUserId",
                table: "TB_MESSAGE");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "TB_MESSAGE",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_MESSAGE_ApplicationUserId",
                table: "TB_MESSAGE",
                newName: "IX_TB_MESSAGE_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TB_MESSAGE",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "USR_TIPO",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_MESSAGE_AspNetUsers_UserId",
                table: "TB_MESSAGE",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_MESSAGE_AspNetUsers_UserId",
                table: "TB_MESSAGE");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TB_MESSAGE",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_MESSAGE_UserId",
                table: "TB_MESSAGE",
                newName: "IX_TB_MESSAGE_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "TB_MESSAGE",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "USR_TIPO",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_MESSAGE_AspNetUsers_ApplicationUserId",
                table: "TB_MESSAGE",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
