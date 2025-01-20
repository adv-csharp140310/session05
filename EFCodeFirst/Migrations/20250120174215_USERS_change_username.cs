using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class USERS_change_username : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "User_name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User_name",
                table: "Users",
                newName: "UserName");
        }
    }
}
