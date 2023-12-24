using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Stadiums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Stadiums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Centers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Centers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_UserId",
                table: "Stadiums",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Centers_UserId",
                table: "Centers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Centers_Users_UserId",
                table: "Centers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Users_UserId",
                table: "Stadiums",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Centers_Users_UserId",
                table: "Centers");

            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Users_UserId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_UserId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Centers_UserId",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Centers");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
